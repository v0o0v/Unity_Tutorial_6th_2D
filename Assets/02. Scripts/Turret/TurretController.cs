using UnityEngine;

public class TurretController : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform shootTf;
    public Transform turretHeadTf;
    public float shootCooldown = 3f;


    private Transform targetTf;
    private float rotSpeed = 30f;
    private bool isRange;
    private float timer;

    void Start()
    {
        targetTf = GameObject.FindGameObjectWithTag("Player").transform;
    }

    void Update()
    {
        Turn();
        Shoot();
    }

    public void Turn()
    {
        isRange = Vector3.Distance(targetTf.position, transform.position) < 10f;
        if (isRange)
        {
            this.turretHeadTf.LookAt(targetTf.position + Vector3.up);
        }

        if (!isRange)
        {
            turretHeadTf.Rotate(Vector3.up * rotSpeed * Time.deltaTime);
        }
    }

    public void Shoot()
    {
        if (isRange)
        {
            timer += Time.deltaTime;
        }

        if (!isRange)
        {
            timer = 0f;
        }


        if (timer >= shootCooldown)
        {
            Instantiate(bulletPrefab, shootTf.position, shootTf.rotation);
            timer = 0f;
        }
    }
}