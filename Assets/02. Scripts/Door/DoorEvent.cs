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
        if (other.CompareTag("Player"))
            doorAnim.SetTrigger("Open");
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
            doorAnim.SetTrigger("Close");
    }
}