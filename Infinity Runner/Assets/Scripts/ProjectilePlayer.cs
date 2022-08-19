using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectilePlayer : MonoBehaviour
{
    Rigidbody2D rig;

    public float speed;
    public int damage;

    public GameObject explosionPrefab;

    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
        Destroy(gameObject, 5f);
    }

    void FixedUpdate()
    {
        rig.velocity = Vector2.right * speed;
    }

    public void OnHit()
    {
        GameObject smokeExposion = Instantiate(explosionPrefab, transform.position, transform.rotation);
        Destroy(smokeExposion, 0.5f);
        Destroy(gameObject);
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 3)
        {
            OnHit();
        }
            
    }
}
