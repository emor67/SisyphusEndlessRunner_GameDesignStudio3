using UnityEngine;
using TMPro;

public class Coin_UI : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI coinText;

    private void Start()
    {
        //CoinManager.Instance.CoinZero();
        UpdateCoinText();
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("Coin"))
        {
            Destroy(collision.gameObject);
            CoinManager.Instance.AddCoins(1);
            UpdateCoinText();
        }
        if (collision.gameObject.CompareTag("CoinGold"))
        {
            Destroy(collision.gameObject);
            CoinManager.Instance.AddCoins(3);
            UpdateCoinText();
        }
    } 

    private void UpdateCoinText()
    {
        coinText.text = CoinManager.Instance.GetCoins().ToString();
    }}
