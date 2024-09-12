using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScareTrigger : MonoBehaviour
{
    [SerializeField]
    private Jumpscare jumpscareScript;
    private bool activated = false;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player") || !activated)
        {
            activated = true;
            StartCoroutine(jumpscareScript.funny(false));
        }
    }
}
