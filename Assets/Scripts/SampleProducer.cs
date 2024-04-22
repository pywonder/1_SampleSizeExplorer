using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SampleProducer : MonoBehaviour
{
    [SerializeField] private List<GameObject> _tileOptions;

    [SerializeField] private GameObject _metal;
    [SerializeField] private List<Material> _metalFinishOptions;


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
}