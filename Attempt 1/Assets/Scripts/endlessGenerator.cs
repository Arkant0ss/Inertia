using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class endlessGenerator : MonoBehaviour
{
    public GameObject cubePrefab;
    public GameObject longPrefab;
    public GameObject skinnyPrefab;
    public GameObject platform;
    private GameObject last;
    public Transform player;
    int choice;
    Vector3 offset = new Vector3(0, 0, 20);
    Vector3 platformoffset = new Vector3(0,-1,20);
    GameObject chosenPrefab;
    bool spawned = true;

    void Start()
    {
        InvokeRepeating("Caller", .1f, .1f);
        //InvokeRepeating("Platformer", .1f, 1f);
    }

    void Caller()
    {
        if ((int)player.position.z % 2 == 0)
        {
            if (spawned == true)
            {
                Invoke("Chooser", 1f);
                
            }
            
        }
        else
        {
            offset.z = 30f;
            spawned = true;
        }
    }
    void Platformer()
    {
        platformoffset.x = 0;
        Instantiate(platform, player.position + platformoffset, Quaternion.identity);
        platformoffset.x = -5;
        Instantiate(platform, player.position + platformoffset, Quaternion.identity);
        platformoffset.x = 5;
        Instantiate(platform, player.position + platformoffset, Quaternion.identity);
    }
    void Chooser()
    {
        int choice = Random.Range(1, 6);
        offset.x = Random.Range(-4, 5);
        if (choice == 1 || choice == 4)
        {
            chosenPrefab = cubePrefab;
        }
        if (choice == 2)
        {
            chosenPrefab = longPrefab;
        }
        if (choice == 3 || choice == 5)
        {
            chosenPrefab = skinnyPrefab;
        }
        last = Instantiate(chosenPrefab, player.position + offset, Quaternion.identity);
        Destroy(last, 10f);

        offset.z += 15f;
        spawned = false;
        
    }
}
