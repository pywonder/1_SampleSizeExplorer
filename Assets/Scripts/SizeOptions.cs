using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SizeOptions : MonoBehaviour
{
    [SerializeField] private GameObject _sizeOptionsWindow;

    public void OpenSizeOptionsWindow()
    {
        _sizeOptionsWindow.SetActive(true);
    }
    
    // Start is called before the first frame update
    void Start()
    {
        _sizeOptionsWindow.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
