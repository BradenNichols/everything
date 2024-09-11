using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Awesomestuff : MonoBehaviour
{
    public float rainbowSpeed;
    public float scaleSpeed;
    public float scaleMultiplier;

    private SpriteRenderer sprite;

    void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        sprite.color = Color.HSVToRGB(Mathf.PingPong(Time.time * rainbowSpeed, 1), 1, 1);
        sprite.size = new Vector2(0.9f, 1f + (Mathf.PingPong(Time.time * scaleSpeed, 1)) * scaleMultiplier);
    }
}
