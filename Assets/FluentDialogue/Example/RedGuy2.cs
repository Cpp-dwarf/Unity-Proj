using UnityEngine;

public class RedGuy2 : MonoBehaviour
{
    public GameObject NPC14;

    void OnTriggerEnter(Collider collider)
    {
        NPC14.GetComponentInChildren<Conversation14>().HasVisitedRed = true;
    }
}
