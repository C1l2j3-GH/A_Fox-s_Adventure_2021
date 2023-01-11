using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController2D controller;

    public Animator animator;

    public float MoveSpeed = 30f;

    public int CollectedObj_Num = 0;

    float HorizontalMove = 0f;

    bool Jump = false;

    bool Crouch = false;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(Input.GetAxisRaw("Horizontal"));

        HorizontalMove = Input.GetAxisRaw("Horizontal") * MoveSpeed;

        animator.SetFloat("Speed", Mathf.Abs(HorizontalMove));

        if (Input.GetButtonDown("Jump"))
        {
            Jump = true;
            animator.SetBool("Jumping", true);
        }

        if (Input.GetButtonDown("Crouch"))
        {
            Crouch = true;
        }
        else if (Input.GetButtonUp("Crouch"))
        {
            Crouch = false;
        }
    }

    public void OnLanding()
    {
        animator.SetBool("Jumping", false);
    }
       
    public void OnCrouching (bool Crouching)
    {
        animator.SetBool("Crouching", Crouching);
    }

    void FixedUpdate()
        {
            controller.Move(HorizontalMove * Time.fixedDeltaTime, Crouch, Jump);
            Jump = false;
        }
    }

  