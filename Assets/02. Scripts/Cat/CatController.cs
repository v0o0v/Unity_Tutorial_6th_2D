using UnityEngine;

public class CatController : MonoBehaviour
{
    public float jumpPower = 5f;
    public int jumpCount;

    private Rigidbody2D catRb;

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
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ground"))
            jumpCount = 0;
    }
}