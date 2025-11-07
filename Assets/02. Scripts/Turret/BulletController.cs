using System;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    public float bulletSpeed = 50f;

    void Start()
    {
        Destroy(gameObject, 1f);
    }
    public void Update()
    {
        transform.position += transform.forward * bulletSpeed * Time.deltaTime;
    }
}
