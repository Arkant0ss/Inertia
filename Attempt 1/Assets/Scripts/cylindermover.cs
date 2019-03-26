using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cylindermover : MonoBehaviour
{
    public Transform cylinder;
    public float movementSpeed;
    Vector3 direction = new Vector3();
    public float startingdirection;
    void Start()
    {
        direction.x = startingdirection; //the value needs to be 1 or -1
    }
    void FixedUpdate()
    {
        if ((int)cylinder.position.x == 5)
        {
            direction = Vector3.left;
        }
        else if ((int)cylinder.position.x == -5)
        {
            direction = Vector3.right;
        }
        cylinder.Translate(direction * movementSpeed * Time.deltaTime);
    }

}
