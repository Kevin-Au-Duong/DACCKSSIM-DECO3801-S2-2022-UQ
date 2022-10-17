using UnityEngine;
using UnityEngine.EventSystems;

// Edited version of AxisTouchButton.cs in Assets\Asset Store\Standard Assets\CrossPlatformInput\Scripts\
// Designed to work with VehicleStandardInput.cs in Assets\Asset Store\EVP5\Scripts\

namespace UnityStandardAssets.CrossPlatformInput
{
    public class BrakeSteerButtons : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
    {
        public string axisName; // The name of the axis
        public float axisValue = 1; // The axis that the value has
        public float responseSpeed; // The speed at which the axis touch button responds
        public float returnToCentreSpeed; // The speed at which the button will return to its centre

        CrossPlatformInputManager.VirtualAxis m_Axis; // A reference to the virtual axis as it is in the cross platform input

        void OnEnable()
        {
            if (!CrossPlatformInputManager.AxisExists(axisName))
            {
                // if the axis doesnt exist create a new one in cross platform input
                m_Axis = new CrossPlatformInputManager.VirtualAxis(axisName);
                CrossPlatformInputManager.RegisterVirtualAxis(m_Axis);
            }
            else
            {
                m_Axis = CrossPlatformInputManager.VirtualAxisReference(axisName);
            }
        }

        void OnDisable()
        {
            // The object is disabled so remove it from the cross platform input system
            m_Axis.Remove();
        }

        public void OnPointerDown(PointerEventData data)
        {
            // update the axis and record that the button has been pressed this frame
            m_Axis.Update(Mathf.MoveTowards(m_Axis.GetValue, axisValue, responseSpeed * Time.deltaTime));
        }


        public void OnPointerUp(PointerEventData data)
        {
            m_Axis.Update(Mathf.MoveTowards(m_Axis.GetValue, 0, responseSpeed * Time.deltaTime));
        }
    }
}
