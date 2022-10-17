using UnityEngine;

public class SpeedLimitScript : MonoBehaviour
{
    TMPro.TextMeshProUGUI speedLimitText; // Text component of object that this is attached to

    void Start()
    {
        speedLimitText = GetComponent<TMPro.TextMeshProUGUI>();
    }

    void Update()
    {
        speedLimitText.text = "Speed Limit : " + VehicleSpeedScript.speedLimit + " km/h";
        if (VehicleSpeedScript.speedLimitActive)
        {
            speedLimitText.color = Color.green;
        }
        else
        {
            speedLimitText.color = Color.red;
        }
    }
}
