using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedTrigger80 : MonoBehaviour
{
    private void OnTriggerEnter(Collider coll)
    {
        //Debug.Log("Trigger!");
        Debug.Log(VehicleSpeedScript.vehicleSpeed);
        if (VehicleSpeedScript.vehicleSpeed > 80 && StartStopButton.active)
            RulesBrokenScript.rulesBroken += 1;
    }
}
