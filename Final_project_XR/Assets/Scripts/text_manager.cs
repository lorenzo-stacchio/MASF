using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class text_manager : MonoBehaviour
{
    [SerializeField] private Text name;
    [SerializeField] private Text surgery;
    [SerializeField] private Text description;

    [SerializeField] private trigger_but_puppet patient1;
    [SerializeField] private trigger_but_puppet patient2;

    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (patient1.playerNearPatient)
        {
            name.text = "Name: Mario Rossi";
            surgery.text = "Surgery: laparoscopic colorectal surgery";
            description.text = "Description: Colorectal cancer Previously operated for diverticulitis";
        }
        else if (patient2.playerNearPatient)
        {
            name.text = "Name: Antonio Verdi";
            surgery.text = "Surgery: Coronary Angioplasty";
            description.text = "Description: Surgery performed during an acute heart attack (the artery is completely occluded) Third day of hospitalization";
        }
    }
    
    
}
