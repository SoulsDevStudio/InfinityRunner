using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyEnemy : Enemy
{

    Rigidbody2D rig;
    public float speed;

    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
        Destroy(gameObject, 3f);
    }

    void FixedUpdate()
    {
        rig.velocity = Vector2.left * speed;
    }
}
