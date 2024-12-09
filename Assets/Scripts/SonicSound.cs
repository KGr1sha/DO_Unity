using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class SonicSound : MonoBehaviour
{
    private AudioSource audioSource;

    private void Start() {
        audioSource = GetComponent<AudioSource>();
    }

    private void Update() {
        bool moveKeyPressed = Input.GetKeyDown(KeyCode.W)
        || Input.GetKeyDown(KeyCode.S);
        bool moveKeyReleased = Input.GetKeyUp(KeyCode.W)
        || Input.GetKeyUp(KeyCode.S);

        if (moveKeyReleased) {
            audioSource.Stop();
        }
        if (moveKeyPressed) {
            audioSource.Play();
        }
    }
}
