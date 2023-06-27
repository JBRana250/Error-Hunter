// This script will generate the blocks falling down.

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

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
    private GameObject textGO;
    public GameObject RefManager;
    private GameObject blockReference;
    private GameObject textReference;
    private CodeTemplatesScriptableObject randCodeTemplate;
    public Vector2 blockMargin;

    public IEnumerator GenerateBlocks()
    {
        generatingBlocks = true;
        
        // obtain reference to block game object
        blockGO = RefManager.GetComponent<ReferenceManager>().blockPrefabs[0];
        // obtain reference to text prefab
        textGO = RefManager.GetComponent<ReferenceManager>().textPrefabs[0];
        
        ySpawn = 6f;
        xMax = 9.25f;
        xMin = -9.25f;

        // represents the extra space horizontally and vertically
        blockMargin = new Vector2(0.2f,0.2f);

        while(generatingBlocks)
        {
            // create a random x value and spawn position of the block
            xSpawn = Random.Range(xMin, xMax);
            spawnPos = new Vector2 (xSpawn, ySpawn);

            // spawns block at the top of the screen, and sets variables for the block.
            blockReference = Instantiate(blockGO, spawnPos, Quaternion.identity);
            blockReference.GetComponent<BlockController>().ySpeed = Random.Range(1f,1.25f);

            // get a random code template for the block to use
            randCodeTemplate = CodeDatabase.GetRandomCodeTemplate();

            // set size of block according to code template information and blockMargin
            blockReference.transform.localScale = randCodeTemplate.BlockSize + blockMargin;

            // instantiate a text prefab, put the text in and parent the textGO to the block.
            textReference = Instantiate(textGO, spawnPos, Quaternion.identity);
            textReference.GetComponent<TextMeshPro>().text = randCodeTemplate.Text;
            textReference.GetComponent<RectTransform>().sizeDelta = randCodeTemplate.BlockSize;
            textReference.transform.SetParent(blockReference.transform);

            // set codetemplate to the variable in textcontroller of block
            blockReference.GetComponent<TextController>().CodeTemplate = randCodeTemplate;

            
            
            // waits 0.5 seconds
            yield return new WaitForSeconds(0.5f);
        }
    }
}