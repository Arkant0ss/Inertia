using UnityEngine.UI;
using UnityEngine;
using UnityEngine.Networking;

public class MultiScore : NetworkBehaviour //this needs to go on the bullets
{
    
    public int bulletdamage = 1;

    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Player")
        {
            CmdPlayerShot(collisionInfo.collider.transform.name, bulletdamage);
                       
        }
    }

    [Command]
    void CmdPlayerShot(string _playerID, int _damage)
    {
        Debug.Log(_playerID + " has been shot");
        MultiPlayerManager _player = MultiManager.GetPlayer(_playerID);
        _player.RpcTakeDamage(_damage);

    }


}

//Debug.Log(collisionInfo.collider.transform.rotation.y);
//if (collisionInfo.collider.transform.rotation.y >= .5f)
//{
//    ScoreKeeper.score1 += 1;
//    Debug.Log(ScoreKeeper.score1);
//}
//if (collisionInfo.collider.transform.rotation.y <= .5f)
//{
//    ScoreKeeper.score2 += 1;
//    Debug.Log(ScoreKeeper.score2);
//}