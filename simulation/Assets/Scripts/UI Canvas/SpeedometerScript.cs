using UnityEngine;

public class SpeedometerScript : MonoBehaviour
{
    TMPro.TextMeshProUGUI vehicleSpeedText; // Text component of object that this is attached to

    void Start()
    {
        vehicleSpeedText = GetComponent<TMPro.TextMeshProUGUI>();
    }

    void Update()
    {
        vehicleSpeedText.text = "Speed : " + VehicleSpeedScript.vehicleSpeed + " km/h";
    }
}
