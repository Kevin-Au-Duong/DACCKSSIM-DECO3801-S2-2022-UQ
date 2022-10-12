using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopTrigger : MonoBehaviour
{
    public bool vehicleStopped = false;
    public bool stopTriggerActive = false;
    private void OnTriggerEnter(Collider coll)
    {
        if (StartStopButton.active) {
            stopTriggerActive = true;
        }
    }

    void Update()
    {
        if (stopTriggerActive && VehicleSpeedScript.vehicleSpeed == 0) {
            vehicleStopped = true;
        }
    }

    private void OnTriggerExit(Collider coll)
    {
        if (stopTriggerActive && !vehicleStopped) {
            RulesBrokenScript.rulesBroken += 1;
            RulesBrokenScript.rulesBrokenType["Stop Sign"] += 1;
            stopTriggerActive = !stopTriggerActive;
        }
    }
}
