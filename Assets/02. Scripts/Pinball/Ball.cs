using UnityEngine;

public class Ball : MonoBehaviour
{
    PinballController pinballController;
    Rigidbody2D ballRb;
    Vector3 startPosition;

    private void Start()
    {
        pinballController = FindFirstObjectByType<PinballController>();
        ballRb = GetComponent<Rigidbody2D>();
        startPosition = transform.position;
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        switch (other.gameObject.tag)
        {
            case "Point10":
                pinballController.addScore(10);
                break;
            case "Point50":
                pinballController.addScore(50);
                break;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        Debug.Log(pinballController.getScore() + " 획득\nGame Over");
        Invoke("Restart", 1f);
    }

    private void Restart()
    {
        transform.position = startPosition;
        ballRb.linearVelocity = Vector2.zero;
        ballRb.angularVelocity = 0;
        pinballController.resetScore();
        
    }
}