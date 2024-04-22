using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SampleProducer : MonoBehaviour
{
    [SerializeField] private List<GameObject> _tileOptions;
    
    public void TileOptionChange(int index)
    {
        foreach (var opt in _tileOptions)
        {
            opt.SetActive(false);
        }
        _tileOptions[index].SetActive(true);
    }

    public void CloseMenu()
    {
        gameObject.SetActive(false);
    }
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
