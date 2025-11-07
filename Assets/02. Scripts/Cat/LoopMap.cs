using UnityEngine;

public class LoopMap : MonoBehaviour
{
    public MeshRenderer meshRenderer;
    public float offsetSpeed = 1f;

    void Start()
    {
        this.meshRenderer = GetComponent<MeshRenderer>();
    }
}
