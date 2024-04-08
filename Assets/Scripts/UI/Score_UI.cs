using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score_UI : MonoBehaviour
{
    public TextMeshProUGUI scoreText;  // Unity Edit�r�nde metin nesnesini s�r�kleyip b�rakaca��n�z public bir Text de�i�keni.

    private int score = -6;
    private float increaseRate = 300.0f;


    void Update()
    {
        score += Mathf.RoundToInt(increaseRate * Time.deltaTime);
        scoreText.text = score.ToString();
        Debug.Log("Skor: " + score);
    }
}
