using UnityEngine;
using System;

[RequireComponent(typeof(Rigidbody))]
public class SonicMovementPhysics : MonoBehaviour
{
    public static event Action OnJump;
    [SerializeField] private float moveSpeed;
    [SerializeField] private float spinSpeed;
    [SerializeField] private float rotateSpeed;
    [SerializeField] private float jumpForce = 100;
    [SerializeField] private Transform body;
    [SerializeField] private Transform cameraTransform;
    private Rigidbody rb;
    private float forwardInput;
    private float horizontalInput;
    private bool jumpInput;
    private GroundCheck groundCheck;

    private void Start()
    {
        rb = GetComponent<Rigidbody>(); 
        groundCheck = GetComponent<GroundCheck>();
    }

    private void Update()
    {
        forwardInput = Input.GetAxis("Vertical");
        horizontalInput = Input.GetAxis("Horizontal"); 
        if(Input.GetKeyDown(KeyCode.Space)) {
            jumpInput = true;
        }

        float speed = rb.velocity.magnitude;

        body.transform.Rotate(
            Vector3.right * speed * spinSpeed * Time.deltaTime
        );

        Vector3 fromCamera = GetHorizontalProjection(
            transform.position - cameraTransform.position
        );

        transform.LookAt(transform.position + fromCamera);
    }

    private void FixedUpdate() {
        rb.AddForce(
            transform.forward * moveSpeed *  forwardInput
        );

        if (jumpInput) {
            if (groundCheck.IsOnGround) {
                rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
                OnJump?.Invoke();
            }

            jumpInput = false;
        }
    }

    private Vector3 GetHorizontalProjection(Vector3 vector) {
        return new Vector3(vector.x, 0, vector.z).normalized;
    }

    private void OnDrawGizmos() {
        Vector3 cam = GetHorizontalProjection(
            transform.position - cameraTransform.position
        );
        Gizmos.color = Color.green;
        Gizmos.DrawLine(transform.position, transform.position + cam);
    }
}
