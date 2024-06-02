/*using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager Instance { get; private set; }

    private int currentScore;
    private int lastScore;
    private int highestScore;

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);

        LoadScores();
    }

    public int GetCurrentScore()
    {
        return currentScore;
    }

    public void AddScore(int amount)
    {
        currentScore += amount;
        SaveScores();
    }

    public void ResetScore()
    {
        lastScore = currentScore;
        if (currentScore > highestScore)
        {
            highestScore = currentScore;
        }
        currentScore = 0;
        SaveScores();
    }

    public int GetLastScore()
    {
        return lastScore;
    }

    public int GetHighestScore()
    {
        return highestScore;
    }

    private void SaveScores()
    {
        PlayerPrefs.SetInt("LastScore", lastScore);
        PlayerPrefs.SetInt("HighestScore", highestScore);
    }

    private void LoadScores()
    {
        lastScore = PlayerPrefs.GetInt("LastScore", 0);
        highestScore = PlayerPrefs.GetInt("HighestScore", 0);
    }
}*/
