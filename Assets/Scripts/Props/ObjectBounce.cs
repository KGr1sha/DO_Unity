using UnityEngine;

public class ObjectBounce : MonoBehaviour
{
    [SerializeField] private float bounceSpeed = 8;
    [SerializeField] private float bounceAmplitude = 0.05f;
    [SerializeField] private float rotationSpeed = 90;

    private float startHeight;
    private float timeOffset;

    private void Start()
    {
        startHeight = transform.localPosition.y;
        timeOffset = Random.value * Mathf.PI * 2;
    }

    private void Update()
    {
        //animate
        float finalheight = startHeight + Mathf.Sin(Time.time * bounceSpeed + timeOffset) * bounceAmplitude;
        var position = transform.localPosition;
        position.y = finalheight;
        transform.localPosition = position;

        //spin
        Vector3 rotation = transform.localRotation.eulerAngles;
        rotation.y += rotationSpeed * Time.deltaTime;
        transform.localRotation = Quaternion.Euler(rotation.x, rotation.y, rotation.z);
    }
}
