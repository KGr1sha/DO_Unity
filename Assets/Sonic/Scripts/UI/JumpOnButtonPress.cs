using UnityEngine;

public class JumpOnButtonPress : MonoBehaviour {
    private Rigidbody rb;
    private void Start() {
        rb = GetComponent<Rigidbody>();
        ExitButton.OnExitButtonPressed += Jump;
    }

    private void Jump() {
        rb.AddForce(Vector3.up * 10, ForceMode.Impulse);
    }
}