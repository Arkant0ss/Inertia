using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMover : MonoBehaviour
{
    //public float upForce = 1f;
    public float sideForce = 1f;
    public Rigidbody rb;
    // Start is called before the first frame update

    void OnEnable()
    {
        float xForce = Random.Range(10, sideForce);
        //float yForce = Random.Range(upForce / 2f, upForce);
        //float zForce = Random.Range(-sideForce, sideForce);

        rb.AddForce(xForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        //Vector3 force = new Vector3(xForce, 0, 0);
        //GetComponent<Rigidbody>().velocity = force;
    }

   
}
