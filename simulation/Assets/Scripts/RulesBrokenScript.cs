using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RulesBrokenScript : MonoBehaviour
{
    public static Dictionary<string, int> rulesBrokenType = new Dictionary<string, int>()
    {
        {"Speeding", 0}
    };
    public static int rulesBroken = 0;
    TMPro.TextMeshProUGUI rulesBrokenText; 

    void Start()
    {
        rulesBrokenText = GetComponent<TMPro.TextMeshProUGUI> ();
    }

    void Update()
    {
        rulesBrokenText.text = "Rules Broken : " + rulesBroken;
    }
}
