using UnityEngine;

public class CatController : MonoBehaviour
{
    public float jumpPower = 5f;
    public float limitVelocity = 5f;

    private Rigidbody2D catRb;
    private int jumpCount;

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
        if (Input.GetKeyDown(KeyCode.Space) && jumpCount < 3)
        {
            catRb.AddForceY(jumpPower, ForceMode2D.Impulse);
            jumpCount++;
            if (catRb.linearVelocityY >= limitVelocity)
                catRb.linearVelocityY = limitVelocity;
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ground"))
            jumpCount = 0;
    }
}