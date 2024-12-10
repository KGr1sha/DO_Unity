using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class SonicMovementPhysics : MonoBehaviour
{
    [SerializeField] private float moveSpeed;
    [SerializeField] private float spinSpeed;
    [SerializeField] private float rotateSpeed;
    [SerializeField] private float jumpForce = 100;
    [SerializeField] private Transform body;
    private Rigidbody rb;
    private float forwardInput;
    private float horizontalInput;
    private bool jumpInput;

    private void Start()
    {
        rb = GetComponent<Rigidbody>(); 
    }

    private void Update()
    {
        forwardInput = Input.GetAxis("Vertical");
        horizontalInput = Input.GetAxis("Horizontal"); 
        if(Input.GetKeyDown(KeyCode.Space)) {
            jumpInput = true;
        }

        body.transform.Rotate(
            Vector3.right * spinSpeed * Time.deltaTime * forwardInput
        );
    }

    private void FixedUpdate() {
        rb.AddForce(
            transform.forward * moveSpeed *  forwardInput
        );

        rb.AddTorque(
            Vector3.up * horizontalInput * rotateSpeed * Time.fixedDeltaTime
        );

        if (jumpInput) {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            jumpInput = false;
        }
    }
}
