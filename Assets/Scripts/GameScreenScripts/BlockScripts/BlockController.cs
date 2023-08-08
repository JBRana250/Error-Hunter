using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BlockController : MonoBehaviour
{
    public float ySpeed;
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
}