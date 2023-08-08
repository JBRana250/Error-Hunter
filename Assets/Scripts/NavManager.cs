using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

// this script handles navigation between scenes.
// it is in a prefab so that I can access it across scenes.
// if I made it static, then unity's in-built onclick function for the buttons would not detect the functions in this script for some reason.

public class NavManager : MonoBehaviour
{
    public void NavToScene(string Scene)
    {
        SceneManager.LoadScene(Scene);
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
