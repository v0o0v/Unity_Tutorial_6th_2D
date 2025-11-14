using System;
using UnityEngine;
using Random = UnityEngine.Random;

public class StudyRandom : MonoBehaviour
{
    public Transform target;

    private void Update()
    {
        target.position = new Vector3(Random.Range(0, 10), 0, Random.Range(0, 10));
    }
}