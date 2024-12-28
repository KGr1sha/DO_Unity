using UnityEngine;
using System;

[RequireComponent(typeof(Rigidbody))]
public class Dash : MonoBehaviour {
    public static event Action<float> OnDashed;
    [SerializeField] private float dashStrength;
    [SerializeField] private float cooldown;
    [SerializeField] private Transform body;
    private Rigidbody rb;
    private float timer;

    private void Start() {
        rb = GetComponent<Rigidbody>();
    }

    private void Update() {
        timer -= Time.deltaTime;
        if (Input.GetKeyDown(KeyCode.LeftShift) && timer <= 0) {
            ApplyDash();
            timer = cooldown;
            OnDashed?.Invoke(cooldown);
        }
    }

    private void ApplyDash() {
        Vector3 fw = transform.forward;
        rb.AddForce(fw * dashStrength);
    }
}