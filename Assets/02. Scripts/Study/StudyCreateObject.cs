using UnityEngine;

public class StudyCreateObject : MonoBehaviour
{
    public GameObject characterPrefab;
    void Awake()
    {
        GameObject o = Instantiate(characterPrefab);
        o.name = "Amongus";
        o.tag = "Player";
    }
}
