using UnityEngine;

public class LightTrigger : MonoBehaviour
{
    private void OnTriggerExit(Collider coll)
    {
        GameObject light = this.transform.parent.gameObject; // Get the parent object of this object

        if (
            StartStopButton.active
            && light.GetComponent<TrafficLightScript>().currentState
                == TrafficLightScript.LightState.Red
        )
        {
            RulesBrokenScript.rulesBroken += 1;
            RulesBrokenScript.rulesBrokenType["Jumping Red Light"] += 1;
        }
    }
}
