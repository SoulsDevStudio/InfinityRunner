using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : MonoBehaviour
{
    Player player;

    Rigidbody2D rig;

    public float x;
    public float y;

    public float damage;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();

        rig = GetComponent<Rigidbody2D>();
        rig.AddForce(new Vector2(x, y),ForceMode2D.Impulse);

        Destroy(gameObject, 3f);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            player.HealhDamage(damage);
        }
    }

}
