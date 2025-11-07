using UnityEngine;

public class PlanetOrbit : MonoBehaviour
{
    public Transform targetPlanet;
    public float rotSpeed = 100f;
    
    void Update()
    {
        transform.RotateAround(targetPlanet.position, Vector3.up, rotSpeed * Time.deltaTime);
    }
}
