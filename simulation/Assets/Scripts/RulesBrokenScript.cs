using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RulesBrokenScript : MonoBehaviour
{
    public static int rulesBroken = 0;
    TMPro.TextMeshProUGUI rulesBrokenText; 
    // Start is called before the first frame update
    void Start()
    {
        rulesBrokenText = GetComponent<TMPro.TextMeshProUGUI> ();
    }

    // Update is called once per frame
    void Update()
    {
        rulesBrokenText.text = "Rules Broken : " + rulesBroken;
    }
}
