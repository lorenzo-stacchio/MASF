using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerARmanager : MonoBehaviour
{
    [SerializeField] private GameObject objectToSpawn;
    
    private void OnTriggerEnter(Collider other)
    {
        objectToSpawn.SetActive(true);
    }

    private void OnTriggerExit(Collider other)
    {
        objectToSpawn.SetActive(false);
    }
}
