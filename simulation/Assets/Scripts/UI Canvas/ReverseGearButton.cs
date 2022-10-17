using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;
using UnityEngine.UI;

public class ReverseGearButton : MonoBehaviour
{
    public Button button; // Button component of object that this is attached to

    void Start()
    {
        button = GetComponent<Button>();
    }

    private void toggleGear()
    {
        if (AccelerateButton.axisValue == 1)
        {
            AccelerateButton.axisValue = -1;
            button.GetComponent<Image>().color = button.colors.pressedColor;
        }
        else
        {
            AccelerateButton.axisValue = 1;
            button.GetComponent<Image>().color = button.colors.normalColor;
        }
    }
}
