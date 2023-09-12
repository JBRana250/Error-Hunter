using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

// this script will handle everything that will happen when you start playing a level

public class StartManager : MonoBehaviour
{
    public ReferenceManager refManager;
    public BlockGenerator blockGenerator;

    void Start()
    {
        // determine what code templates will be spawned in the current level
        // later, create logic to determine what code templates will be spawned. for now, just add all of them.

        // Iterate through all code templates to be added and add them to the code database.
        foreach(CodeTemplatesScriptableObject codeTemplate in refManager.syntaxErrorTemplates)
        {
            CodeDatabase.currentCodeTemplates.Add(codeTemplate);
        }
        foreach(CodeTemplatesScriptableObject codeTemplate in refManager.normalCodeTemplates)
        {
            CodeDatabase.currentCodeTemplates.Add(codeTemplate);
        }
        
        // add in characters to TextCharSize dictionary to auto-size blocks
        if(TextCharSize.Characters.Count == 0)
        {
            TextCharSize.AddCharacters();
        }
        
        // start generating blocks
        StartCoroutine(blockGenerator.GenerateBlocks());


    }
}
