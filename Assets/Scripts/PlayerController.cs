using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    [HeaderAttribute ("Player Movement Variables")]
    public float speed; //Speed of the player movement
    public float jumpForce; //Jump force of the player
    private int extraJumps; //Number of extraJumps 
    public int extraJumpsValue; //Initial Number of Extra Jumps of player

    [HeaderAttribute ("Player Physics/Ground check")]
    private Rigidbody2D rb; //Rigidbody of the player
    private bool isGrounded; //Check if player is grounded boolean
    public Transform groundCheck; //transform of gameObject placed beneath player to check groundness
    public float checkRadius; //Radius of groudness check
    public LayerMask whatIsGround; //What is masked as Ground(Layermask)

    private float moveInput; //Axes of movement inut ( 1 or -1)

    bool facingRight = true; //Boolean check to flip player based on direction facing

    

    void Start () {
        extraJumps = extraJumpsValue;
        rb = GetComponent<Rigidbody2D> ();

    }

    void FixedUpdate () {
        isGrounded = Physics2D.OverlapCircle (groundCheck.position, checkRadius, whatIsGround); // ground check

        moveInput = Input.GetAxis ("Horizontal"); // move input

        Move (); //movement method called everyframe but is activated through input axes(moveInput)

        //Code to flip player based on direction its facing
        if (facingRight == false && moveInput > 0) {
            Flip ();
        } else if (facingRight == true && moveInput < 0) {
            Flip ();
        }

    }

    void Update () {

        if (isGrounded == true) {
            extraJumps = 2;
        }

        if (Input.GetKeyDown (KeyCode.UpArrow) && extraJumps > 0) {
            VerticalJump ();
            extraJumps--;
        } else if (Input.GetKeyDown (KeyCode.UpArrow) && extraJumps == 0 && isGrounded == true) {
            VerticalJump ();
        }

    }

    void Move () {
        rb.velocity = new Vector2 ((moveInput) * speed, rb.velocity.y);

    }

    void VerticalJump () {
        rb.velocity = Vector2.up * jumpForce;
    }

    void Flip () {
        facingRight = !facingRight;
        transform.Rotate (0f, 180f, 0f);
    }

}