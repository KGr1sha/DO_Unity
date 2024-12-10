using UnityEngine;
using System;
using UnityEngine.Events;

public class CatchChecker : MonoBehaviour
{
    public static event Action<string> OnSonicCatch;
    [SerializeField] private UnityEvent OnSonicCatch2;

    private void Start() {
        OnSonicCatch?.Invoke("You died");
    }
}
