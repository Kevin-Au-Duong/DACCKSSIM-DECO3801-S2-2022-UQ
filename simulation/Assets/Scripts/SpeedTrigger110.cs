using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedTrigger110 : MonoBehaviour
{
    private void OnTriggerEnter(Collider coll)
    {
        (VehicleSpeedScript.speedLimit, VehicleSpeedScript.speedLimitActive) = (110, true);
    }
}
