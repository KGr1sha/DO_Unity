using TMPro;
using UnityEngine;

public class CoinScore : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI countText;

    private void Awake() {
        Bank.OnCoinsChanged += UpdateScore;
    }

    private void UpdateScore(uint newScore) {
        countText.text = newScore.ToString();
    }
}
