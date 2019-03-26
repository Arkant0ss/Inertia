using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    public GameManager gameManager;
    void OnTriggerEnter(Collider triggerInfo)
    {
        if (triggerInfo.tag == "Player")
        {
            gameManager.CompleteLevel();
        }
            
    }



}
