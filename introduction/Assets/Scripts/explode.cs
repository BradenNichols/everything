using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class explode : MonoBehaviour
{
    [SerializeField]
    private SpriteRenderer explodeImage;
    [SerializeField]
    private AudioSource explodeSound;
    [SerializeField]
    private Camera camera;
    [SerializeField]
    private AudioSource music;

    private int activated = 0;
    public float zoomSpeed;

    private void Update()
    {
        if (activated == 1)
        {
            camera.fieldOfView += Time.deltaTime * zoomSpeed;

            if (camera.fieldOfView >= 179)
            {
                print("BOOM");
                activated = 2;
                Application.Quit();
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player") && activated == 0)
        {
            activated = 1;

            music.Stop();
            explodeImage.enabled = true;
            explodeSound.Play();
        }
    }
}
