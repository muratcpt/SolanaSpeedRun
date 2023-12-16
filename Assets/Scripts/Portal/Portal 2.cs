using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Portal2 : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.name == "MainChar")
        {
            Invoke("Portal", 2f);

        }

    }

    private void Portal()
    {
        SceneManager.LoadScene(3);
    }

}
