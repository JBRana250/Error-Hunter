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
    private BlockController blockController;
    private GameObject textReference;
    private CodeTemplatesScriptableObject randCodeTemplate;
    public Vector2 blockMargin;
    private Vector2 blockSize;

    public float WaitTime;
    private float TimeElapsed;

    private int WaitInt;
    
    private string text;
    private Vector2 CharSize;
    private float LineTotalX;
    private float TotalX;
    private float TotalY;

    public float FontSize;

    public IEnumerator GenerateBlocks()
    {
        generatingBlocks = true;
        WaitInt = 0;
        
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

            // get a random code template for the block to use
            randCodeTemplate = CodeDatabase.GetRandomCodeTemplate();

            // spawns block at the top of the screen, and sets variables for the block.
            blockReference = Instantiate(blockGO, spawnPos, Quaternion.identity);
            blockController = blockReference.GetComponent<BlockController>();
            blockController.ySpeed = Random.Range(0.25f,1.25f);
            blockController.CodeTemplate = randCodeTemplate;

            // calculate size of block according to characters in each line of text
            blockSize = CalculateBlockSize(randCodeTemplate.Text);

            // set size of block according to code template information and blockMargin
            blockReference.transform.localScale = blockSize + blockMargin;

            // instantiate a text prefab, put the text in and parent the textGO to the block for each line of text.

            foreach(string textline in randCodeTemplate.Text)
            {
                text += textline;
                text += "\n";
            }

            textReference = Instantiate(textGO, spawnPos, Quaternion.identity);
            textReference.GetComponent<TextMeshPro>().text = text;
            textReference.GetComponent<RectTransform>().sizeDelta = blockSize;
            textReference.transform.SetParent(blockReference.transform);

            text = "";
            
   
            // waits a specified amount of seconds
            yield return new WaitForSeconds(WaitTime);
            WaitInt += 1;

            // makes sure that WaitTime is only adjusted every time 10 blocks spawn. Hopefully this reduces the difficulty curve
            if(WaitInt >= 10)
            {
                // waittime decreased the more it goes on, slowly generating more and more blocks.
                TimeElapsed += WaitTime;
                WaitTime -= (TimeElapsed/1000);

                // randomises wait time
                WaitTime += Random.Range(-0.1f,0.5f);

                // clamps wait time to be greater or equal to 0.5s
                if(WaitTime < 0.5f)
                {
                    WaitTime = 0.5f;
                }

                WaitInt = 0;
            }
        }
    }

    private Vector2 CalculateBlockSize(List<string> Text)
    {
        TotalX = 0;
        TotalY = 0;
        foreach (string Line in Text)
        {
            LineTotalX = 0;
            foreach (char Character in Line)
            {
                try {
                    CharSize = TextCharSize.Characters[Character.ToString()].charSize;
                } catch {

                }
                
                LineTotalX += CharSize.x;
            }
            if(LineTotalX > TotalX)
            {
                TotalX = LineTotalX;
            }
            TotalY += 0.12f;
        }
        TotalX = TotalX*FontSize;
        TotalY = TotalY*FontSize;
        return new Vector2 (TotalX,TotalY);
    }
}