using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockController : MonoBehaviour
{
    public float ySpeed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // move block downward
        transform.Translate(new Vector2(0f,-ySpeed) * Time.deltaTime, Space.World);
    }
}
