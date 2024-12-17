using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class SonicSound : MonoBehaviour
{
    [SerializeField] private AudioSource engineAudioSource;
    [SerializeField] private AudioSource jumpAudioSource;

    private void Awake() {
        SonicMovementPhysics.OnJump += PlayJumpSound;
    }

    private void Update() {
        bool moveKeyPressed = Input.GetKeyDown(KeyCode.W)
        || Input.GetKeyDown(KeyCode.S);
        bool moveKeyReleased = Input.GetKeyUp(KeyCode.W)
        || Input.GetKeyUp(KeyCode.S);

        if (moveKeyReleased) {
            engineAudioSource.Stop();
        }
        if (moveKeyPressed) {
            engineAudioSource.Play();
        }
    }

    private void PlayJumpSound() {
        jumpAudioSource.Play();
    }
}
