using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// this script detects if you click the block

public class ClickDetector : MonoBehaviour
{
    public BlockController blockController;

    void OnMouseDown()
    {
        blockController.BlockClicked();
    }
}
