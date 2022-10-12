using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DistanceTravelledScript : MonoBehaviour
{
    TMPro.TextMeshProUGUI distanceTravelledText;

    void Start()
    {
        distanceTravelledText = GetComponent<TMPro.TextMeshProUGUI>();
    }

    void Update()
    {
        distanceTravelledText.text = "Distance : " + VehicleSpeedScript.distanceTravelled + " meters";
    }
}
