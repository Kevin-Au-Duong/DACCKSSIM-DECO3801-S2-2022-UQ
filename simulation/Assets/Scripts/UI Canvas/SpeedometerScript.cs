using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedometerScript : MonoBehaviour
{
    TMPro.TextMeshProUGUI vehicleSpeedText;
    
    void Start()
    {
        vehicleSpeedText = GetComponent<TMPro.TextMeshProUGUI>();
    }

    void Update()
    {
        vehicleSpeedText.text = "Speed : " + VehicleSpeedScript.vehicleSpeed + " km/h";
    }
}
