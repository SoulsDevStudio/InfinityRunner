using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : MonoBehaviour
{
    Rigidbody2D rig;

    public float x;
    public float y;

    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
        rig.AddForce(new Vector2(x, y),ForceMode2D.Impulse);

        Destroy(gameObject, 3f);
    }

}
