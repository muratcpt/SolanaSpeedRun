using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Portal3 : MonoBehaviour
{
    private Animator anim;

    private void Start()
    {
        anim = GetComponent<Animator>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.name == "MainChar")
        {
            Invoke("Portal", 2f);
            anim.SetBool("isTrigger", true);


        }

    }

    private void Portal()
    {
        SceneManager.LoadScene(4);
    }

}
