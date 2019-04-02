﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PersistentManagerScript : MonoBehaviour
{
    public static PersistentManagerScript Instance { get; private set; }

    public List<string> collectedkeys = new List<string>();
    public int OxygenTanks = 0;
    public float CurrentTime = 0f;
    public int SpawnPoint = 0;
    public bool gun = false;
    public int direction = 0;

    private void Awake()
    {
        CreatePersistentSingleton();
    }
    
    private void CreatePersistentSingleton()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    /// <summary>
    ///     It happens when the player dies.
    /// </summary>
    public void RestartValues()
    {
        //we reset all persisted values
        OxygenTanks = 0;
        CurrentTime = 0;
        SpawnPoint = 0;
        gun = false;
        direction = 0;
    }
}
