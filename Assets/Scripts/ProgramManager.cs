using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = System.Random;

public class ProgramManager : MonoBehaviour
{
   [SerializeField] private Mesh[] tileSizeOptions;
   [SerializeField] private GameObject tileSample;
   [SerializeField] private GameObject tileOptionsWindow;
   
   [SerializeField] private Material[] deskMaterialOptions;
   [SerializeField] private GameObject desk1;
   [SerializeField] private GameObject desk2;

   private MeshFilter tileMeshFilter;
   private List<MeshCollider> tileMeshColliders;
   
   private int desk1MaterialIndex = 0;
   private int desk2MaterialIndex = 0;
   
   public void Start()
   {
       tileOptionsWindow.SetActive(false);
       tileMeshFilter = tileSample.GetComponent<MeshFilter>();
       tileMeshColliders = new List<MeshCollider>(tileSample.GetComponents<MeshCollider>());
       
   }

   public void TileSizeChange(int index)
   {
       tileMeshFilter.mesh = tileSizeOptions[index];
       foreach (MeshCollider meshCollider in tileMeshColliders)
       { 
           meshCollider.sharedMesh = tileSizeOptions[index];
       }
   }
   
   public void OpenTileWindow()
   {
       tileOptionsWindow.SetActive(true);
   }

   public void CloseTileWindow()
   {
       tileOptionsWindow.SetActive(false);
   }
   
   public void Desk1MaterialChange()
   {
       desk1.GetComponent<Renderer>().material = deskMaterialOptions[desk1MaterialIndex];
       desk1MaterialIndex = (desk1MaterialIndex + 1) % deskMaterialOptions.Length;
   }

   public void Desk2MaterialChange()
   {
       desk2.GetComponent<Renderer>().material = deskMaterialOptions[desk1MaterialIndex];
       desk1MaterialIndex = (desk1MaterialIndex + 1) % deskMaterialOptions.Length;
   }
   

}
