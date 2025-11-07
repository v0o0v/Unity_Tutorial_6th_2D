using UnityEngine;

public class StudyGameObject : MonoBehaviour
{
    public GameObject findObj;

    public GameObject childObj;

    public GameObject[] objs;
    // public StudyComponent studyComponent;

    void Start()
    {
        // this.findObj = GameObject.FindGameObjectWithTag("Character");

        // studyComponent = FindFirstObjectByType<StudyComponent>();
        // findObj = FindFirstObjectByType<StudyComponent>().gameObject;

        // findObj = GameObject.Find("Amongus");
        // childObj = findObj.transform.GetChild(1).gameObject;

        this.objs = GameObject.FindGameObjectsWithTag("Character");
    }
}