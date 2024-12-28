using System;
using UnityEngine;
using UnityEngine.UI;

public class MaterialColorChanger : MonoBehaviour {
    [SerializeField] private Material mat;
    [SerializeField] private Slider slider;
    private Color color;

    private void Start() {
        color = mat.color;
    }

    public void UpdateMaterialColor() {
        mat.color = color * slider.normalizedValue;
    }
}