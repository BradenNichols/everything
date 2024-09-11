using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jumpscare : MonoBehaviour
{
    [SerializeField]
    private GameObject scareObject;
    private Animator scareAnimator;

    // Start is called before the first frame update
    void Start()
    {
        scareAnimator = scareObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void funny(bool shouldQuit = true)
    {
        // set animate bool
    }
}
