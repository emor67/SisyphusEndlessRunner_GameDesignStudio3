using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score_UI : MonoBehaviour
{
    public TextMeshProUGUI scoreText;  // Unity Editöründe metin nesnesini sürükleyip bırakacağınız public bir Text değişkeni.

    private int score = -6;
    private float increaseRate = 300.0f;


    void Update()
    {
        score += Mathf.RoundToInt(increaseRate * Time.deltaTime);
        scoreText.text = score.ToString();
        Debug.Log("Skor: " + score);
    }
}
