using UnityEngine.Networking;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[RequireComponent(typeof(MultiPlayerManager))]
public class PlayerSetup : NetworkBehaviour
{
    [SerializeField]
    Behaviour[] componentsToDisable;

    Camera sceneCamera;

    private void Start()
    {
        if (!isLocalPlayer)
        {
            for (int i = 0; i < componentsToDisable.Length; i += 1)
            {
                componentsToDisable[i].enabled = false;
            }
        }
        else
        {
            sceneCamera = Camera.main;
            if (sceneCamera != null)
            {
                sceneCamera.gameObject.SetActive(false);
            }

        }
        GetComponent<MultiPlayerManager>().Setup();
        
    }
    public override void OnStartClient()
    {
        base.OnStartClient();

        string _netID = GetComponent<NetworkIdentity>().netId.ToString();
        MultiPlayerManager _player = GetComponent<MultiPlayerManager>();
        MultiManager.RegisterPlayer(_netID, _player);
    }

    private void OnDisable()
    {
        if (sceneCamera != null)
        {
            sceneCamera.gameObject.SetActive(true);
        }
        MultiManager.UnRegisterPlayer(transform.name);
    }
}
