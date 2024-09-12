using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed;
    public float jumpPower;

    private Rigidbody2D body;

    void Start()
    {
        body = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float axis = Input.GetAxisRaw("Horizontal");
        body.AddForce(new Vector2((axis * Time.deltaTime) * (speed * 500), 0), ForceMode2D.Force);

        if (Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.W))
            body.AddForce(new Vector2(0, jumpPower * 10), ForceMode2D.Impulse);
    }
}
