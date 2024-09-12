using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bounce : MonoBehaviour
{
    public Vector2 impulse;
    public float speed;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Rigidbody2D body = collision.gameObject.GetComponent<Rigidbody2D>();
            body.AddForce(impulse * speed, ForceMode2D.Impulse);
        }
    }
}
