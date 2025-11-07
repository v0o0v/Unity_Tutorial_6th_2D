using UnityEngine;

public class StudyMath : MonoBehaviour
{
    public float theta;
    public float speed = 3f;

    void Update()
    {
        theta += Time.deltaTime * speed;
        this.GetComponent<Light>().intensity = Mathf.Sin(theta);
    }
}