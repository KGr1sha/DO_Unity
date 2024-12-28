using UnityEngine;
using UnityEngine.UI;

public class SonicInterpolate : MonoBehaviour {
    [SerializeField] private Transform sonicTransform;
    [SerializeField] AnimationCurve curve;
    [SerializeField] private Slider slider;
    [SerializeField] private Transform pointA;
    [SerializeField] private Transform pointB;
    private Vector3 fromA2B;

    private void Start() {
        fromA2B = pointB.position - pointA.position;
    }

    public void UpdatePosition() {
        sonicTransform.position = pointA.position +
        fromA2B * curve.Evaluate(slider.normalizedValue);
    }
}