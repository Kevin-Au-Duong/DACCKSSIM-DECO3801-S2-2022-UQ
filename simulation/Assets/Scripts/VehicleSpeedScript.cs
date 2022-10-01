using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VehicleSpeedScript : MonoBehaviour
{
    public static float vehicleSpeed;
    public static float distanceTravelled;
    public float msToKmh = 3.6F;

    void Start()
    {
        StartCoroutine(CalcSpeed());
    }

    IEnumerator CalcSpeed()
    {
        bool isPlaying = true;

        while (isPlaying)
        {
            bool active = StartStopButton.active;
            Vector3 prevPos = transform.position;

            yield return new WaitForFixedUpdate();
            if (active) {
                distanceTravelled += Vector3.Distance(transform.position, prevPos);
            }
            vehicleSpeed = Mathf.RoundToInt(msToKmh * (Vector3.Distance(transform.position, prevPos) / Time.fixedDeltaTime));
        }
    }
}