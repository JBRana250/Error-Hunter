using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{
    // this script will manage score, combo and lives since all systems are interlinked.
    private TextMeshProUGUI score;
    private TextMeshProUGUI combo;
    private TextMeshProUGUI lives;
    private int comboIncrement;
    private int comboLevel;

    void Start()
    {
        score = gameObject.GetComponent<TextMeshProUGUI>();
        combo = GameObject.Find("Combo").GetComponent<TextMeshProUGUI>();
        lives = GameObject.Find("Lives").GetComponent<TextMeshProUGUI>();
        comboIncrement = 0;
        comboLevel = 1;
    }

    public void IncreaseScore()
    {
        score.text = (int.Parse(score.text) + comboLevel).ToString();

        comboIncrement += 1;
        if(comboIncrement >= comboLevel+1)
        {
            comboLevel += 1;
            combo.text = comboLevel.ToString();
            comboIncrement = 0;
        }   
        if(int.Parse(score.text) >= 100)
        {
            score.fontSize = 20;
        }
    }

    public void ReduceLives()
    {
        // gets the number of lives as a string, converts it to a number and decreases it by one, then sets that number as the new display.
        lives.text = (int.Parse(lives.text) - 1).ToString();
        comboLevel = 1;
        comboIncrement = 0;
        combo.text = comboLevel.ToString();
        if(lives.text == "0")
        {
            //game over
            CrossSceneManager.CrossSceneScore = score.text;
            SceneManager.LoadScene("ScoreScreen");
        }
    }
}
