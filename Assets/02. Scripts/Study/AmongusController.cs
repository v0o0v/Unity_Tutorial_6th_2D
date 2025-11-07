using UnityEngine;

public class AmongusController : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float turnSpeed = 40f;

    private float h, v;
    private Vector3 dir;

    void Update()
    {
        h = Input.GetAxis("Horizontal");
        v = Input.GetAxis("Vertical");
        dir = new Vector3(h, 0, v).normalized;

        Move();
        Turn();
    }

    private void Move()
    {
        transform.position += dir * moveSpeed * Time.deltaTime;
    }

    private void Turn()
    {
        // transform.LookAt(transform.position + dir);

        if (h != 0 || v != 0)
        {
            Quaternion newRotation = Quaternion.LookRotation(dir);
            transform.rotation = Quaternion.Slerp(transform.rotation, newRotation, Time.deltaTime * turnSpeed);
        }
    }
}