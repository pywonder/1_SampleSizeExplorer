using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SampleProducer : MonoBehaviour
{
    [SerializeField] private List<GameObject> _tileOptions;

    [SerializeField] private GameObject _metal;
    [SerializeField] private List<Material> _metalFinishOptions;

    [SerializeField] private GameObject _wood;
    [SerializeField] private List<Material> _woodFinishOptions;

    [SerializeField] private GameObject _Desk1;
    [SerializeField] private GameObject _Desk2;
    [SerializeField] private List<Material> _deskFinishOptions;
    
    public void TileOptionChange(int index)
    {
        foreach (var opt in _tileOptions)
        {
            opt.SetActive(false);
        }

        _tileOptions[index].SetActive(true);
    }

    public void MetalMaterialChange(int index)
    {
        if (index >= 0 && index < _metalFinishOptions.Count)
        {
            Renderer metalRenderer = _metal.GetComponent<Renderer>();

            if (metalRenderer != null)
            {
                metalRenderer.material = _metalFinishOptions[index];
            }
        }
    }
    public void WoodMaterialChange(int index)
    {
        if (index >= 0 && index < _metalFinishOptions.Count)
        {
            Renderer metalRenderer = _wood.GetComponent<Renderer>();

            if (metalRenderer != null)
            {
                metalRenderer.material = _woodFinishOptions[index];
            }
        }
    }
    
    public void Desk1MaterialChange(int index)
    {
        if (index >= 0 && index < _metalFinishOptions.Count)
        {
            Renderer metalRenderer = _Desk1.GetComponent<Renderer>();

            if (metalRenderer != null)
            {
                metalRenderer.material = _deskFinishOptions[index];
            }
        }
    }
    
    public void Desk2MaterialChange(int index)
    {
        if (index >= 0 && index < _metalFinishOptions.Count)
        {
            Renderer metalRenderer = _Desk2.GetComponent<Renderer>();

            if (metalRenderer != null)
            {
                metalRenderer.material = _deskFinishOptions[index];
            }
        }
    }
    
}