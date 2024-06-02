using UnityEngine;
using TMPro;

public class DisplayScores : MonoBehaviour
{
    public TextMeshProUGUI lastScoreText;
    public TextMeshProUGUI highestScoreText;

    private void Start()
    {
        lastScoreText.text = "Last Score: " + PlayerPrefs.GetInt("lastscore").ToString();
        highestScoreText.text = "Highest Score: " + PlayerPrefs.GetInt("highscore").ToString();
    }
}
