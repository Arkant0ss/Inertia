using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSpawner : MonoBehaviour
{
    ObjectPooler objectPooler;
    public Transform player;
  
    Vector3 cubestart = new Vector3(-48, 1, -40);

    void Start()
    {
        objectPooler = ObjectPooler.Instance;
    }
    void FixedUpdate()
    {
        Invoke("SpawnNow", 3);
    }
    void SpawnNow()
    {
        cubestart.z = Random.Range(player.position.z, player.position.z + 50f);
        objectPooler.SpawnFromPool("Cube",cubestart, Quaternion.identity);
    }
}
