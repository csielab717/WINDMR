using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationDetect : MonoBehaviour
{
    GameObject knobObject;
    Quaternion tr;

    // Start is called before the first frame update
    void Start()
    {
        knobObject = GameObject.Find("knob");

    }

    // Update is called once per frame
    void Update()
    {
        tr = knobObject.GetComponent<Transform>().rotation;
        //if(tr.eulerAngles.z != 0)
        //{
        //    Debug.Log(tr.eulerAngles.z);
        //}
        if (tr.eulerAngles.z != 0)
        {

            float speed = tr.eulerAngles.z / 10;
            transform.Rotate(speed, 0, 0);
        }
    }
}
