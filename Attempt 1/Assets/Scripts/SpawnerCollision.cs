using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerCollision : MonoBehaviour
{
    public BoxSpawner spawning;
    public GameManager gameManager;
    void OnTriggerEnter(Collider triggerInfo)
    {
        if (triggerInfo.tag == "Player")
        {
            if (gameObject.tag == "Henchmen")
            {
                gameManager.loselife();
            }
            if (gameObject.tag == "Boss" && gameManager.bosslives == 0)
            {
                gameManager.CompleteLevel();
            }
            if (gameObject.tag == "Boss" && gameManager.bosslives != 0)
            {
                gameManager.EndGame(); //need to fix this to say something better
            }
            gameObject.SetActive(false);
            
        }

    }
}
