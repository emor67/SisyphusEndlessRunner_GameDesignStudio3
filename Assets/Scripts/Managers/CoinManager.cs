using UnityEngine;

public class CoinManager : MonoBehaviour
{
    public static CoinManager Instance { get; private set; }

    private int coins;

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);

        LoadCoins();
    }

    public int GetCoins()
    {
        return coins;
    }

    public void AddCoins(int amount)
    {
        coins += amount;
        SaveCoins();
    }

    public void CoinZero()
    {
        coins = 0;
    }

    private void SaveCoins()
    {
        PlayerPrefs.SetInt("Coins", coins);
    }

    private void LoadCoins()
    {
        coins = PlayerPrefs.GetInt("Coins", 0);
    }
}
