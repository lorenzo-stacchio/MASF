using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Note : MonoBehaviour
{
    [SerializeField] private Text nameText;

    [SerializeField] private Text surgeryText;

    [SerializeField] private Text descriptionText;

    public void EditNote(string name, string surgery, string description)
    {
        nameText.text = name;
        surgeryText.text = surgery;
        descriptionText.text = description;

    }
}