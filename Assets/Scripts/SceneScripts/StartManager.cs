using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

// this script will handle everything that will happen when you start playing a level

public class StartManager : MonoBehaviour
{
    public ReferenceManager refManager;
    public BlockGenerator blockGenerator;

    public int NumOfTemplatesToBeAdded;

    void Start()
    {
        // determine what code templates will be spawned in the current level
        // later, create logic to determine what code templates will be spawned. for now, just add all of them.
        NumOfTemplatesToBeAdded = 3;
        Array TemplatesToBeAdded = Array.CreateInstance(typeof(CodeTemplatesScriptableObject), NumOfTemplatesToBeAdded);
        refManager.syntaxErrorTemplates.CopyTo(TemplatesToBeAdded, 0);

        // Iterate through all code templates to be added and add them to the code database.
        foreach(CodeTemplatesScriptableObject codeTemplate in TemplatesToBeAdded)
        {
            CodeDatabase.currentCodeTemplates.Add(codeTemplate);
        }
        
        // start generating blocks
        StartCoroutine(blockGenerator.GenerateBlocks());        
    }
}
