using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedLimitScript : MonoBehaviour
{
    TMPro.TextMeshProUGUI speedLimitText;

    void Start()
    {
        speedLimitText = GetComponent<TMPro.TextMeshProUGUI>();
    }

    void Update()
    {   
        speedLimitText.text = "Speed Limit : " + VehicleSpeedScript.speedLimit + " km/h";
        if (VehicleSpeedScript.speedLimitActive) {
            speedLimitText.color = Color.green;
        } else {
            speedLimitText.color = Color.red;
        }
    }
    
}
