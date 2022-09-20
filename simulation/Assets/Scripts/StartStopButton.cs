using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartStopButton : MonoBehaviour
{
    public TMPro.TextMeshProUGUI buttonText;
    public static bool active = false;
    public Button button;

    public void setText() 
    {
        if (active) {
            buttonText.text = "Start Drive";
        } else {
            buttonText.text = "Finish Drive";
        }
        active = !active;
    }

    public void disableButton()
    {
        buttonText.text = "Drive in progress";
        button.interactable = false;
    }

    public void enableButton()
    {
        if (!active) {
            buttonText.text = "Start Drive";
        } else {
            buttonText.text = "Finish Drive";
        }
        button.interactable = true;
    }

    void Update() 
    {
        if (VehicleSpeedScript.vehicleSpeed >= 5) {
            disableButton();
        }
        else {
            enableButton();
        }
    }
}
