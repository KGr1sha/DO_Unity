using UnityEngine;
using System;
using UnityEngine.UI;

public class ExitButton : MonoBehaviour
{
    public static event Action OnExitButtonPressed;

    [SerializeField] private Button button;

    private void Start() {
        button.onClick.AddListener(HandleButtonPress);
    }

    private void HandleButtonPress() {
        OnExitButtonPressed?.Invoke();
        Application.Quit();
    }
}
