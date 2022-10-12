using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedTrigger80 : MonoBehaviour
{
    private void OnTriggerEnter(Collider coll)
    {
        if (StartStopButton.active) {
            VehicleSpeedScript.speedLimitActive = true;
        }
        VehicleSpeedScript.speedLimit = 80;
    }
}
