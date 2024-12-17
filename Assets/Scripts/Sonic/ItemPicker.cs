using UnityEngine;
using System;

public class ItemPicker : MonoBehaviour {
    public static event Action OnItemPicked;

    private void OnTriggerEnter(Collider other) {
        if (other.TryGetComponent<IPickable>(out var pickable)) {
            pickable.Pick(); 
            OnItemPicked?.Invoke();
        }
    }
}
