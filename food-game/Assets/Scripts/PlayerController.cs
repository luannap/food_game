using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class PlayerController : MonoBehaviour
{
    public float movement;
    public Rigidbody2D rigid;
  

    public bool isFacingRight = true;
    bool jumpPressed = false;
    public float jumpForce = 3.5f;
    public LayerMask groundLayer; //what should be considered ground for jumping off
    public float groundDistance = 0.14f;
    public bool grounded;

    public AudioSource JumpAudio;
    public AudioSource Running;
  

    public Animator animator;


    // Start is called before the first frame update
    void Start()
    {
        Running.volume = 0.4f;
        if (rigid == null)
            rigid = GetComponent<Rigidbody2D>();

        groundLayer = LayerMask.GetMask("Ground");

    }

    // Update is called once per frame
    void Update()
    {
        movement = Input.GetAxis("Horizontal");

        MovementSpeed();
        if ((movement >= 0.3f|| movement <= -0.3f) && !Running.isPlaying && grounded)
        {
            Running.Play();
        }

        if (movement < 0 && isFacingRight || movement > 0 && !isFacingRight)
        {
            Flip();
        }

        if (Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.UpArrow))
        {
            jumpPressed = true;
        }

        grounded = isOnGround();

        if (jumpPressed && grounded)
            Jump();


    }

    void MovementSpeed()
    {
        //player moving speed 
        rigid.velocity = new Vector2(movement * 1.5f, rigid.velocity.y);
        Vector2 vel = rigid.velocity;
        if (vel.magnitude == 0)
        {
            animator.SetBool("isRunning", false);
        }
        else
        {
       
            animator.SetBool("isRunning", true);
      
        }


    }

    void Flip()
    {
        Vector3 playerScale = transform.localScale;
        playerScale.x = playerScale.x * -1;
        transform.localScale = playerScale;
        isFacingRight = !isFacingRight;

        // transform.Rotate(new Vector3(0, 180, 0));
    }

    void Jump()
    {
        JumpAudio.Play();
        rigid.velocity = new Vector2(rigid.velocity.x, jumpForce);
        //rigid.AddForce(new Vector2(0, jumpForce));
        jumpPressed = false;
    }
    bool isOnGround()
    //see, e.g.: https://kylewbanks.com/blog/unity-2d-checking-if-a-character-or-object-is-on-the-ground-using-raycasts
    {
        // return rigid.velocity.y == 0;
        Vector2 position = transform.position;
        Vector2 direction = Vector2.down;

        Debug.DrawRay(position, direction, Color.green);

        RaycastHit2D hit = Physics2D.Raycast(position, direction, groundDistance, groundLayer);
        if (hit.collider != null)
        {
            grounded = true;
            animator.SetBool("isJumping", false);
        }
        else
        {
            grounded = false;
            animator.SetBool("isJumping", true);
        }
        return grounded;
    }

   
}