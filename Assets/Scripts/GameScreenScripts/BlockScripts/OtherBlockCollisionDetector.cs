using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OtherBlockCollisionDetector : MonoBehaviour
{
    public BlockController blockController;

    // checks if block collides with other block.
    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.tag == "Block")
        {
            // passes the actual Block gameobject as the parameter (not the OtherBlockCollisionTrigger GO)
            blockController.TouchedOtherBlock(col.gameObject.transform.parent.gameObject);
        }
    }
    // checks if block is still colliding with other block.
    void OnTriggerStay2D(Collider2D col)
    {
        if(col.tag == "Block")
        {
            blockController.TouchingOtherBlock();
        }
    }
}
