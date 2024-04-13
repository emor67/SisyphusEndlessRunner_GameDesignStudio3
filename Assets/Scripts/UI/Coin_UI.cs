using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Coin_UI : MonoBehaviour
{
    private int coins = 0;
    [SerializeField] private TextMeshProUGUI coinText;

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("Coin"))
        {
            Destroy(collision.gameObject);
            coins++;
            coinText.text = (int.Parse(coinText.text) + 1).ToString();
        }
    }
}
