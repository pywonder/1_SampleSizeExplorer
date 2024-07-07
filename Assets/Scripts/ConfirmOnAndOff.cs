using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class ConfirmOnAndOff : MonoBehaviour
{
    [SerializeField] private GameObject confirmSign;
    [SerializeField] private GameObject confirmSignMetalPanel;
    private bool confirmSignisOn;
    private bool confirmSignisOnMetalPanel;
    
    [SerializeField] private GameObject completeSign;
    [SerializeField] private GameObject metalPanelTitle;
    
    [SerializeField] private GameObject PanelInfoTextSmall;
    [SerializeField] private GameObject PanelInfoTextMedium;
    [SerializeField] private GameObject PanelInfoTextLarge;
    
    [SerializeField] private GameObject ButtonTile;
    [SerializeField] private GameObject ButtonMetal;
    
    // Start is called before the first frame update
    void Start()
    {
        completeSign.SetActive(false);
        confirmSign.SetActive(false);
        confirmSignMetalPanel.SetActive(false);
        confirmSignisOn = false;
        confirmSignisOnMetalPanel = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Confirm()
    {
        if (confirmSignisOn)
        {
            confirmSign.SetActive(false);
            confirmSignisOn = false;
        }
        else
        {
            confirmSign.SetActive(true);
            confirmSignisOn = true;
        }
    }
    public void ConfirmMetalPanel()
    {
        if (confirmSignisOnMetalPanel)
        {
            confirmSignMetalPanel.SetActive(false);
            confirmSignisOnMetalPanel = false;
        }
        else
        {
            ButtonTile.SetActive(false);
            ButtonMetal.SetActive(false);
            PanelInfoTextLarge.SetActive(false);
            PanelInfoTextMedium.SetActive(false);
            PanelInfoTextSmall.SetActive(false);
            metalPanelTitle.SetActive(false);
            completeSign.SetActive(true);
            confirmSignMetalPanel.SetActive(true);
            confirmSignisOnMetalPanel = true;
        }
    }
    
}
