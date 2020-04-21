using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public Transform theDest;
    public string impact = "255";
    public UnityHapticGlove Uglove;
    void OnMouseDown()
    {
        GetComponent<Rigidbody>().useGravity = false;
        this.transform.position = theDest.position;
        this.transform.parent = GameObject.Find("Destination").transform;
        Uglove.ActivateMotorRing(impact);
        Uglove.ActivateMotorIndex(impact);
        Uglove.ActivateMotorMiddle(impact);
        Uglove.ActivateMotorPinky(impact);
        Uglove.ActivateMotorThumb(impact);

    }
    
    void OnMouseUp()
    {
        Uglove.DeactivateMotorRing();
        Uglove.DeactivateMotorIndex();
        Uglove.DeactivateMotorMiddle();
        Uglove.DeactivateMotorPinky();
        Uglove.DeactivateMotorThumb();

        this.transform.parent = null;
        GetComponent<Rigidbody>().useGravity = true;
        
    }
}
