using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class HealthSystem : MonoBehaviour
{

    private int health;
    private int healthMax;
    public EventHandler OnHealthChanged;

    public HealthSystem(int healthMax)
    {
        this.healthMax = healthMax;
        health = healthMax;
    }

    public int GetHealth()
    {
        return health;
    }
    public float GetHealthPercent()
    {
        return (float)health / healthMax;
    }

    public void Damage(int damageAmount)
    {
        health = health - damageAmount;
        if(health < 0)
        {
            health = 0;
        }
        if (OnHealthChanged != null)
        {
            OnHealthChanged(this, EventArgs.Empty);
        }
    }
    public void Heal(int healAmount)
    {
        health = health + healAmount;
        if(health > healthMax)
        {
            health = healthMax;
        }
        if (OnHealthChanged != null)
        {
            OnHealthChanged(this, EventArgs.Empty);
        }
    }
}
