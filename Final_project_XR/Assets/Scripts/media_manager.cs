using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public enum Metrics{
    bpm,
    mmHg, 
    spO2,
    rpm,
    temperature,
}


public class media_manager : MonoBehaviour
{
    // Start is called before the first frame update

    //[SerializeField] Text value; // eeg simulation
    [SerializeField] Metrics info_to_reproduce;


    void Start()
    {
        updateInfo();
        InvokeRepeating("updateInfo", 5.0f, 1);
    }
    
    // Update is called once per frame
    void updateInfo()
    {
        // this script hypotesize the existence of a children named value
        var text_component = GetComponentInChildren<Text> ();
        switch (info_to_reproduce)
        {
        case Metrics.bpm:
            //50 e 120 
            text_component.text = Mathf.Round(Random.Range(50, 120)).ToString() + " bpm";
            break;
        case Metrics.rpm:
           // 16 e 20 al minuto
            text_component.text = Mathf.Round(Random.Range(16, 20)).ToString()+ " rpm";
            break;
        case Metrics.mmHg:
           //90 160 
            var min = Mathf.Round(Random.Range(70, 110));  
            var max = Mathf.Round(Random.Range(140, 180));  
            text_component.text = string.Format("{0}\n{1}\n({2})", min.ToString(), max.ToString() , (int)(min+max)/2).ToString();
            break;
        case Metrics.spO2:
           //90 100
            text_component.text = Mathf.Round(Random.Range(90, 100)).ToString() + " %";
            break;
        default: // temperature
            //36,39
            text_component.text = Mathf.Round(Random.Range(36, 39)).ToString()+ " °C";;
            Debug.Log("No default");
            break;
        }
    }
}
