using UnityEngine;

public class ScriptB : MonoBehaviour
{
    public ScriptA scriptA;

    void Start()
    {
        Debug.Log(scriptA.number1);
    }
}