using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score_UI : MonoBehaviour
{
    public TextMeshProUGUI scoreText;  // Unity Editöründe metin nesnesini sürükleyip býrakacaðýnýz public bir Text deðiþkeni.

    private int score = -6;
    private float increaseRate = 300.0f;


    void Update()
    {
        score += Mathf.RoundToInt(increaseRate * Time.deltaTime);
        scoreText.text = score.ToString();
        Debug.Log("Skor: " + score);
    }
}
