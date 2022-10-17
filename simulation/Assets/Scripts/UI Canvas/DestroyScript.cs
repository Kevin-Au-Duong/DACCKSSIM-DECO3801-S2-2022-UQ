using UnityEngine;

public class DestroyScript : MonoBehaviour
{
    void Update()
    {
        if (Input.anyKey)
        {
            Destroy(gameObject);
        }
    }
}
