using System;
using UnityEngine;

public class Wall : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("OnTriggerEnter2D");
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        Debug.Log("OnTriggerStay2D");
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        Debug.Log("OnTriggerExit2D");
    }
}
