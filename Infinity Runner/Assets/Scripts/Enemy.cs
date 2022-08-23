using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    Player player;

    public int health;
    public float damage;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
    }

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
            collision.GetComponent<ProjectilePlayer>().OnHit();
            ApplyDamage(dmg);
        }

        if (collision.CompareTag("Player"))
        {
            player.HealhDamage(damage);
        }
    }
}
