using UnityEngine;
using TMPro;

public class Score_UI : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public static int score;
    private float increaseRate = 100f;

  

    void Update()
    {
        score += Mathf.RoundToInt(increaseRate * Time.deltaTime);
        scoreText.text = score.ToString();

        if (score > PlayerPrefs.GetInt("highscore"))
        {
            PlayerPrefs.SetInt("highscore", score);
        }
    }

    public void ResetScore()
    {
        PlayerPrefs.SetInt("lastscore", score);
        score = 0;
    }
}
