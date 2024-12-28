using UnityEngine;

[RequireComponent(typeof(Animator))]
public class SonicAnim : MonoBehaviour {
    private Animator animator;

    private void Awake() {
        SonicMovementPhysics.OnJump += PlayJump;
    }

    private void Start() {
        animator = GetComponent<Animator>();
    }

    private void PlayJump() {
        animator.SetTrigger("Jump");
    }
}