using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehaviour_healthbar : MonoBehaviour
{
    public float Hitpoints;
    public float MaxHitpoints = 5 ;
    public EnemyHealth healthBar;

    void Start()
    {
        Hitpoints = MaxHitpoints;
        healthBar.SetHealth(Hitpoints, MaxHitpoints);
    }

    // Update is called once per frame
    public void TakeHit(float damage)
    {
        Hitpoints -= damage;
        healthBar.SetHealth(Hitpoints,MaxHitpoints);
        if(Hitpoints <= 0)
        {
            Destroy(gameObject);
        }
    }
}
