using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationStateController : MonoBehaviour
{

    Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        bool isWalking = animator.GetBool("isWalking");
        bool forwardPressed = Input.GetKey("w");
        bool isWalkingBack = animator.GetBool("isWalkingBack");
        bool backwardsPressed = Input.GetKey("s");
        bool isWalkingLeft = animator.GetBool("isWalkingLeft");
        bool leftPressed = Input.GetKey("a");
        bool isWalkingRight = animator.GetBool("isWalkingRight");
        bool rightPressed = Input.GetKey("d");
        bool isRunning = animator.GetBool("isRunning");
        bool shiftPressed = Input.GetKey("left shift");
//Walk
        if (!isWalking && forwardPressed)
        {
            animator.SetBool("isWalking", true);
        }

        if (isWalking && !forwardPressed)
        {
            animator.SetBool("isWalking", false);
        }
//Walk Back
        if (!isWalkingBack && backwardsPressed)
        {
            animator.SetBool("isWalkingBack", true);
        }

        if (isWalkingBack && !backwardsPressed)
        {
            animator.SetBool("isWalkingBack", false);
        }
//Walk Left
        if (!isWalkingLeft && leftPressed)
        {
            animator.SetBool("isWalkingLeft", true);
        }

        if (isWalkingLeft && !leftPressed)
        {
            animator.SetBool("isWalkingLeft", false);
        }
//Walk Right
        if (!isWalkingRight && rightPressed)
        {
            animator.SetBool("isWalkingRight", true);
        }

        if (isWalkingRight && !rightPressed)
        {
            animator.SetBool("isWalkingRight", false);
        }
//Run
        if (!isRunning && shiftPressed && forwardPressed)
        {
            animator.SetBool("isRunning", true);
        }

        if (isWalkingRight && !shiftPressed || !forwardPressed)
        {
            animator.SetBool("isRunning", false);
        }
    }
}