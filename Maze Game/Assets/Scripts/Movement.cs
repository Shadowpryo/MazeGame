using UnityEngine;
using System.Collections;

[DisallowMultipleComponent]
[RequireComponent(typeof(Animator))]
[RequireComponent(typeof(Rigidbody))]
[RequireComponent(typeof(CapsuleCollider))]
public class Movement : MonoBehaviour {
    Animator anim;



    void Awake()
    {
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        //turning
        Turn();
        //move
        Move();

    }

    void Move()
    {
        if (Input.GetKey("left shift"))
        {
            anim.SetBool("Running", true);
        }
        else
        {
            anim.SetBool("Running", false);
            anim.SetFloat("Forward", Input.GetAxisRaw("Vertical"));
        }
    }

    void Turn()
    {
        anim.SetFloat("Turn", Input.GetAxisRaw("Horizontal"));
    }
}
