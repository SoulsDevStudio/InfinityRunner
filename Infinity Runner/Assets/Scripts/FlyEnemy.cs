using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyEnemy : Enemy
{
    Player player;

    Rigidbody2D rig;
    public float speed;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();

        rig = GetComponent<Rigidbody2D>();
        Destroy(gameObject, 3f);
    }

    void FixedUpdate()
    {
        rig.velocity = Vector2.left * speed;
    }

    protected override void OnTriggerEnter2D(Collider2D collision)
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
