using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedometerScript : MonoBehaviour
{
    TMPro.TextMeshProUGUI vehicleSpeedText;
    
    // Start is called before the first frame update
    void Start()
    {
        vehicleSpeedText = GetComponent<TMPro.TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        vehicleSpeedText.text = "Speed : " + VehicleSpeedScript.vehicleSpeed + " km/h";
    }
}
