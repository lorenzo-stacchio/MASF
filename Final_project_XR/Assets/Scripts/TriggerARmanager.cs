using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerARmanager : MonoBehaviour
{
    [SerializeField] private GameObject objectToSpawn;

    public bool insideRoom1, insideRoom2;
    private void OnTriggerEnter(Collider other)
    {
        //Debug.Log("Colliding enter with tag " +  other.tag);
        if (other.tag == "patient"){
            objectToSpawn.SetActive(true);
            insideRoom1 = true;
        }
        else if (other.tag == "patient1"){
            objectToSpawn.SetActive(true);
            insideRoom2 = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "patient"){
            objectToSpawn.SetActive(false);
            insideRoom1 = false;
        }
        else if (other.tag == "patient1"){
            objectToSpawn.SetActive(false);
            insideRoom2 = false;
        }
    }
}
