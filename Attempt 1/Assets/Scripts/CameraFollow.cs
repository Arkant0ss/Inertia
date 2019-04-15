using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player;
    public Vector3 offset;
    // Update is called once per frame
    void Update() // probably need to fix this
    {
        transform.rotation = player.rotation;
        if (transform.rotation.y == -180f)
        {
            transform.position = player.position - offset;
        }
        else
        {
            transform.position = player.position + offset;
        }
            
        
        
    }
}
