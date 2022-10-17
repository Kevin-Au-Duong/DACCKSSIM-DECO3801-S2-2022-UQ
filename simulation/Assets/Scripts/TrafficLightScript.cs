using UnityEngine;
using System.Collections.Generic;

public class TrafficLightScript : MonoBehaviour
{
    // Enum representing the light states
    public enum LightState
    {
        Yellow = 0,
        Red = 1,
        Green = 2
    };

    public LightState currentState; // Current state of light

    // Mapping structure that stores light type and duration
    public Dictionary<string, float> lightTimes = new Dictionary<string, float>()
    {
        { "Yellow", 5F },
        { "Red", 10F },
        { "Green", 20F }
    };
    private float timeStamp; // General time stamp variable used to keep track of the light duration
    Renderer rend; // Renderer of the object that this is attached to
    Material[] materials; // List of materials of the object that this is attached to

    void Start()
    {
        rend = GetComponent<Renderer>();
        materials = rend.materials;
        SetLight(LightState.Red, Color.red);
        timeStamp = Time.time + lightTimes["Red"];
    }

    void Update()
    {
        // Changes the color of the light depending on light duration
        
        if (Time.time > timeStamp) // If current light duration is up
        {
            materials[(int)currentState].color = Color.black;

            switch (currentState)
            {
                case LightState.Yellow:
                    SetLight(LightState.Red, Color.red);
                    break;
                case LightState.Red:
                    SetLight(LightState.Green, Color.green);
                    break;
                case LightState.Green:
                    SetLight(LightState.Yellow, Color.yellow);
                    break;
            }
        }
    }

    private void SetLight(LightState newState, Color newColor)
    {
        // Set the light to a new state, color and set duration of next light

        currentState = newState;
        materials[(int)currentState].color = newColor;

        switch (currentState)
        {
            case LightState.Yellow:
                timeStamp = Time.time + lightTimes["Yellow"];
                break;
            case LightState.Red:
                timeStamp = Time.time + lightTimes["Red"];
                break;
            case LightState.Green:
                timeStamp = Time.time + lightTimes["Green"];
                break;
        }
    }
}
