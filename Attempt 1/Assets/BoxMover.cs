using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxMover : MonoBehaviour
{
    public float movementSpeed;
    Vector3 direction = new Vector3();
    void FixedUpdate()
    {
        direction = Vector3.forward;
        gameObject.transform.Translate(direction * movementSpeed * Time.deltaTime);
    }
}
