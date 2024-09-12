using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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

    public IEnumerator funny(bool shouldQuit = true)
    {
        // set animate bool
        scareObject.GetComponent<SpriteRenderer>().enabled = true;
        scareAnimator.SetBool("animate", true);
        scareObject.GetComponent<AudioSource>().Play();

        yield return new WaitForSeconds(1.6f);

        if (shouldQuit)
            Application.Quit();
        else
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
