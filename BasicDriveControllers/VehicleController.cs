using System.Collections;
using System.Collections.Generic;
using System.Timers;
using UnityEngine;

public class VehicleController : MonoBehaviour
    //Customized for SS 774 Mine Warfare Proto.
{    
    void Start()
    {
        
    }

    void Update()
    {
        //Move sub ahead full (1 meter/sec). AWSD and arrow keys.
        transform.Translate(Vector3.forward * Time.deltaTime * 20);
    }
}
