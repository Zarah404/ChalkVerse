using UnityEngine;
using UnityEngine.UI;

public class EnemyHealthBar : MonoBehaviour
{
    public Slider healthSlider;
    private Camera mainCamera;
    public Transform target;

    private void Start()
    {
        if (healthSlider != null)
        {
            healthSlider.value = 100f; // Set the initial health value (0 to 1)
            mainCamera = Camera.main;
        }
    }
    public void SetHealth(float healthPercentage)
    {
        healthSlider.value = healthPercentage;
    }
    private void LateUpdate()
    {
        if (target != null)
        {
            Vector3 screenPosition = mainCamera.WorldToScreenPoint(target.position);
            healthSlider.transform.position = screenPosition;
        }

        
    }
}

