using System.Collections;
using UnityEngine;

public class VehicleSpeedScript : MonoBehaviour
{
    public static float vehicleSpeed; // Speed of the vehicle object
    public static float distanceTravelled; // Distance that vehicle has travelled
    public static int speedLimit; // Speed limit of the zone that the vehicle is in
    public static bool speedLimitActive = false; // Whether the speed limit is active or not
    private float msToKmh = 3.6F; // Metres per second to kilometres per hour conversion number

    void Start()
    {
        StartCoroutine(CalcSpeed());
    }

    IEnumerator CalcSpeed()
    {
        // This constantly calculates the speed of the vehicle and the distance that it has travelled
        //
        // Speed is always calculated but distance is only calculated when the start/stop
        // button has been pressed
        //
        // This part also handles the case when the speed of the car
        // exceeds the speed limit

        bool isPlaying = true;

        while (isPlaying)
        {
            Vector3 prevPos = transform.position;

            yield return new WaitForFixedUpdate();

            if (StartStopButton.active)
            {
                distanceTravelled += Vector3.Distance(transform.position, prevPos);
                if (vehicleSpeed > speedLimit && speedLimitActive)
                {
                    RulesBrokenScript.rulesBroken += 1;
                    RulesBrokenScript.rulesBrokenType["Speeding"] += 1;
                    speedLimitActive = !speedLimitActive;
                }
            }

            vehicleSpeed = Mathf.RoundToInt(
                msToKmh * (Vector3.Distance(transform.position, prevPos) / Time.fixedDeltaTime)
            );
        }
    }
}
