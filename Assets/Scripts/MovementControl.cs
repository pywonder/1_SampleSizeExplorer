using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementControl : MonoBehaviour
{
    [SerializeField] private GameObject allBaseModels;
    [SerializeField] private GameObject centerCameraAnchor;
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (allBaseModels != null)
        {
            // Set the rotation to (0, 0, 0)
            allBaseModels.transform.rotation = Quaternion.Euler(Vector3.zero);
        }
        
        
    }
}
