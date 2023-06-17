// This script will generate the blocks falling down.

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockGenerator : MonoBehaviour
{
    // Static means that these variables belong to this class, and not an object. There will only be a single copy of these variables. https://answers.unity.com/questions/235836/what-exactly-is-static.html
    public bool generatingBlocks;
    private float xMax;
    private float xMin;
    private float xSpawn;
    private float ySpawn;
    private float ySpeed;
    private Vector2 spawnPos;
    public GameObject blockGO; //stands for block game object, is a naming convention.
    private GameObject blockReference;

    void Start()
    {
        StartCoroutine(GenerateBlocks());
    }

    public IEnumerator GenerateBlocks()
    {
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

            // waits 0.5 seconds
            yield return new WaitForSeconds(0.5f);
        }
    }
}