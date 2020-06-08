using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.Animations;

public class PlayerMovement : MonoBehaviour
{
    public float speed;
    private float moveInput;
    public float jumpVelocity;

    private Rigidbody2D rb;

    public LayerMask theGround;
    public Transform groundCheck;
    bool onTheGround = false;

    private bool facingRight = true;

   // Animator anim;
   // bool isWalking = false;
    //bool onGround = false;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
       // anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        //'Ground Check' is created to allow character to jump only when on the ground.
        onTheGround = Physics2D.Linecast(transform.position, groundCheck.position, theGround);
        
        //if statement created so when jump is activated and the character is on the ground, the character will jump
        if (onTheGround && Input.GetKeyDown(KeyCode.UpArrow))
        {
            Jump();
        }

        //Creates horizontal (Left and Right) movement for the player character
        moveInput = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(moveInput * speed, rb.velocity.y);

        //if statement created calling to activate Flip function - Makes character face the direction they are moving
        if (facingRight == false && moveInput > 0)
        {
            Flip();
        }
        else if (facingRight == true && moveInput < 0)
        {
            Flip();
        }

      /*  if (speed > 0)
        {
            isWalking = true;
        }
        else
        {
            isWalking = false;
        }

        //anim.SetBool("isWalking", isWalking);
        //anim.SetBool("onGround", onGround); */
    }

    void Jump()
    {
        //if statement created - If the up arrow/jump key is pressed the character will jump
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            GetComponent<Rigidbody2D>().velocity = Vector2.up * jumpVelocity;
        }
    }
    
    //The player caracter will face the direction they are moving
    void Flip() 
    {
        facingRight = !facingRight;
        GetComponent<SpriteRenderer>().flipX = !facingRight;
    }


}
