using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TextController : MonoBehaviour
{
    public GameObject TextGO;
    private TextMeshPro TMPLine1;
    private TextMeshPro TMPLine2;
    private TextMeshPro TMPLine3;
    public CodeTemplatesScriptableObject CodeTemplate;

    // Start is called before the first frame update
    void Start()
    {
        //Depending on NumOfLines, add text boxes and fill them in.
        //add in seperate textGOs depending on how many lines needed
        if(CodeTemplate.NumOfLines == 1) {
            //add and fill 1 line of text
            TMPLine1 = TextGO.AddComponent<TextMeshPro>();
            TMPLine1.fontSize = 2;
            TMPLine1.color = new Color32(34, 43, 206, 255);
            TMPLine1.margin = new Vector4(0.1f,0,0,0);
            TMPLine1.text = CodeTemplate.Line1;
        } if(CodeTemplate.NumOfLines == 2) {
            // add and fill 2 lines of text
        } if(CodeTemplate.NumOfLines == 3) {
            // add and fill 3 lines of text
        }
    }
}

// Heres a good idea: make different "text" prefabs, then I can just instantiate them and attach them to the blocks that need them?