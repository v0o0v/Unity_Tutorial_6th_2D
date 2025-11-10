using System;
using System.Runtime.CompilerServices;
using UnityEngine;

public class CarControl : MonoBehaviour
{
    private Rigidbody2D carRb;
    public float moveSpeed = 3f;
    private float h;

    private void Start()
    {
        this.carRb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        h = Input.GetAxis("Horizontal");
    }

    private void FixedUpdate()
    {
        carRb.linearVelocityX = h * moveSpeed;
    }

    // private void OnCollisionEnter2D(Collision2D other)
    // {
    //     if (other.gameObject.CompareTag("Monster"))
    //     {
    //         Debug.Log(gameObject.name + " : " + other.gameObject.name);    
    //     }
    // }


    // private float moveSpeed = 20f;
    //
    // void Update()
    // {
    //     if (Input.GetKey(KeyCode.RightArrow))
    //     {
    //         this.transform.position += Vector3.right * moveSpeed * Time.deltaTime;
    //     }
    //
    //     if (Input.GetKey(KeyCode.LeftArrow))
    //     {
    //         this.transform.position += Vector3.left * moveSpeed * Time.deltaTime;
    //     }
    // }
}