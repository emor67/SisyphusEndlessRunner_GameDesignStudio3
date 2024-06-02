using UnityEngine;
using TMPro;

public class Score_UI : MonoBehaviour
{
    public TextMeshProUGUI scoreText; 

    private float increaseRate = 100.0f;

    void Update()
    {
        int increment = Mathf.RoundToInt(increaseRate * Time.deltaTime);
        ScoreManager.Instance.AddScore(increment);
        scoreText.text = ScoreManager.Instance.GetCurrentScore().ToString();
    }
}
