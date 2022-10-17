using UnityEngine;

public class SpeedTrigger : MonoBehaviour
{
    public int speedLimit; // Speed limit of this zone
    private void OnTriggerEnter(Collider coll)
    {
        if (StartStopButton.active)
        {
            VehicleSpeedScript.speedLimitActive = true;
        }
        VehicleSpeedScript.speedLimit = speedLimit;
    }
}
