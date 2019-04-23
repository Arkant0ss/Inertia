using UnityEngine;

public class MultiplayerMovement : MonoBehaviour
{
    public Transform player;
    public Rigidbody rb;
    public float forwardForce;
    public float sidewaysForce;
    private GameObject person;
    private string teamname;
    private void OnEnable()
    {
        Debug.Log(player.rotation.y); //need to fix which side you spawn on
        if (player.rotation.y == 1f)
        {
            sidewaysForce = -sidewaysForce;
            forwardForce = -forwardForce;
            teamname = "South";
        }
        else
        {
            teamname = "North";
        }
    }

    void FixedUpdate()
    {
        if (Input.GetKey("d") || Input.GetKey("right"))
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("a") || Input.GetKey("left"))
        {
            rb.AddForce(-sidewaysForce * Time.fixedDeltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("w") || Input.GetKey("up"))
        {
            rb.AddForce(0, 0, forwardForce * Time.fixedDeltaTime, ForceMode.VelocityChange);
        }
        if (Input.GetKey("s") || Input.GetKey("down"))
        {
            rb.AddForce(0, 0, -forwardForce * Time.fixedDeltaTime, ForceMode.VelocityChange);
        }
        //if (person.transform.position.y < -1f)
        //{
        //    FindObjectOfType<GameManager>().EndGame();
        //}
        //if (Input.GetKey("m"))
        //{
        //    FindObjectOfType<GameManager>().BackToMenu();
        //}
        //if (Input.GetKey("p"))
        //{
        //    FindObjectOfType<GameManager>().ScoreReset();

        //}
        //if (Input.GetKey("r"))
        //{
        //    FindObjectOfType<GameManager>().Restart();

        //}
    }
}
