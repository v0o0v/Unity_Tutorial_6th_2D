using UnityEngine;

public class StudyTransform : MonoBehaviour
{

    public float moveSpeed = 10f;
    
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
        if (Input.GetKey(KeyCode.UpArrow))
        {
            this.transform.position += Vector3.forward * moveSpeed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            this.transform.position += Vector3.back * moveSpeed * Time.deltaTime;
        }
    }
}