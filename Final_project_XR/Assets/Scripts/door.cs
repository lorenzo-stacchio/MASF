using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class door : MonoBehaviour
{
    Vector3 init_position;
    Quaternion init_rotation;
    bool entered;
    // Start is called before the first frame update
    void Start()
    {
        this.init_position = this.GetComponent<Transform>().position;
        this.init_rotation = this.GetComponent<Transform>().rotation;
        //Debug.Log(this.init_position);
        //Debug.Log(this.init_rotation);
        this.entered = false;
    }

    // Update is called once per frame
    void OnTriggerEnter(Collider other)
    {
        if (other.tag=="Player" &&  !this.entered){
            //Debug.Log("Here in trigger");
            this.entered = true;
            this.transform.Rotate(0.0f, 0.0f, -90.0f, Space.Self);
            //Debug.Log(this.transform.position.x);
            //Debug.Log(this.transform.position.x -0.74f);
            transform.position += new Vector3(0, 0, -0.74f);
             transform.position += new Vector3(0.76f, 0, -0.74f);
            //this.transform.position = new Vector3(this.transform.position.x + -0.74f, this.transform.position.y, this.transform.position.z);

            //this.transform.position = new Vector3(this.transform.position.x + -0.74f, this.transform.position.y -0.69f, this.transform.position.z);
        }
    }

      void OnTriggerExit(Collider other)
    {
        if (other.tag=="Player"){
            Debug.Log("Here in exit");
            Debug.Log(this.init_position);
            Debug.Log(this.init_rotation);
            this.transform.position = this.init_position;
            this.transform.rotation = this.init_rotation;
            this.entered = false;
         }
    }
}
