using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NavButtonsScript : MonoBehaviour
{
    public string GameScreen;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartGame()
    {
        //switches scene to GameScreen.
        SceneManager.LoadScene(GameScreen);
    }

    public void QuitGame()
    {
        //quits out of the game
        Application.Quit();
    }
}
