using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    public BoxSpawner playershooting;
    private void FixedUpdate()
    {
        if (Input.GetKey("space"))
        {
            playershooting.enabled = true;
            Invoke("TurnOff", .1f);

        }
        else
        {
            playershooting.enabled = false;
        }
        
    }
    public void TurnOff()
    {
        //playershooting.enabled = false;

    }

}
