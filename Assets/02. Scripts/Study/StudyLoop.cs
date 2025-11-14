using UnityEngine;

public class StudyLoop : MonoBehaviour
{
    public int count;

    private void Start()
    {
        while (count < 5)
        {
            count++;
            Debug.Log(count);
        }
    }
}
