using UnityEngine;

public class RouletteController : MonoBehaviour
{
    public float rotSpeed = 0f;

    public bool isStop = false;

    void Update()
    {
        transform.Rotate(-Vector3.forward * rotSpeed);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            rotSpeed = 5f;
        }

        if (Input.GetKeyDown(KeyCode.Return))
        {
            isStop = true;
        }

        if (isStop)
        {
            rotSpeed *= 0.98f;
            if (rotSpeed < 0.1f)
            {
                isStop = false;
                rotSpeed = 0f;
            }
                
        }
    }
}