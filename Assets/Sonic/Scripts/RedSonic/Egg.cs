using System;
using UnityEngine;

public class Egg : MonoBehaviour, IPickable
{
    public static event Action OnEggPicked;

    public void Pick()
    {
        OnEggPicked?.Invoke();
        Destroy(gameObject);
    }
}
