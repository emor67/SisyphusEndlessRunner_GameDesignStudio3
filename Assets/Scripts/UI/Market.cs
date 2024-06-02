using UnityEngine;
using TMPro;

public class Market : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI coinText;

    private void Start()
    {
        UpdateCoinText();
    }

    private void UpdateCoinText()
    {
        coinText.text = "Coins: " + CoinManager.Instance.GetCoins().ToString();
    }

    // Implement your market logic here, e.g., spending coins
}
