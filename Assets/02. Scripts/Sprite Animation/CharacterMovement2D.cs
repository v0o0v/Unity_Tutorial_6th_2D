using UnityEngine;

public class CharacterMovement2D : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float jumpPower = 10f;
    public SpriteRenderer[] renderers;

    private Rigidbody2D characterRb;
    private float h,v;

    private void Start()
    {
        characterRb = GetComponent<Rigidbody2D>();
        renderers = GetComponentsInChildren<SpriteRenderer>();
    }

    private void Update()
    {
        h = Input.GetAxis("Horizontal");
        v = Input.GetAxis("Vertical");
        ChangeSprite();
        Flip();
        // Jump();
    }

    private void FixedUpdate()
    {
        characterRb.linearVelocityX = h * moveSpeed;
        characterRb.linearVelocityY = v * moveSpeed;
    }

    private void Flip()
    {
        // if (h != 0)
        // {
        //     renderers[0].flipX = h < 0;
        //     renderers[1].flipX = h < 0;
        // }

        if (h < 0)
        {
            transform.localScale = new Vector3(-1, 1, 1);
        }
        else if(h > 0)
        {
            transform.localScale = new Vector3(1, 1, 1);
        }
    }

    private void ChangeSprite()
    {
        renderers[0].gameObject.SetActive(h == 0);
        renderers[1].gameObject.SetActive(h != 0);
    }

    private void Jump()
    {
        if (Input.GetButtonDown("Jump"))
        {
            characterRb.AddForceY(jumpPower, ForceMode2D.Impulse);
        }
    }
}