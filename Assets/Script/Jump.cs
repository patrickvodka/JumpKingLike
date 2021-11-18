using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    private Rigidbody2D rb;
    public float speed;
    public float jumpForce;
    private float moveInput;
    private bool isGrounded;
    public Transform FeetPos;
    public float checkRadius;
    public LayerMask whatIsGround;
    private float jumpTimerCounter;
    public float jumpTime;
    private bool isJumping;
    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
     void FixedUpdate()
    {
        moveInput = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2(moveInput * speed, rb.velocity.y);
        
    }
    void Update()

    {
        isGrounded = Physics2D.OverlapCircle(FeetPos.position, checkRadius, whatIsGround);
        if (moveInput > 0)
        {
            transform.eulerAngles = new Vector3(0, 0, 0);
        }
        else if(moveInput < 0)
         {
            transform.eulerAngles = new Vector3(0, 180, 0);
        }
        if (isGrounded == true && Input.GetKeyDown(KeyCode.Space))
        {
            isJumping = true;
            jumpTimerCounter = jumpTime;
            rb.velocity = Vector2.up * jumpForce;
        }
        if(Input.GetKey(KeyCode.Space) && isJumping == true)
        {
            if (jumpTimerCounter > 0)
            {
                rb.velocity = Vector2.up * jumpForce;
                jumpTimerCounter -= Time.deltaTime;
            }
            else 
            {
                isJumping = false;
            }
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            isJumping = false;
        }
            
    } 
}
