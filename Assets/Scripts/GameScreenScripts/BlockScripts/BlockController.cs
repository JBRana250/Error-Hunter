using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class BlockController : MonoBehaviour
{
    public float ySpeed;
    public CodeTemplatesScriptableObject CodeTemplate;
    private TextMeshProUGUI Score;
    private TextMeshProUGUI Lives;
    private Camera cam;

    private float camLerp;
    private Color targetColor;

    private Vector4 BlueV4;
    private Vector4 RedV4;

    private GameObject refManagerGO;
    private ReferenceManager refManager;

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
        refManagerGO = GameObject.FindWithTag("RefManager");
        refManager = refManagerGO.GetComponent<ReferenceManager>();
        Score = refManager.score.GetComponent<TextMeshProUGUI>();
        Lives = refManager.lives.GetComponent<TextMeshProUGUI>();
        cam = refManager.mCamera;
        
        if(CodeTemplate.Error == true)
        {
            // reads the text on score, turns it into int and adds 1 to it. Then, turns the result into a string and makes it the new score.
            Score.text = (int.Parse(Score.text) + 1).ToString();
        } 
        if(CodeTemplate.Error == false)
        {
            ReduceLives();
        } 
        Destroy(gameObject);
        
    }
    public void BlockReachedBottom()
    {
        refManagerGO = GameObject.FindWithTag("RefManager");
        refManager = refManagerGO.GetComponent<ReferenceManager>();
        Score = refManager.score.GetComponent<TextMeshProUGUI>();
        Lives = refManager.lives.GetComponent<TextMeshProUGUI>();
        cam = refManager.mCamera;
        
        if(CodeTemplate.Error == true)
        {
            ReduceLives();
        } 
        if(CodeTemplate.Error == false)
        {
            Score.text = (int.Parse(Score.text) + 1).ToString();
        }
        Destroy(gameObject);
        
    }

    void ReduceLives()
    {
        // reduces lives by 1.
        Lives.text = (int.Parse(Lives.text) - 1).ToString();
        if(Lives.text == "0")
        {
            //game over
            CrossSceneManager.CrossSceneScore = Score.text;
            SceneManager.LoadScene("ScoreScreen");
        }
    }
}
