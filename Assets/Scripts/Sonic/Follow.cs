using UnityEngine;

public class Follow : MonoBehaviour
{
    [SerializeField] private Transform target;
    [SerializeField] private float speed;
    private Vector3 toTarget;

    private void Update() {
        toTarget = (target.position - transform.position).normalized;
        transform.Translate(speed * Time.deltaTime * toTarget);
    }
}
