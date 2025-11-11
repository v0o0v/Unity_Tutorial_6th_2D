using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    SpriteRenderer renderer;
    Color initColor;

    private void Start()
    {
        renderer = GetComponent<SpriteRenderer>();
        initColor = renderer.color;
    }

    public void Hitcolor()
    {
        renderer.color = Color.red;
        Invoke("ReturnColor", 0.2f);
    }

    public void ReturnColor()
    {
        renderer.color = initColor;
    }
}