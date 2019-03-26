using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewMovement : MonoBehaviour
{
    public Transform testplayer;
    public float forwardForce;
    public float sidewaysForce;
    // Update is called once per frame
    void FixedUpdate()
    {

        if (Input.GetKey("d") || Input.GetKey("right"))
        {
            testplayer.Translate(Vector3.right * sidewaysForce * Time.deltaTime);
        }
        if (Input.GetKey("a") || Input.GetKey("left"))
        {
            testplayer.Translate(Vector3.left * sidewaysForce * Time.deltaTime);
        }
        if (Input.GetKey("w") || Input.GetKey("up"))
        {
            testplayer.Translate(Vector3.forward * forwardForce * Time.deltaTime);
        }
        if (testplayer.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
        if (Input.GetKey("m"))
        {
            FindObjectOfType<GameManager>().BackToMenu();
        }
        if (Input.GetKey("p"))
        {
            FindObjectOfType<GameManager>().ScoreReset();

        }
        if (Input.GetKey("r"))
        {
            FindObjectOfType<GameManager>().Restart();

        }
    }
}
