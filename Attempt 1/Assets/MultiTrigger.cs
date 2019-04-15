using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MultiTrigger : MonoBehaviour
{
    public MultiShooter playershooting;
    public float ammocount = 5f;
    private float ammoleft;
    private bool reloading = false;
    private int reloadstarttimer = 0;
    public int reloadtime = 0;
    private Text ammotext;

    private void Start()
    {
        ammoleft = ammocount;
        ammotext = GameObject.Find("Ammotext").GetComponent<Text>();
    }
    private void FixedUpdate()
    {
        if(reloading == true)
        {
            if ((int)Time.time - reloadstarttimer == reloadtime)
            {
                reloading = false;
                ammoleft = ammocount;
                ammotext.text = ammoleft.ToString();
            }
        }
        if (Input.GetKey("space") && reloading == false)
        {
            if (playershooting.enabled == false)
            {
                ammoleft = ammoleft - 1f;
                ammotext.text = ammoleft.ToString();
            }
            playershooting.enabled = true;
            
            if (ammoleft == 0f)
                {
                    reloadstarttimer = (int)Time.time;
                    reloading = true;
                }
        }
        else
        {
            playershooting.enabled = false;
        }
    }

    //IEnumerator AmmoCheck()
    //{
    //    reloading = false;
    //    //while (ammoleft != 0f)
    //    //    Debug.Log(ammoleft);
    //    //Debug.Log("out of ammo");
    //    //reloading = true;
    //    Debug.Log("Hi");
    //    yield return new WaitForSeconds(1f);
    //}
}
