using UnityEngine;

public class GroundCheck : MonoBehaviour {
    public bool IsOnGround {get {return isOnGround;}}
    private bool isOnGround;

    private void OnCollisionEnter(Collision collision) {
        CheckCollision(collision);
    }

    private void OnCollisionStay(Collision collision) {
        CheckCollision(collision);
    }

    private void OnCollisionExit(Collision collision) {
        isOnGround = false;
    }

    private void CheckCollision(Collision collision) {
        foreach(ContactPoint contact in collision.contacts) {
            isOnGround |= contact.normal.y >= 0.6f;
        }
    }
}