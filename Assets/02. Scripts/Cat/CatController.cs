using UnityEngine;

public class CatController : MonoBehaviour
{
    public float jumpPower = 5f;
    public float limitVelocity = 5f;
    public float rotPower = 3f;

    private Rigidbody2D catRb;
    private int jumpCount;
    private Animator catAnim;

    private void Start()
    {
        catRb = GetComponent<Rigidbody2D>();
        catAnim = GetComponent<Animator>();
    }

    private void Update()
    {
        Jump();
    }

    private void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space) && jumpCount < 3)
        {
            catAnim.SetBool("IsGround", false);
            catAnim.SetTrigger("Jump");
            catRb.AddForceY(jumpPower, ForceMode2D.Impulse);
            jumpCount++;
            if (catRb.linearVelocityY >= limitVelocity)
                catRb.linearVelocityY = limitVelocity;
        }
        
        Vector3 catRatation = transform.eulerAngles;
        catRatation.z = catRb.linearVelocityY * rotPower;
        transform.eulerAngles = catRatation;
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ground"))
            jumpCount = 0;
        catAnim.SetBool("IsGround", true);
    }
}