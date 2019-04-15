using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class MultiShooter : NetworkBehaviour
{
    
    public GameObject bullet;
    private List<GameObject> objectlist = new List<GameObject>();
    private GameObject newthing;
    public float spawnspeed;

    void OnEnable()
    {
        CmdShoot();
    }
    [Command]
    void CmdShoot()
    {
        newthing = Instantiate(bullet, gameObject.transform);
        NetworkServer.Spawn(newthing);
        objectlist.Add(newthing);
        foreach (GameObject thing in objectlist)
        {
            if (thing != null)
            {
                if (thing.transform.position.y < -1)
                {

                    Destroy(thing);
                }
                else
                {
                    Destroy(thing, 10f);
                }
            }
        }
    }

}
