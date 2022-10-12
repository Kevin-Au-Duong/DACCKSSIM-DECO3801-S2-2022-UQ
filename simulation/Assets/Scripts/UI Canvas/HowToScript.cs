using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HowToScript : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.K)) {
            Destroy(gameObject);
        }

    }
}
