using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

public class MultiShooter : NetworkBehaviour
{
    private bool playershooting;
    public float ammocount = 5f;
    private float ammoleft;
    private bool reloading = false;
    private int reloadstarttimer = 0;
    public int reloadtime = 0;
    public Text ammotext;
    public SimpleHealthBar ammoBar;

    public GameObject bullet;
    private List<GameObject> objectlist = new List<GameObject>();
    private GameObject newthing;
    public float spawnspeed;

    private void Start()
    {
        ammoleft = ammocount;
        //ammotext = GameObject.Find("Ammotext").GetComponent<Text>();
    }
    private void Update()
    {
        if (reloading == true)
        {
            if ((int)Time.time - reloadstarttimer == reloadtime)
            {
                reloading = false;
                ammoleft = ammocount;
                ammotext.text = ammoleft.ToString();
                ammoBar.UpdateBar(ammoleft, ammocount);
            }
        }
        if (Input.GetKey("space") && reloading == false)
        {
            if (playershooting == false)
            {
                ammoleft = ammoleft - 1f;
                ammotext.text = ammoleft.ToString();
                ammoBar.UpdateBar(ammoleft, ammocount);
                CmdShoot();
            }
            playershooting = true;

            if (ammoleft == 0f)
            {
                reloadstarttimer = (int)Time.time;
                reloading = true;
            }
        }
        else
        {
            playershooting = false;
        }
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
