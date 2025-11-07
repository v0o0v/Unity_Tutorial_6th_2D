using UnityEngine;

public class TurretControl : MonoBehaviour
{
    public Transform target;

    public float rotSpeed = 1.5f;

    private float distance = 10f;

    public Vector3 initRotation;

    private bool isLookAt = false;

    void Start()
    {
        initRotation = transform.GetChild(1).transform.rotation.eulerAngles;
    }

    void Update()
    {
        if (target == null)
            return;

        Transform gun = transform.GetChild(1);

        if (Vector3.Distance(transform.position, target.position) < distance)
        {
            gun.LookAt(target);
            isLookAt = true;
        }
        else
        {
            if (isLookAt)
            {
                gun.rotation = Quaternion.Euler(initRotation);
                isLookAt = false;
            }

            gun.Rotate(Vector3.up, rotSpeed);
        }
    }
}