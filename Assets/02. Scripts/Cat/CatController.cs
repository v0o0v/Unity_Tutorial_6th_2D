using System;
using UnityEngine;

public class CatController : MonoBehaviour
{
    public float jumpPower = 5f;
    
    private Rigidbody2D catRb;
    private bool isGround;

    private void Start()
    {
        catRb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        Jump();
    }

    private void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isGround)
        {
            catRb.AddForceY(jumpPower, ForceMode2D.Impulse);
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.CompareTag("Ground"))
            isGround = true;
    }

    private void OnCollisionExit2D(Collision2D other)
    {
        if(other.gameObject.CompareTag("Ground"))
            isGround = false;
    }
}