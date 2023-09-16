using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BlockController : MonoBehaviour
{
    public float ySpeed;
    public float otherySpeed;
    public CodeTemplatesScriptableObject CodeTemplate;
    private Camera cam;

    private float camLerp;
    private Color targetColor;

    private Vector4 BlueV4;
    private Vector4 RedV4;

    private ReferenceManager refManager;
    private ScoreManager scoreManager;

    // obtain all references
    void Start()
    {
        refManager = GameObject.FindWithTag("RefManager").GetComponent<ReferenceManager>();
        cam = refManager.mCamera;
        scoreManager = refManager.score.GetComponent<ScoreManager>();
    }

    // Update is called once per frame
    void Update()
    {
        // move block downward
        transform.Translate(new Vector2(0f,-ySpeed) * Time.deltaTime, Space.World);
        if(transform.position.y < -6f)
        {
            Destroy(gameObject);
        }
    }

    public void BlockClicked()
    {
        // vector4 of colors blue and red. might use later
        // BlueV4 = new Vector4(85f,255f,110f,255f); 
        // RedV4 = new Vector4(255f, 0f, 0f, 255f);
        
        
        if(CodeTemplate.Error == true)
        {
            scoreManager.IncreaseScore();
        } 
        if(CodeTemplate.Error == false)
        {
            scoreManager.ReduceLives();
        } 
        Destroy(gameObject);
    }
    public void BlockReachedBottom()
    {
        if(CodeTemplate.Error == true)
        {
            scoreManager.ReduceLives();
        } 
        if(CodeTemplate.Error == false)
        {
            scoreManager.IncreaseScore();
        }
        Destroy(gameObject);   
    }
    // check if other block's speed is less, and if so, set this block's speed to the other block's speed.
    // this should fix the overlap issue since if the blocks fall at the same speed at the exact moment they start to overlap, then they will stop overlapping.
    public void TouchedOtherBlock(GameObject GO)
    {
        otherySpeed = GO.GetComponent<BlockController>().ySpeed;
        if (otherySpeed < ySpeed)
        {
            // sets ySpeed to be equal to the other block's speed.
            ySpeed = otherySpeed;
        }
    }
    // if remains in continuous contact with another block, this moves this block upwards, counteracting the downwards movement previously resulting in the block remaining stationary until the block is no longer in contact with another block.
    // This is for the cases where blocks spawn on top of each other.
    public void TouchingOtherBlock()
    {
        transform.Translate(new Vector2(0f,ySpeed) * Time.deltaTime, Space.World);
    }
}