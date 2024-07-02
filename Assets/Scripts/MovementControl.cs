using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementControl : MonoBehaviour
{
    [SerializeField] private GameObject accentTile;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (accentTile != null)
        {
            // Set the rotation to (0, 0, 0)
            accentTile.transform.rotation = Quaternion.Euler(Vector3.zero);
        }
    }
}
