using UnityEngine;

public class Door : MonoBehaviour
{
    private bool isPlayerClose;
    private Animator animator;

    private void Start() {
        animator = GetComponent<Animator>();
    }

    public void PlaySound() {
        print("DOOR SOUND");
    }

    private void OnTriggerEnter(Collider other) {
        if (other.gameObject.CompareTag("Player")) {
            isPlayerClose = true;
        }
    }

    private void OnTriggerExit(Collider other) {
        if (other.gameObject.CompareTag("Player")) {
            isPlayerClose = false;
        }
    }

    private void Update() {
        if (Input.GetKeyDown(KeyCode.E) && isPlayerClose) {
            animator.SetTrigger("Open"); 
        }
    }
}
