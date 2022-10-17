using UnityEngine;

public class StopTrigger : MonoBehaviour
{
    private bool vehicleStopped = false; // Whether the vehicle has stopped or not
    private bool stopTriggerActive = false; // Whether the stop trigger is active or not

    private void OnTriggerEnter(Collider coll)
    {
        if (StartStopButton.active)
        {
            stopTriggerActive = true;
        }
    }

    void Update()
    {
        if (stopTriggerActive && VehicleSpeedScript.vehicleSpeed == 0)
        {
            vehicleStopped = true;
        }
    }

    private void OnTriggerExit(Collider coll)
    {
        if (stopTriggerActive && !vehicleStopped)
        {
            RulesBrokenScript.rulesBroken += 1;
            RulesBrokenScript.rulesBrokenType["Stop Sign"] += 1;
            stopTriggerActive = !stopTriggerActive;
        }
    }
}
