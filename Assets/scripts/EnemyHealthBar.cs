using UnityEngine;
using UnityEngine.UI;

public class EnemyHealthBar : MonoBehaviour
{
    public Slider healthSlider;
    private Camera mainCamera;
    public Transform target;
    
    private void Start()
    {
        if (healthSlider == null)
        {
            healthSlider = GetComponentInChildren<Slider>();
        }

        mainCamera = Camera.main;

        healthSlider.value = 100f;
    }
    public void SetHealth(float healthPercentage)
    {
        healthSlider.value = healthPercentage;
    }
    private void LateUpdate()
    {
        if (target != null && mainCamera != null)
        {
            Vector3 screenPosition = mainCamera.WorldToScreenPoint(target.position);
            healthSlider.transform.position = screenPosition ;
        }


    }
}

