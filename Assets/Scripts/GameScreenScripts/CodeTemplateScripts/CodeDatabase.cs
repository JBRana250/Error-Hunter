using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// This script will hold the list of code templates to be used in the current game session.

static class CodeDatabase
{
    public static List<CodeTemplatesScriptableObject> currentCodeTemplates = new List<CodeTemplatesScriptableObject>();

    // logs all code templates inside currentCodeTemplates
    // public static void LogCurrentCodeTemplates()
    // {
    //     foreach(CodeTemplatesScriptableObject codeTemplate in currentCodeTemplates)
    //     {
    //         Debug.Log(string.Format("{0}: NumOfLines:{1}, Error:{2}, Line1:{3}, Line2:{4}, Line3:{5}",codeTemplate.name,codeTemplate.NumOfLines,codeTemplate.Error,codeTemplate.Line1,codeTemplate.Line2,codeTemplate.Line3));
    //     }
    // }
    public static CodeTemplatesScriptableObject GetRandomCodeTemplate()
    {
        CodeTemplatesScriptableObject RandomCodeTemplate = currentCodeTemplates[Random.Range(0, currentCodeTemplates.Count)];
        return RandomCodeTemplate;
    }
}