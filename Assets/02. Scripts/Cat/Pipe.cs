using System;
using UnityEngine;

public class Pipe : MonoBehaviour
{
    public float moveSpeed = 1f;
    
    private Vector3 startPos;

    private void Start()
    {
        startPos = transform.position;
    }

    private void Update()
    {
        transform.position += Vector3.left * moveSpeed * Time.deltaTime;
        
        if(transform.position.x <= -10)
        {
            transform.position = startPos;
        }
    }
}
