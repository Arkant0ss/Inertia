using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BouncePad : MonoBehaviour
{
    public Transform player;
    public Rigidbody playerrigidbody;
    public float bounceforce;
    //public Vector3 direction = new Vector3();
    //public float movespeed;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Player")
        {
            Debug.Log("bounce");
            Invoke("Bouncer", .1f);
        }
    }
    public void Bouncer()
    {
        //direction = Vector3.up;
        playerrigidbody.AddForce(0, bounceforce* 100, 0);
        //gameObject.transform.Translate(direction * movespeed);
    }
}
