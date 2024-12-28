using System;
using UnityEngine;

public class Bank : MonoBehaviour
{
    public static event Action<uint> OnCoinsChanged;
    private uint coins;

    private void Awake() {
        Coin.OnCoinPicked += UpdateCoins;
    }

    private void UpdateCoins() {
        coins++;
        OnCoinsChanged?.Invoke(coins);
    }
}
