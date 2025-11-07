using UnityEngine;

public class StudyMaterial : MonoBehaviour
{
    public Material mat;
    void Start()
    {
        GetComponent<MeshRenderer>().material = this.mat;
    }
}
