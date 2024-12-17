using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class TourqueTest : MonoBehaviour
{
    [SerializeField] private float rotateSpeed;
    private Rigidbody rb;

    private void Start() {
        rb = GetComponent<Rigidbody>();
        rb.AddTorque(Vector3.up * rotateSpeed, ForceMode.Impulse); 
    }
}
