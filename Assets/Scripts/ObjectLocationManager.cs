using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectLocationManager : MonoBehaviour
{
    [SerializeField] private GameObject centerEyeAhcnor;
    [SerializeField] private GameObject[] allSamples;
        
        
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        foreach (GameObject sample in allSamples)
        {
            if (sample != null)
            {
                // Set the rotation to (0, 0, 0)
                sample.transform.rotation = Quaternion.Euler(Vector3.zero);
            }
        }
    }
}

