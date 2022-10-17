using UnityEngine;
using UnityEngine.UI;
using System;
using System.IO;
using System.Linq;

public class StartStopButton : MonoBehaviour
{
    public TMPro.TextMeshProUGUI buttonText; // Text component of the object that this is attached to
    public static bool active = false; // Whether the drive details are currently being recorded
    public Button button; // Button component of object that this is attached to
    private System.DateTime startDrive; // Start time of the recording

    private void toggleDrive()
    {
        // This handles the functionality of the button

        if (active) // If press "Stop Drive"
        {
            // Output relevant data to a designated directory
            buttonText.text = "Start Drive";

            string path = getAndroidExternalStoragePath() + "/Documents/DACCKSCAM";
            Directory.CreateDirectory(path);
            path += "/save.txt";

            // Format data for frontend parsing
            string content =
                startDrive + ","
                + System.DateTime.Now + ","
                + VehicleSpeedScript.distanceTravelled + ","
                + (System.DateTime.Now - startDrive) + ",";

            File.AppendAllText(path, content);

            foreach (string key in RulesBrokenScript.keys)
            {
                if (key.Equals(RulesBrokenScript.keys.Last()))
                {
                    File.AppendAllText(
                        path,
                        key + ":" + RulesBrokenScript.rulesBrokenType[key] + "\n"
                    );
                }
                else
                {
                    File.AppendAllText(
                        path,
                        key + ":" + RulesBrokenScript.rulesBrokenType[key] + ","
                    );
                }

                RulesBrokenScript.rulesBrokenType[key] = 0;
            }

            // Reset variables
            VehicleSpeedScript.distanceTravelled = 0;
            VehicleSpeedScript.speedLimitActive = false;
            RulesBrokenScript.rulesBroken = 0;
        }
        else // If press "Start Drive"
        {
            buttonText.text = "Finish Drive";
            startDrive = System.DateTime.Now;
        }

        active = !active;
    }

    private string getAndroidExternalStoragePath()
    {
        // Getter function to retrieve the external storage path of an Android system

        string path = "";

        try
        {
            AndroidJavaClass jc = new AndroidJavaClass("android.os.Environment");
            path = jc.CallStatic<AndroidJavaObject>("getExternalStorageDirectory")
                .Call<string>("getAbsolutePath");
            return path;
        }
        catch (Exception e)
        {
            //Debug.Log(e.Message);
        }

        return path;
    }

    private void disableButton()
    {
        // Disables the button and changes text

        buttonText.text = "Drive in progress";
        button.interactable = false;
    }

    private void enableButton()
    {
        // Enables the button amd changes text

        if (!active)
        {
            buttonText.text = "Start Drive";
        }
        else
        {
            buttonText.text = "Finish Drive";
        }

        button.interactable = true;
    }

    void Update()
    {
        // Calls disableButton or enableButton depending on the vehicle speed
        
        if (VehicleSpeedScript.vehicleSpeed >= 5)
        {
            disableButton();
        }
        else
        {
            enableButton();
        }
    }
}
