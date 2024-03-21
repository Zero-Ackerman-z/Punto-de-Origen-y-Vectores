using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformComparison : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Global Position: " + transform.position);
        Debug.Log("Local Position: " + transform.localPosition);

        Debug.Log("Global Scale: " + transform.lossyScale);
        Debug.Log("Local Scale: " + transform.localScale);

        Debug.Log("Global Rotation: " + transform.rotation.eulerAngles);
        Debug.Log("Local Rotation: " + transform.localRotation.eulerAngles);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
