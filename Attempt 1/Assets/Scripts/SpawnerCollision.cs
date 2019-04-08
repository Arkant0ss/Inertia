using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerCollision : MonoBehaviour
{
    public BoxSpawner spawning;
    public GameManager gameManager;
    void OnTriggerEnter(Collider triggerInfo)
    {
        if (triggerInfo.tag == "Player" || triggerInfo.tag == "PlayerShot")
        {
            if (gameObject.tag == "Henchmen")
            {
                gameManager.loselife();
            }
            if (gameObject.tag == "Boss" && gameManager.bosslives == 0)
            {
                gameManager.CompleteLevel();
            }
            if (gameObject.tag == "Boss" && gameManager.bosslives != 0 && triggerInfo.tag == "Player")
            {
                gameManager.EndGame(); //need to fix this to say something better
            }
            if (gameObject.tag == "Boss" && gameManager.bosslives != 0 && triggerInfo.tag == "PlayerShot")
            {
                //to prevent people from accidentially killing the boss
            }
            else
            {
                gameObject.SetActive(false);
            }
            
            
        }

    }
}
