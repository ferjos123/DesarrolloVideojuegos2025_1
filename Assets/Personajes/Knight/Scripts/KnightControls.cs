using UnityEngine;

public class KnightControls : MonoBehaviour
{
    Rigidbody2D rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    { 
        rb.linearVelocityX=0;
        if (Input.GetKey(KeyCode.RightArrow))
        {
            rb.linearVelocityX = 5;
        }
    }
}
