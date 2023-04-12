using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordHit : MonoBehaviour
{
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Enemy")
        {
            collision.GetComponent<HealthStat>().takeDamage();
            if(collision.GetComponent<HealthStat>().health < 0)
            {
                Destroy(collision.gameObject);
            }
        }
    }
}
