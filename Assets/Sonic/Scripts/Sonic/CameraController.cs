using UnityEngine;

public class CameraController : MonoBehaviour {
    [SerializeField] private Transform lookAt;
    [SerializeField] private Transform Player;
    [SerializeField] private float distance = 10.0f;
    [SerializeField] private float sensivity = 4.0f;

    private const float YMin = 0.0f;
    private const float YMax = 50.0f;

    private float currentX = 0.0f;
    private float currentY = 0.0f;

    private void Start() {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    private void LateUpdate()
    {
        currentX += Input.GetAxis("Mouse X") * sensivity * Time.deltaTime;
        currentY -= Input.GetAxis("Mouse Y") * sensivity * Time.deltaTime;

        currentY = Mathf.Clamp(currentY, YMin, YMax);

        Vector3 Direction = new Vector3(0, 0, -distance);
        Quaternion rotation = Quaternion.Euler(currentY, currentX, 0);
        transform.position = lookAt.position + rotation * Direction;

        transform.LookAt(lookAt.position);
    }
}
