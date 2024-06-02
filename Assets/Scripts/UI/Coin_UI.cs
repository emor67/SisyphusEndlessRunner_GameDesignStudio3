using UnityEngine;
using TMPro;

public class Coin_UI : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI coinText;

    private void Start()
    {
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
    }

    private void UpdateCoinText()
    {
        coinText.text = CoinManager.Instance.GetCoins().ToString();
    }
}
