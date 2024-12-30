using UnityEngine;

public class MoveToTarget : MonoBehaviour {
    [SerializeField] private Transform target;
    [SerializeField] private float speed;

    public void Move() {
        Vector3 toTarget = (target.position - transform.position).normalized;
        transform.Translate(toTarget * speed * Time.deltaTime, Space.World);
        transform.LookAt(transform.position + toTarget);
    }

    public float DistanceToTarget() {
        return (target.position - transform.position).magnitude;
    }
}
