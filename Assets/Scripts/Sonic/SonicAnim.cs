using UnityEngine;

[RequireComponent(typeof(Animator))]
public class SonicAnim : MonoBehaviour {
    private Animator animator;
    private Rigidbody rb;

    private void Awake() {
        SonicMovementPhysics.OnJump += PlayJump;
    }

    private void Start() {
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody>();
    }

    private void Update() {
        float speed = rb.velocity.magnitude;
        Debug.Log(speed);
        animator.SetFloat("Speed", speed);
    }

    private void PlayJump() {
        animator.SetTrigger("Jump");
    }
}