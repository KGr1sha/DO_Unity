using TMPro;
using UnityEngine;

[RequireComponent(typeof(TextMeshProUGUI))]
public class Counter : MonoBehaviour
{
    private TextMeshProUGUI text;
    private int count = 0;

    private void Start() {
        text = GetComponent<TextMeshProUGUI>();
        text.text = count.ToString();
    }

    public void Increase() {
        count++;
        text.text = count.ToString();
    }
}
