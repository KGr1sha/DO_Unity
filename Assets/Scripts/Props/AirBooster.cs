using UnityEngine;

public class AirBooster : MonoBehaviour
{
    [SerializeField] private float boostForce;
    [SerializeField] private Vector3 boostDirection;
    [SerializeField] private ForceMode mode;
    private void OnTriggerStay(Collider other) {
        Rigidbody rb = other.GetComponent<Rigidbody>();
        rb?.AddForce(boostDirection.normalized * boostForce, mode);
    }
}
