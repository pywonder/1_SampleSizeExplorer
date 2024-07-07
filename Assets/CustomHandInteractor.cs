using System.Collections;
using System.Collections.Generic;
using Oculus.Interaction.HandGrab;
using Unity.VisualScripting;
using UnityEngine;

public class CustomHandInteractor : HandGrabInteractor
{
    [SerializeField] private GameObject panelSmall;
    [SerializeField] private GameObject panelMedium;
    [SerializeField] private GameObject panelLarge;

    private Vector3 panelSmallOriginalPosition;
    private Vector3 panelMediumOriginalPosition;
    private Vector3 panelLargeOriginalPosition;
    
    private Quaternion panelSmallOriginalRotation;
    private Quaternion panelMediumOriginalRotation;
    private Quaternion panelLargeOriginalRotation;
    

    private void Start()
    {
        panelSmallOriginalPosition = panelSmall.transform.position;
        panelMediumOriginalPosition = panelMedium.transform.position;
        panelLargeOriginalPosition = panelLarge.transform.position;
        
        panelSmallOriginalRotation = panelSmall.transform.rotation;
        panelMediumOriginalRotation = panelMedium.transform.rotation;
        panelLargeOriginalRotation = panelLarge.transform.rotation;
    }
    
    protected override void InteractableUnselected(HandGrabInteractable interactable)
    {
        base.InteractableUnselected(interactable);
        ReturnToOriginalPosition();
    }

    private void ReturnToOriginalPosition()
    {
        Debug.Log("Return To Original Position");

        // Set panelSmall position and rotation
        Vector3 smallPosition = panelSmallOriginalPosition;
        smallPosition.y = 0.8f;
        smallPosition.z -= 0.2f;
        panelSmall.transform.position = smallPosition;
        panelSmall.transform.rotation = panelSmallOriginalRotation;

        // Set panelMedium position and rotation
        Vector3 mediumPosition = panelMediumOriginalPosition;
        mediumPosition.y = 0.8f;
        mediumPosition.z -= 0.2f;
        panelMedium.transform.position = mediumPosition;
        panelMedium.transform.rotation = panelMediumOriginalRotation;

        // Set panelLarge position and rotation
        Vector3 largePosition = panelLargeOriginalPosition;
        largePosition.y = 0.8f;
        largePosition.z -= 0.2f;
        panelLarge.transform.position = largePosition;
        panelLarge.transform.rotation = panelLargeOriginalRotation;
    }
}
