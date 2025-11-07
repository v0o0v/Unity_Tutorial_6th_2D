using UnityEngine;

class NPC
{
    public string npcName;
    public int npcAge;

    void Walk()
    {
    }

    void Talk()
    {
    }
}

public class NpcManager : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        NPC npc1 = new NPC();
        npc1.npcName = "상인";
        npc1.npcAge = 50;
        Debug.Log(npc1.npcName);
        Debug.Log(npc1.npcAge);
        
        NPC npc2 = new NPC();
        npc2.npcName = "경비병";
        npc2.npcAge = 30;
        Debug.Log(npc2.npcName);
        Debug.Log(npc2.npcAge);
    }
}