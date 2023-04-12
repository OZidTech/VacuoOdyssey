using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthStat : MonoBehaviour
{
    public float health = 100;
    public float damage = 10;

    public void takeDamage()
    {
        health -= damage;
        Debug.Log(health);
    }
}
