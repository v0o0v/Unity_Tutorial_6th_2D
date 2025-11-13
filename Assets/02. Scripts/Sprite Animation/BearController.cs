using UnityEngine;

public class BearController : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float attackRange = 1f;
    public float attackCooldown = 2f;
    public float attackTimer = 2f;
    public float timer;

    private Animator bearAnim;
    private Transform target;
    private SpriteRenderer renderer;


    private void Start()
    {
        renderer = GetComponent<SpriteRenderer>();
        bearAnim = GetComponent<Animator>();
    }

    private void Update()
    {
        if (target != null)
        {
            Trace();
        }
        else
        {
            Patrol();
        }
    }

    private void Patrol()
    {
        timer += Time.deltaTime;
        if (timer >= 3f)
        {
            transform.position += Vector3.right * moveSpeed * Time.deltaTime;
            bearAnim.SetBool("IsWalking", true);
            if (timer >= 5f)
            {
                timer = 0f;
                bearAnim.SetBool("IsWalking", false);
            }
        }
    }

    private void Trace()
    {
        Vector3 dir = (target.position - transform.position).normalized;
        transform.position += dir * moveSpeed * Time.deltaTime;

        if (dir.x > 0)
        {
            renderer.flipX = false;
        }
        else if (dir.x < 0)
        {
            renderer.flipX = true;
        }

        Attack();
    }

    private void Attack()
    {
        float distance = Vector3.Distance(transform.position, target.position);
        if (distance < attackRange)
        {
            bearAnim.SetBool("IsRun", false);
            attackTimer += Time.deltaTime;
            if (attackTimer >= attackCooldown)
            {
                bearAnim.SetTrigger("Attack");
                attackTimer = 0f;
            }
        }
        else
        {
            bearAnim.SetBool("IsRun", true);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            target = other.transform;
            bearAnim.SetBool("IsRun", true);
            bearAnim.SetBool("IsWalk", false);
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            target = null;
            bearAnim.SetBool("IsRun", false);
            bearAnim.SetBool("IsWalk", false);
        }
    }
}