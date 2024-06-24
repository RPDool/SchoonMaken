using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI; 

public class WinCondition : MonoBehaviour
{
    public string targetTag = "TargetObject"; 
    public GameObject winScreen; 

    void Start()
    {
        if (winScreen != null)
        {
            winScreen.SetActive(false);
        }
    }

    void Update()
    {
        GameObject[] remainingObjects = GameObject.FindGameObjectsWithTag(targetTag);

        if (remainingObjects.Length == 0)
        {
            DisplayWinScreen();
        }
    }

    void DisplayWinScreen()
    {
        if (winScreen != null)
        {
            winScreen.SetActive(true);
        }
        else
        {
            Debug.Log("You Win!");
        }

        // Pauses the game
        Time.timeScale = 0f;
    }
}