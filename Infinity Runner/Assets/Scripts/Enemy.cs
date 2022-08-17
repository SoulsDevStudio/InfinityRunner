using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int health;

    public virtual void ApplyDamage(int damage)
    {
        health -= damage;

        if(health >= 0)
        {
            Destroy(gameObject);
        }
    }

    protected virtual void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Bullet"))
        {

            int dmg = collision.GetComponent<ProjectilePlayer>().damage;
            ApplyDamage(dmg);
        }
    }
}
