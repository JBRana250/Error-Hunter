using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitConfirmScript : MonoBehaviour
{
    public GameObject QuitConfirmationDialogue;
    public GameObject Title;
    public GameObject PlayButton;
    public GameObject QuitButton;

    private CanvasGroup canvasGroup;

    public void ShowQuitConfirmationDialogue()
    {
        canvasGroup = QuitConfirmationDialogue.GetComponent<CanvasGroup>();
        
        canvasGroup.alpha = 1;
        canvasGroup.interactable = true;
        canvasGroup.blocksRaycasts = true;

        Title.GetComponent<SpriteRenderer>().enabled = false;
        Title.GetComponent<CanvasGroup>().alpha = 0;

        canvasGroup = PlayButton.GetComponent<CanvasGroup>();
        canvasGroup.alpha = 0;
        canvasGroup.interactable = false;
        canvasGroup.blocksRaycasts = false;

        canvasGroup = QuitButton.GetComponent<CanvasGroup>();
        canvasGroup.alpha = 0;
        canvasGroup.interactable = false;
        canvasGroup.blocksRaycasts = false;
    }

    public void HideQuitConfirmDialogue()
    {
        canvasGroup = QuitConfirmationDialogue.GetComponent<CanvasGroup>();
        
        canvasGroup.alpha = 0;
        canvasGroup.interactable = false;
        canvasGroup.blocksRaycasts = false;

        Title.GetComponent<SpriteRenderer>().enabled = true;
        Title.GetComponent<CanvasGroup>().alpha = 1;

        canvasGroup = PlayButton.GetComponent<CanvasGroup>();
        canvasGroup.alpha = 1;
        canvasGroup.interactable = true;
        canvasGroup.blocksRaycasts = true;

        canvasGroup = QuitButton.GetComponent<CanvasGroup>();
        canvasGroup.alpha = 1;
        canvasGroup.interactable = true;
        canvasGroup.blocksRaycasts = true;
    }
}
