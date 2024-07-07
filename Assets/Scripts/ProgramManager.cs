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
   [SerializeField] private Material tileMaterial;
   [SerializeField] private Vector2 baseTextureScale = new Vector2(1.0f, 1.0f); // Base texture scale
   
   [SerializeField] private Material[] deskMaterialOptions;
   [SerializeField] private GameObject desk1;
   [SerializeField] private GameObject desk2;

   [SerializeField] private GameObject floorPattern1;
   [SerializeField] private GameObject floorPattern2;
   [SerializeField] private GameObject floorPattern1ConfirmButton;
   [SerializeField] private GameObject floorPattern2ConfirmButton;
   [SerializeField] private GameObject floorPattern1Object;
   
   [SerializeField] private GameObject topView;
   
   [SerializeField] private Material[] walltileMaterialOptions;
   [SerializeField] private GameObject walltileSample;
   [SerializeField] private GameObject wallTileOptionsWindow;
   
   [SerializeField] private GameObject metalPanels;
   [SerializeField] private GameObject metalPanelMockUp;
   private bool metalPanelIsOn = false;
   
   [SerializeField] private GameObject FinishText;
   
   private MeshFilter tileMeshFilter;
   private List<MeshCollider> tileMeshColliders;
   
   private int desk1MaterialIndex = 0;
   private int desk2MaterialIndex = 0;
   private bool accentTileWindowOpen = false;
   private bool TileWindowOpen = false;
   
   public void Start()
   {
       metalPanelMockUp.SetActive(false);
       floorPattern1ConfirmButton.SetActive(false);
       floorPattern2ConfirmButton.SetActive(false);
       floorPattern1Object.SetActive(false);
       floorPattern1.SetActive(false);
       floorPattern2.SetActive(false);
       metalPanels.SetActive(false);
       //tileOptionsWindow.SetActive(false);
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
        if (tileMaterial != null)
       {
           Vector2 textureScale = new Vector2(baseTextureScale.x * (index+1), baseTextureScale.y * 1);
           tileMaterial.mainTextureScale = textureScale;
       }
       
   }
   
   public void OpenTileWindow()
   {
       if (accentTileWindowOpen)
       {
           walltileSample.SetActive(false);
           //tileOptionsWindow.SetActive(false);
           accentTileWindowOpen = false;
       }
       else
       {
           walltileSample.SetActive(true);
           //tileOptionsWindow.SetActive(true);
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

   public void OpenMetalPanels()
   {
       if (metalPanelIsOn)
       {
           metalPanels.SetActive(false);
           metalPanelIsOn = false;
           walltileSample.SetActive(true);
           accentTileWindowOpen = true;
       }
       else
       {
           metalPanels.SetActive(true);
           metalPanelIsOn = true;
           walltileSample.SetActive(false);
           accentTileWindowOpen = false;
       }
   }
   
   public void TopViewOn()
   {
       topView.SetActive(true);
   }

   public void FloorPattern1()
   {
       floorPattern1.SetActive(true);
       floorPattern1ConfirmButton.SetActive(true);
       floorPattern2ConfirmButton.SetActive(false);
       floorPattern2.SetActive(false);
   }
   
   public void FloorPattern2()
   {
       floorPattern1.SetActive(false);
       floorPattern1ConfirmButton.SetActive(false);
       floorPattern2ConfirmButton.SetActive(true);
       floorPattern2.SetActive(true);
   }

   public void FloorPattern1Open()
   {
       floorPattern1Object.SetActive(true);
   }

   public void MockUpOn()
   {
       metalPanelMockUp.SetActive(true);
   }
}
