using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DistanceTravelledScript : MonoBehaviour
{
    TMPro.TextMeshProUGUI distanceTravelledText;

    // Start is called before the first frame update
    void Start()
    {
        distanceTravelledText = GetComponent<TMPro.TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        distanceTravelledText.text = "Distance : " + VehicleSpeedScript.distanceTravelled + " meters";
    }
}
