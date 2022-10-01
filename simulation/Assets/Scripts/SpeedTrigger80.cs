using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedTrigger80 : MonoBehaviour
{
    private void OnTriggerEnter(Collider coll)
    {
        if (VehicleSpeedScript.vehicleSpeed > 80 && StartStopButton.active)
            RulesBrokenScript.rulesBroken += 1;
            RulesBrokenScript.rulesBrokenType["Speeding"] += 1; 
    }
}
