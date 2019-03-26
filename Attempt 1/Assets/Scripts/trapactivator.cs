using UnityEngine;

public class trapactivator : MonoBehaviour
{
    public Rigidbody rbody;
    public Transform obstacle;
    public float delay;
    public Transform person;
    float distance = 1f;


    // We want to look at player position and if it is close enough we want to turn on gravity
    void Update()
    {
        distance = obstacle.position.z - delay;
        if (person.position.z.ToString("0") == distance.ToString("0"))
        {
            rbody.useGravity = true;
        }
        
    }
}
