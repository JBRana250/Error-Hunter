using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BBCollisionDetector : MonoBehaviour
{
    public BlockController blockController;

    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.tag == "BottomBar")
        {
            blockController.BlockReachedBottom();
        }
    }
}
