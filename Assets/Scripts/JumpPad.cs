using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpPad : MonoBehaviour
{
    private Animator anim;
    private bool isPressing;    

    private void Start()
    {
        anim = GetComponent<Animator>();
    }

    private float bounce = 10f;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            anim.SetBool("press", true);
            isPressing = true;
            collision.gameObject.GetComponent<Rigidbody2D>().AddForce(Vector2.up * bounce, ForceMode2D.Impulse);
        }
    }
    private void Update()
    {
        if (isPressing && !anim.GetCurrentAnimatorStateInfo(0).IsName("press")) 
        {
            anim.SetBool("press", false);
            isPressing = false;
        }
    }

}