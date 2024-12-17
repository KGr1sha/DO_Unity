using UnityEngine;

public class SonicMovement : MonoBehaviour
{
    [SerializeField] private float spinSpeed;
    [SerializeField] private float rotateSpeed;
    [SerializeField] private float moveSpeed;
    [SerializeField] private GameObject body;

    private void Update()
    {
        float forwardInput = Input.GetAxis("Vertical");
        float horizontalInput = Input.GetAxis("Horizontal"); 

        transform.Translate(
            Vector3.forward * moveSpeed * Time.deltaTime * forwardInput,
            Space.Self
        );
        body.transform.Rotate(
            Vector3.right * spinSpeed * Time.deltaTime * forwardInput
        );
        transform.Rotate(
            Vector3.up * rotateSpeed * Time.deltaTime * horizontalInput
        );
    }
}
