using UnityEngine;

public class PinballController : MonoBehaviour
{
    public Rigidbody2D leftHandleRb;
    public Rigidbody2D rightHandleRb;

    public float pushPower = 10f;
    public float releasePower = 30f;

    private bool isLeftUp, isRightUp;

    private int score = 0;

    private void Update()
    {
        isLeftUp = Input.GetKey(KeyCode.LeftArrow);
        isRightUp = Input.GetKey(KeyCode.RightArrow);
    }

    private void FixedUpdate()
    {
        if (isLeftUp)
        {
            leftHandleRb.AddTorque(pushPower, ForceMode2D.Impulse);
        }
        else
        {
            leftHandleRb.AddTorque(-releasePower);
        }

        if (isRightUp)
        {
            rightHandleRb.AddTorque(-pushPower, ForceMode2D.Impulse);
        }
        else
        {
            rightHandleRb.AddTorque(releasePower);
        }
    }

    public void addScore(int score)
    {
        this.score += score;
        Debug.Log(score + " 획득");
    }

    public int getScore()
    {
        return this.score;
    }

    public void resetScore()
    {
        this.score = 0;
    }
}