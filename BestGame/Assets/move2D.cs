using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move2D : MonoBehaviour
{
    
    public Rigidbody2D rb2d;
    public float jumpForce = 5f;
    public float moveSpeed = 10f;

    public Animator animator;
    private bool facingRight = true;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Jump();
        Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), 0f, 0f);
        transform.position += movement * Time.deltaTime * moveSpeed;
        //flip
        if (Input.GetAxis("Horizontal") < 0 && facingRight)
        {
            flip();
        }
        if (Input.GetAxis("Horizontal") > 0 && !facingRight)
        {
            flip();
        }
        
    }

    void Jump()
    {
        
        if (Input.GetButtonDown("Jump"))
        {
            rb2d.AddForce(new Vector2(0f, jumpForce), ForceMode2D.Impulse);
        }
        
    }

    void flip()
    {
        facingRight = !facingRight;
        transform.Rotate(0f, 180f, 0f);
    }
        
   
}
