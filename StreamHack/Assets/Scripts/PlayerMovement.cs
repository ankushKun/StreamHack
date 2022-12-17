using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    private BoxCollider2D coll;
    private Animator animator;
    private SpriteRenderer sprite;
    
    private float playerDirectionX = 0f;

    private enum MovementState { idle, running, jumping, doubleJumping, falling};

    [SerializeField] private LayerMask jumpableGround;

    // Start is called before the first frame update
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        coll = GetComponent<BoxCollider2D>();
        animator = GetComponent<Animator>();
        sprite = GetComponent<SpriteRenderer>();

    }

    // Update is called once per frame
    private void Update()
    {
        playerDirectionX = Input.GetAxisRaw("Horizontal");

        rb.velocity = new Vector2(playerDirectionX * 7f,rb.velocity.y);


        // Debug.Log(IsGrounded());
        // if(IsGrounded() && !Input.GetButtonDown("Jump")){
        //     doubleJump = false;
        // }

        // if(Input.GetButtonDown("Jump")){
        //     if(IsGrounded() || doubleJump){
        //         rb.velocity = new Vector2(rb.velocity.x,16f);
        //         doubleJump = !doubleJump;
        //     }
        // }

        if (Input.GetButtonDown("Jump") && IsGrounded()){
            rb.velocity = new Vector2(rb.velocity.x,14f);
        }

        UpdateAnimation();
    }

    private void UpdateAnimation(){

        MovementState state;

        if(playerDirectionX > 0f){
            state = MovementState.running;
            sprite.flipX = false;
        }
        else if(playerDirectionX < 0f){
            state = MovementState.running;
            sprite.flipX = true;
        }
        else{
            state = MovementState.idle;
        }

        if (rb.velocity.y > .1f){
            state = MovementState.jumping;
        }
        else if(rb.velocity.y < -.1f){
            state = MovementState.falling;
        }

        animator.SetInteger("movementState",(int)state);

    }

    private bool IsGrounded(){
        return Physics2D.BoxCast(coll.bounds.center ,coll.bounds.size,0f,Vector2.down,.1f,jumpableGround);
    }
}
