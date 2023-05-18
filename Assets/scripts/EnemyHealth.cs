using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyHealth : MonoBehaviour
{
    public float maxHealth = 100f; // Maximum health value
    private float currentHealth; // Current health value
    private EnemyHealthBar healthBar; // Reference to the EnemyHealthBar script

    private void Start()
    {
        currentHealth = maxHealth;
        healthBar = GetComponent<EnemyHealthBar>();
    }

    private void UpdateHealthBar()
    {
        float healthPercentage = currentHealth / maxHealth;
        healthBar.SetHealth(healthPercentage);
    }

    // Example method for taking damage
    public void TakeDamage(float damageAmount)
    {
        currentHealth -= damageAmount;
        UpdateHealthBar();
        // Perform other actions based on the updated health value
    }
}
