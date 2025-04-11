using UnityEngine;

public class KnightControls : MonoBehaviour
{
    Rigidbody2D rb;
    SpriteRenderer sp;
    Animator animator;
    //public SpriteRenderer spriteQuieto; 
    //public SpriteRenderer spriteCaminando; 

 
    void Start()
    {
       rb = GetComponent<Rigidbody2D>();
        sp= GetComponent<SpriteRenderer>();
        
    }

    void salto()
    {
        if (Input.GetKeyUp(KeyCode.Space))
        {
            rb.linearVelocityY = 12.5f;
            sp.flipX=true;
        }
    }
    void movimientoenX()
    {
        rb.linearVelocityX = 0;
        animator.SetInteger("Estado", 0);
        if (Input.GetKey(KeyCode.RightArrow))
        {

            rb.linearVelocityX = 10;
            sp.flipX = false;
            animator.SetInteger("Estado", 1);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {

            rb.linearVelocityX = -10;
            sp.flipX = true;
            animator.SetInteger("Estado", 1);
        }
    }
    void Update()
    {
        movimientoenX();
        salto();
    }
}
