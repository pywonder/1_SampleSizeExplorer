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

   [SerializeField] private GameObject topView;
   
   [SerializeField] private Material[] walltileMaterialOptions;
   [SerializeField] private GameObject walltileSample;
   [SerializeField] private GameObject wallTileOptionsWindow;
   
   private MeshFilter tileMeshFilter;
   private List<MeshCollider> tileMeshColliders;
   
   private int desk1MaterialIndex = 0;
   private int desk2MaterialIndex = 0;
   private bool accentTileWindowOpen = false;
   private bool TileWindowOpen = false;
   
   public void Start()
   {
       tileOptionsWindow.SetActive(false);
       tileMeshFilter = tileSample.GetComponent<MeshFilter>();
       tileMeshColliders = new List<MeshCollider>(tileSample.GetComponents<MeshCollider>());
       
       wallTileOptionsWindow.SetActive(false);
       topView.SetActive(false);
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
       if (accentTileWindowOpen)
       {
           tileOptionsWindow.SetActive(false);
           accentTileWindowOpen = false;
       }
       else
       {
           tileOptionsWindow.SetActive(true);
           accentTileWindowOpen = true;
       }
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
   
   public void WallTileMaterialBlue()
   {
       walltileSample.GetComponent<Renderer>().material = walltileMaterialOptions[1];
   }
   
   public void WallTileMaterialGreen()
   {
       walltileSample.GetComponent<Renderer>().material = walltileMaterialOptions[0];
   }

   public void OpenWallTileWindow()
   {
       if (TileWindowOpen)
       {
           wallTileOptionsWindow.SetActive(false);
           TileWindowOpen = false;
       }
       else
       {
           wallTileOptionsWindow.SetActive(true);
           TileWindowOpen = true;
       }
   }
   
   public void TopViewOn()
   {
       topView.SetActive(true);
   }
   
   
}
