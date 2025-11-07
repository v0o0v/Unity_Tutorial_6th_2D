using UnityEngine;

public class CarControl : MonoBehaviour
{
    private float moveSpeed = 20f;

    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            this.transform.position += Vector3.right * moveSpeed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            this.transform.position += Vector3.left * moveSpeed * Time.deltaTime;
        }
    }
}