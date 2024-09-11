using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed;

    private Rigidbody2D body;

    void Start()
    {
        body = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float axis = Input.GetAxisRaw("Horizontal");
        body.AddForce(new Vector2(axis * speed, 0), ForceMode2D.Force);
        //body.velocity = new Vector2(axis * speed, body.velocity.y);
    }
}
