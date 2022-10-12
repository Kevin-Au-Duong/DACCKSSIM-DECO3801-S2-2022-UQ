using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using System.IO;
using System.Linq;

public class StartStopButton : MonoBehaviour
{
    public TMPro.TextMeshProUGUI buttonText;
    public static bool active = false;
    public Button button;
    public System.DateTime startDrive;

    public void toggleDrive() 
    {
        if (active) {
            buttonText.text = "Start Drive";

            string path = getAndroidExternalStoragePath() + "/Documents/DACCKSCAM";
            Directory.CreateDirectory(path);
            path += "/save.txt";

            string content = startDrive + ","
            + System.DateTime.Now + ","
            + VehicleSpeedScript.distanceTravelled + ","
            + (System.DateTime.Now - startDrive) + ",";

            File.AppendAllText(path, content);

            foreach (string key in RulesBrokenScript.keys) {
                if (key.Equals(RulesBrokenScript.keys.Last())) {
                    File.AppendAllText(path, key + ":" + RulesBrokenScript.rulesBrokenType[key] + "\n");
                } else {
                    File.AppendAllText(path, key + ":" + RulesBrokenScript.rulesBrokenType[key] + ",");
                }
                RulesBrokenScript.rulesBrokenType[key] = 0;
            }

            VehicleSpeedScript.distanceTravelled = 0;
            VehicleSpeedScript.speedLimitActive = false;
            RulesBrokenScript.rulesBroken = 0;
        } else {
            buttonText.text = "Finish Drive";
            startDrive = System.DateTime.Now;
        }
        active = !active;
    }

    public string getAndroidExternalStoragePath()
    {
        {
            string path = "";
            try {
                AndroidJavaClass jc = new AndroidJavaClass("android.os.Environment");
                path = jc.CallStatic<AndroidJavaObject>("getExternalStorageDirectory").Call<string>("getAbsolutePath");
                return path;
            }
            catch (Exception e) {
                Debug.Log(e.Message);
            }
            return path;
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
