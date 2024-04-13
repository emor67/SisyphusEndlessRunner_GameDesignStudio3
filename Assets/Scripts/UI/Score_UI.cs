using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score_UI : MonoBehaviour
{
    public TextMeshProUGUI scoreText; 

    private int score = -2;
    private float increaseRate = 100.0f;


    void Update()
    {
        score += Mathf.RoundToInt(increaseRate * Time.deltaTime);
        scoreText.text = score.ToString();
    }
}
