using UnityEngine.UI;
using UnityEngine;
using UnityEngine.Networking;

public class MultiScore : MonoBehaviour
{
    //public ScoreKeeper scoreKeeper;
    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "PlayerShot")
        {
            //Debug.Log(collisionInfo.collider.transform.rotation.y);
            if (collisionInfo.collider.transform.rotation.y >= .5f)
            {
                ScoreKeeper.score1 += 1;
                Debug.Log(ScoreKeeper.score1);
            }
            if (collisionInfo.collider.transform.rotation.y <= .5f)
            {
                ScoreKeeper.score2 += 1;
                Debug.Log(ScoreKeeper.score2);
            }
        }
    }

}
