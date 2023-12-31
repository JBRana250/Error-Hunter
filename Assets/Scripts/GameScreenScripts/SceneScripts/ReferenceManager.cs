using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReferenceManager : MonoBehaviour
{
    // scriptable objects
    public ScriptableObject[] syntaxErrorTemplates;
    public ScriptableObject[] normalCodeTemplates;

    //--------------------
    // prefabs
    public GameObject[] blockPrefabs;
    public GameObject[] textPrefabs;

    //--------------------
    // UI elements
    public Canvas canvas;
    public GameObject score;
    public GameObject lives;

    //--------------------
    // Scene objects
    public Camera mCamera;
}
