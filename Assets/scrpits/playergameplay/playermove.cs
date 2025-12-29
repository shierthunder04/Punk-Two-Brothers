using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermove : MonoBehaviour
{
    

    public GameObject jugador;

    public float vida = 3;

    public float runspeed = 2;

    public float jumpspeed = 3;

    Rigidbody2D rb2D;

    public SpriteRenderer spriterenderer;

    public Animator animator;

    public AudioSource jumpsound;


    // Start is called before the first frame update
    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
        jumpsound = GetComponent<AudioSource>();
    }
    private void Update()
    {

    }


    // Update is called once per frame
    void FixedUpdate()
    {

        if (Input.GetKey("d") || Input.GetKey("right"))
        {
            rb2D.velocity = new Vector2(runspeed, rb2D.velocity.y);
            spriterenderer.flipX = false;
            animator.SetBool("run", true);
        }

        else if (Input.GetKey("a") || Input.GetKey("left"))
        {
            rb2D.velocity = new Vector2(-runspeed, rb2D.velocity.y);
            spriterenderer.flipX = true;
            animator.SetBool("run", true);
        }
        else
        {
            rb2D.velocity = new Vector2(0, rb2D.velocity.y);
            animator.SetBool("run", false);
        }
        if (Input.GetKey("w") && checkGround.isGrounded )
        {
            rb2D.velocity = new Vector2(rb2D.velocity.x, jumpspeed);
            jumpsound.Play();
        }
        if(Input.GetKey("space") && checkGround.isGrounded)
        {
            rb2D.velocity = new Vector2(rb2D.velocity.x, jumpspeed);
            jumpsound.Play();
        }


        if (checkGround.isGrounded == false)
        {
            animator.SetBool("jump", true);
            animator.SetBool("run", false);

        }
        if (checkGround.isGrounded == true)
        {
            animator.SetBool("jump", false);
        }



    }
}
