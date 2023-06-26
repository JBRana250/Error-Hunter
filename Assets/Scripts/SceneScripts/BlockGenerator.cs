// This script will generate the blocks falling down.

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockGenerator : MonoBehaviour
{
    public bool generatingBlocks;
    private float xMax;
    private float xMin;
    private float xSpawn;
    private float ySpawn;
    private float ySpeed;
    private Vector2 spawnPos;
    private GameObject blockGO; //stands for block game object, is a naming convention.
    public GameObject RefManager;
    private GameObject blockReference;

    public IEnumerator GenerateBlocks()
    {
        generatingBlocks = true;
        
        // obtain reference to block game object
        blockGO = RefManager.GetComponent<ReferenceManager>().blockPrefabs[0];
        
        ySpawn = 6f;
        xMax = 9.25f;
        xMin = -9.25f;

        while(generatingBlocks)
        {
            // create a random x value and spawn position of the block
            xSpawn = Random.Range(xMin, xMax);
            spawnPos = new Vector2 (xSpawn, ySpawn);

            // spawns block at the top of the screen, and sets variables for the block.
            blockReference = Instantiate(blockGO, spawnPos, Quaternion.identity);
            blockReference.GetComponent<BlockController>().ySpeed = Random.Range(0.1f,2);

            // set text of block
            blockReference.GetComponent<TextController>().CodeTemplate = CodeDatabase.GetRandomCodeTemplate();
            
            // waits 0.5 seconds
            yield return new WaitForSeconds(0.5f);
        }
    }
}