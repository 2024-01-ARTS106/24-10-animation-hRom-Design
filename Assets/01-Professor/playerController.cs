using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    private Animator animator;

    void Start()
    {
        animator = this.GetComponent<Animator>();
    }

    void Update()
    {
        var vertical = Input.GetAxis("Vertical");
        var horizontal = Input.GetAxis("Horizontal");

        if (vertical > 0)
        {
            animator.SetInteger("Direction", 2);
        }
        else if (vertical < 0)
        {
            animator.SetInteger("Direction", 0);
        }
        else if (horizontal > 0)
        {
            animator.SetInteger("Direction", 3);
        }
        else if (horizontal < 0)
        {
            animator.SetInteger("Direction", 1);
        }
    }
}
