using System;
using UnityEngine;

public class DoorEvent : MonoBehaviour
{
    
    Animator doorAnim;

    private void Start()
    {
        doorAnim = GetComponent<Animator>();
    }

    private void OnTriggerEnter(Collider other)
    {
        doorAnim.SetTrigger("Open");
    }

    private void OnTriggerExit(Collider other)
    {
        doorAnim.SetTrigger("Close");
    }
}