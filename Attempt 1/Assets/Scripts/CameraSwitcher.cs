using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwitcher : MonoBehaviour
{
    private GameObject cam;
    private void OnEnable()
    {
        cam = GameObject.FindGameObjectWithTag("MainCamera");
        cam.SetActive(false);
    }
    private void OnDisable()
    {
        cam = GameObject.FindGameObjectWithTag("MainCamera");
        cam.SetActive(true);
    }
}
