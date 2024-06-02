using UnityEngine;
using TMPro;

public class DisplayScores : MonoBehaviour
{
    public TextMeshProUGUI lastScoreText;
    public TextMeshProUGUI highestScoreText;

    private void Start()
    {
        lastScoreText.text = "Last Score: " + ScoreManager.Instance.GetLastScore().ToString();
        highestScoreText.text = "Highest Score: " + ScoreManager.Instance.GetHighestScore().ToString();
    }
}
