using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedTrigger80 : MonoBehaviour
{
    private void OnTriggerEnter(Collider coll)
    {
        (VehicleSpeedScript.speedLimit, VehicleSpeedScript.speedLimitActive) = (80, true);
    }
}
