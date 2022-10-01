using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class StartStopButton : MonoBehaviour
{
    public TMPro.TextMeshProUGUI buttonText;
    public static bool active = false;
    public Button button;
    public System.DateTime startDrive;

    public void setText() 
    {
        if (active) {
            buttonText.text = "Start Drive";
        } else {
            buttonText.text = "Finish Drive";
        }
        active = !active;
    }

    public void dataDump()
    {
        if (!active) {
            string path = Application.dataPath + "/" + startDrive.ToString("MMM-dd-yyyy hh.mm.ss") + ".txt";

            string content = "Drive Start: " + startDrive + "\n"
            + "Drive End: " + System.DateTime.Now + "\n"
            + "Distance Driven: " + VehicleSpeedScript.distanceTravelled + "\n"
            + "Time Driven: " + (System.DateTime.Now - startDrive) + "\n"
            + "Number of road rules broken: " + RulesBrokenScript.rulesBroken + "\n";

            File.AppendAllText(path, content);

            foreach(KeyValuePair<string, int> entry in RulesBrokenScript.rulesBrokenType) {
                File.AppendAllText(path, entry.Key + ": " + entry.Value);
                RulesBrokenScript.rulesBrokenType[entry.Key] = 0;
            }

            VehicleSpeedScript.distanceTravelled = 0;
            RulesBrokenScript.rulesBroken = 0;
        } else {
            startDrive = System.DateTime.Now;
        }
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
