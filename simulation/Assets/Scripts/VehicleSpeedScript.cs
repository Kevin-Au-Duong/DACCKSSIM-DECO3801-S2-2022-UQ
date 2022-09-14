using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VehicleSpeedScript : MonoBehaviour
{
    public static float vehicleSpeed;
    public static float distanceTravelled;
    public float msToKmh = 3.6F;

    // Start is called before the first frame
    void Start()
    {
        StartCoroutine(CalcSpeed());
    }

    IEnumerator CalcSpeed()
    {
        bool isPlaying = true;

        while (isPlaying)
        {
            Vector3 prevPos = transform.position;

            yield return new WaitForFixedUpdate();
            
            distanceTravelled += Vector3.Distance(transform.position, prevPos);
            vehicleSpeed = Mathf.RoundToInt(msToKmh * (Vector3.Distance(transform.position, prevPos) / Time.fixedDeltaTime));
        }
    }
}