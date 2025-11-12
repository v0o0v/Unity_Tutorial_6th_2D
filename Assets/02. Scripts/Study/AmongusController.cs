using UnityEngine;

public class AmongusController : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float turnSpeed = 5f;
    public float jumpPower = 10f;

    
    private float h, v;
    private Vector3 dir;

    private Rigidbody rb;
    private Animator anim;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        h = Input.GetAxis("Horizontal");
        v = Input.GetAxis("Vertical");
        dir = new Vector3(h, 0, v).normalized;
        
        anim.SetBool("IsWalk", h != 0 || v != 0);
        Jump();
    }

    private void FixedUpdate()
    {
        Move();
        Turn();
    }

    private void Move()
    {
        // 트랜스폼 이동
        // transform.position += dir * moveSpeed * Time.deltaTime;
        // transform.Translate(dir * moveSpeed * Time.deltaTime);

        // 리지드바디 이동 - 1
        // rb.linearVelocity = dir * moveSpeed;

        // 리지드바디 이동 - 2
        Vector3 targetPosition = rb.position + dir * moveSpeed;
        rb.MovePosition(targetPosition);
    }

    private void Turn()
    {
        // transform.LookAt(transform.position + dir);

        if (h != 0 || v != 0)
        {
            Quaternion targetRotation = Quaternion.LookRotation(dir);
            Quaternion newRotation = Quaternion.Slerp(rb.rotation, targetRotation, turnSpeed);
            rb.MoveRotation(newRotation);
        }
    }

    private void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            anim.SetTrigger("Jump");
            rb.AddForce(Vector3.up * jumpPower, ForceMode.Impulse);
        }
    }
}