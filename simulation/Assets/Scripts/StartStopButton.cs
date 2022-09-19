using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartStopButton : MonoBehaviour
{
    public TMPro.TextMeshProUGUI buttonText;
    public static bool active = false;

    public void setText() 
    {
        if (active) {
            buttonText.text = "Start Drive";
        } else {
            buttonText.text = "Finish Drive";
        }
        active = !active;
    }
}
