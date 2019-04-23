using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class MultiPlayerManager : NetworkBehaviour
{
    [SyncVar]
    private bool _isDead = false;
    public bool isDead
    {
        get { return _isDead; }
        protected set { _isDead = value;}
    }
    public SimpleHealthBar healthBar; 
    [SerializeField]
    private int maxHealth = 10;
    [SyncVar]
    private int currentHealth;

    [SerializeField]
    private Behaviour[] disableOnDeath;
    [SerializeField]
    private bool[] wasEnabled; 

    public void Setup()
    {
        wasEnabled = new bool[disableOnDeath.Length];
        for (int i = 0; i < wasEnabled.Length; i++)
        {
            wasEnabled[i] = disableOnDeath[i].enabled;
        }
        SetDefaults();
    }
    private void Update()
    {
        if (!isLocalPlayer)
            return;
        if (Input.GetKeyDown(KeyCode.K))
        {
            RpcTakeDamage(5);
        }
    }

    [ClientRpc]
    public void RpcTakeDamage(int _amount)
    {
        if (isDead)
            return;
        currentHealth -= _amount;
        healthBar.UpdateBar(currentHealth, maxHealth);
        Debug.Log(transform.name + " now has " + currentHealth + " health.");
        if (currentHealth <= 0) //need to make a game over sort of thing
        {
            Die();
        }
    }
    private void Die()
    {
        isDead = true; //disable stuff
        for (int i = 0; i < disableOnDeath.Length; i++)
        {
            disableOnDeath[i].enabled = false;
        }
        Collider _col = GetComponent<Collider>();
        if (_col != null)
        {
            _col.enabled = false;
        }
        Debug.Log(transform.name + " is dead.");
        StartCoroutine(Respawn());
    }

    private IEnumerator Respawn()
    {
        yield return new WaitForSeconds(3f);

        //while _spawnPoint.tag //work on
            Transform _spawnPoint = NetworkManager.singleton.GetStartPosition();
        
        transform.position = _spawnPoint.position;
        transform.rotation = _spawnPoint.rotation;
        SetDefaults();

    }

    public void SetDefaults()
    {
        isDead = false;
        currentHealth = maxHealth;
        healthBar.UpdateBar(currentHealth, maxHealth);
        for (int i = 0; i < disableOnDeath.Length; i++)
        {
            disableOnDeath[i].enabled = wasEnabled[i];
        }
        Collider _col = GetComponent<Collider>();
        if (_col != null)
        {
            _col.enabled = true;
        }
    }
}
