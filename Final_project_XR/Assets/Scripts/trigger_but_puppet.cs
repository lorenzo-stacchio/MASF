using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trigger_but_puppet : MonoBehaviour
{
    [SerializeField] private GameObject objectToSpawn;
    
    private void OnTriggerEnter(Collider other)
    {
        //Debug.Log("Colliding enter with tag " +  other.tag);
        if (other.tag == "Player"){
            objectToSpawn.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player"){
            objectToSpawn.SetActive(false);
        }
    }
}
