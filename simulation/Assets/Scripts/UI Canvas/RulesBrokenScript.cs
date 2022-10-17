using System.Collections.Generic;
using UnityEngine;

public class RulesBrokenScript : MonoBehaviour
{
    // Mapping structure that stores violation type and count
    public static Dictionary<string, int> rulesBrokenType = new Dictionary<string, int>()
    {
        { "Speeding", 0 },
        { "Stop Sign", 0 },
        { "Jumping Red Light", 0 }
    };
    public static List<string> keys = new List<string>(rulesBrokenType.Keys); // List of keys of mapping structure`
    public static int rulesBroken = 0; // Number of total violations
    TMPro.TextMeshProUGUI rulesBrokenText; // Text component of object that this is attached to

    void Start()
    {
        rulesBrokenText = GetComponent<TMPro.TextMeshProUGUI>();
    }

    void Update()
    {
        rulesBrokenText.text = "Rules Broken : " + rulesBroken;
    }
}
