using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// This script handles the creation of a scriptable object that holds the data of all possible code templates, to be used in CodeDatabase when deciding which ones to include for the current session.

[CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/CodeTemplatesScriptableObject", order = 1)]
public class CodeTemplatesScriptableObject : ScriptableObject
{
    public bool Error;
    public List<string> Text;
}
