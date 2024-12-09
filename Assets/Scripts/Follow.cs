using UnityEngine;

public class Follow : MonoBehaviour
{
    [SerializeField] private Transform target;
    [SerializeField] private float speed;

    private void Update() {
        Vector3 toTarget = (target.position - transform.position).normalized;
        transform.Translate(toTarget * speed * Time.deltaTime);
    }
}
