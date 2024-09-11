using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    public Transform target;
    public float lerpSpeed;
    public Vector3 camOffset;

    void Update()
    {
        transform.position = Vector3.Lerp(transform.position, target.position + camOffset, Time.deltaTime * lerpSpeed);
    }
}
