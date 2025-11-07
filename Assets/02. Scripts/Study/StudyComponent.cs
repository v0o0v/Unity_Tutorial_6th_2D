using UnityEngine;

public class StudyComponent : MonoBehaviour
{
    public GameObject obj;
    public Mesh mesh;
    public Material mat;

    void Start()
    {
        obj = this.gameObject;
        obj.name = "큐브";

        obj.AddComponent<MeshFilter>();
        obj.GetComponent<MeshFilter>().mesh = this.mesh;

        obj.AddComponent<MeshRenderer>();
        obj.GetComponent<MeshRenderer>().material = this.mat;

        obj.AddComponent<BoxCollider>();
    }
}