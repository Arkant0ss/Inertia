using System.Collections.Generic;
using System.Collections;
using UnityEngine;

public class BoxSpawner : MonoBehaviour
{
    public GameObject box;
    private List<GameObject> objectlist = new List<GameObject>();
    private GameObject newthing;
    public float spawnspeed;
    [Header("Starting Rotation")]
    public float xcoordinate; 
    public float ycoordinate;
    public float zcoordinate;
    [Header("Sets randomrange for y")]
    public float yminrange;
    public float ymaxrange;
    public bool randomness;
    [Header("Only in use if randomness is false")]
    public float xincrementer; //possibly going to make these random
    public float yincrementer; 
    public float zincrementer;
    Vector3 rotationchanger = new Vector3();

    void Start()
    {
        rotationchanger.x = xcoordinate;
        rotationchanger.y = ycoordinate;
        rotationchanger.z = zcoordinate;
        InvokeRepeating("BeginSpawning", 1f, spawnspeed); 
    }

    public void BeginSpawning()
    {
        newthing = Instantiate(box, gameObject.transform);
        newthing.transform.Rotate(rotationchanger);
        if (randomness == false)
        {
            rotationchanger.x += xincrementer; //rotates a bit by the same amount each time
            rotationchanger.y += yincrementer;
            rotationchanger.z += zincrementer;
        }
        else
        {
            rotationchanger.y = Random.Range(yminrange, ymaxrange); //currently only for y
        }
        objectlist.Add(newthing);
        foreach (GameObject thing in objectlist)
        {
            if (thing != null)
            {
                if (thing.transform.position.y < -1)
                {
                    
                    Destroy(thing);
                }
                else
                {
                    Destroy(thing, 10f); 
                    //objectlist.Remove(thing); //not sure about this
                }
            }



        }

    }
}
