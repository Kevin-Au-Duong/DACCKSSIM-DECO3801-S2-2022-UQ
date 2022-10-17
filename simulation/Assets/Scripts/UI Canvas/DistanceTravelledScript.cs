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
