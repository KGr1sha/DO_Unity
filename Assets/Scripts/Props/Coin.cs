using System;
using UnityEngine;

public class Coin : MonoBehaviour, IPickable
{
    public static event Action OnCoinPicked;
    private AudioSource audioSource;
    private MeshRenderer meshRenderer;
    private Collider coinCollider;

    private void Start() {
        audioSource = GetComponent<AudioSource>();
        meshRenderer = GetComponent<MeshRenderer>();
        coinCollider = GetComponent<Collider>();
    }

    public void Pick() {
        OnCoinPicked?.Invoke();
        DisableVisuals();
        audioSource?.Play();
        Invoke(nameof(Kill), audioSource.clip.length);
    }

    private void DisableVisuals() {
        meshRenderer.enabled = false;
        coinCollider.enabled = false;
    }
    
    private void Kill() {
        Destroy(gameObject);
    }
}
