using UnityEngine;

public class RedSonic : MonoBehaviour {
    private MoveWaypoints waypointMove;
    private MoveToTarget targetMove;
    private float precision = 1f;
    private delegate void Func();
    private Func moveMethod;

    private void Awake() {
        Egg.OnEggPicked += Chase;
    }

    private void Start() {
        waypointMove = GetComponent<MoveWaypoints>();
        targetMove = GetComponent<MoveToTarget>();
        moveMethod = waypointMove.Move;
    }

    private void Update() {
        moveMethod();

        float distance = targetMove.DistanceToTarget();
        if (moveMethod == targetMove.Move && distance <= precision) {
            moveMethod = waypointMove.Move; 
        }
    }

    private void Chase() {
        moveMethod = targetMove.Move;
    }
}
