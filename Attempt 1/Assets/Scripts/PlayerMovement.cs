using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    //void Start()
    //{

    //}
    // Update is called once per frame

    public Transform player;
    public Rigidbody rb;
    public float forwardForce;
    public float sidewaysForce;
    public float naturalForce;
    private Vector3 shrink = new Vector3(.5f, .5f, .5f);
    private GameObject person; //This was to avoid continuity errors
    

    void FixedUpdate()
    {
        person = GameObject.FindGameObjectWithTag("Player");
        rb.AddForce(0, 0, naturalForce * Time.deltaTime);
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
        if (Input.GetKey("l"))
        {
            player.localScale = shrink;
        }
       if (person.transform.position.y < -1f)
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
       if (Input.GetKey("t"))
       {
           FindObjectOfType<TimeKeeper>().TimerOn();
            PlayerPrefs.SetString("TimerActive", "On");

        }
       if (Input.GetKey("o"))
       {
           FindObjectOfType<TimeKeeper>().TimerOff();
            PlayerPrefs.SetString("TimerActive", "NotOn");

        }



        //if (Input.GetKey("s"))
        //{
        //    rb.AddForce(0, 0, -forwardForce * Time.deltaTime);
        //}
    }
}
