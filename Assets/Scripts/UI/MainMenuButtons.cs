using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuButtons : MonoBehaviour
{
    public string gameSceneName = "Dev1Scene"; // Name of the game scene to load

    public void LoadGameScene()
    {
        SceneManager.LoadScene(gameSceneName); // Load the game scene
        Time.timeScale = 1f;
    }
}
