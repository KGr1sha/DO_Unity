using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class DashBar : MonoBehaviour {
    [SerializeField] private Transform cameraTransofrm;
    [SerializeField] private Image fillImage;

    private void Start() {
        fillImage = GetComponent<Image>();
        Dash.OnDashed += UpdateCooldown;
    }

    private void LateUpdate() {
        transform.LookAt(cameraTransofrm.position);
    }

    private void UpdateCooldown(float cooldown) {
        StartCoroutine(DrawCooldown(cooldown));
    }

    private IEnumerator DrawCooldown(float cooldown) {
        float timer = 0;
        while (timer < cooldown) {
            fillImage.fillAmount = timer / cooldown;
            timer += Time.deltaTime;
            yield return null;
        }
        fillImage.fillAmount = 1;
    }
}