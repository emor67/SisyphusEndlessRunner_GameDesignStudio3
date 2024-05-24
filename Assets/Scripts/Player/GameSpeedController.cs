using UnityEngine;
using UnityEngine.SceneManagement;

public class GameSpeedController : MonoBehaviour
{
    public float speedIncreaseAmount = 0.1f; // Amount to increase speed by
    public float timeBetweenSpeedIncreases = 10f; // Time between speed increases
    public string targetSceneName = "Dev1Scene"; // Name of the scene to reset time scale

    private float nextSpeedIncreaseTime;

    void Start()
    {
        nextSpeedIncreaseTime = Time.time + timeBetweenSpeedIncreases; // Set initial time for speed increase
        SceneManager.sceneLoaded += OnSceneLoaded; // Subscribe to scene loaded event
    }

    void Update()
    {
        // Check if it's time to increase speed
        if (Time.time >= nextSpeedIncreaseTime)
        {
            Time.timeScale += speedIncreaseAmount; // Increase game speed
            nextSpeedIncreaseTime = Time.time + timeBetweenSpeedIncreases; // Set next speed increase time
        }
    }

    void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        if (scene.name == targetSceneName)
        {
            ResetTimeScale(); // Reset time scale when the target scene is loaded
        }
    }

    void ResetTimeScale()
    {
        Time.timeScale = 1f; // Reset time scale to normal
    }

    void OnDestroy()
    {
        SceneManager.sceneLoaded -= OnSceneLoaded; // Unsubscribe from scene loaded event
    }
}