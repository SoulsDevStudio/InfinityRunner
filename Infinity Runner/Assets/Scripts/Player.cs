using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float health;

    Rigidbody2D rig;
    bool isJumping;

    public Animator anim;

    public float speed;
    public float jumpForce;

    public GameObject bulletPrefab;
    public Transform firePoint;

    void Start()
    {

        rig = GetComponent<Rigidbody2D>();
    }

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isJumping)
        {
            Shooter();
        }

        if (Input.GetKeyDown(KeyCode.Z))
        {
            Jump();
        }
    }

    public void Shooter()
    {
        Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
    }

    public void Jump()
    {
        rig.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
        anim.SetBool("isJumping", true);
    }

    void FixedUpdate()
    {
        rig.velocity = new Vector2(speed, rig.velocity.y);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.layer == 3)
        {
            isJumping = true;
            anim.SetBool("isJumping", false);
        }
    }

    public void HealhDamage(float dmg)
    {
        health -= dmg;

        if(health <= 0)
        {
            GameController.instance.ShowGameOver();
        }
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        if(collision.gameObject.layer == 3)
        {
            isJumping = false;
        }
    }


}
