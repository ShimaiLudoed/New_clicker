using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class ShopManager : MonoBehaviour
{
    public TMP_Text WoodUI;
    public TMP_Text RockUI;
    public ShopItem[] shopItems;
    //public GameObject[] shopPanelsGO;
    public ShopTemplate[] shopPanels;
    public Button[] Mypurch;
    public int Woodclick = 1;
    public int RockClick = 1;
    
  
    void Start()
    {
        for (int i = 0; i < shopItems.Length; i++)
        
            shopPanels[i].gameObject.SetActive(true);

        WoodUI.text = "woods" + ResourceBank.Instance.wood.ToString();
        RockUI.text = "rocks" + ResourceBank.Instance.rock.ToString();
        loadpanels();
        CheckPurchare();
    }

    public void AddCoin()
    {
        
        ResourceBank.Instance.rock+=RockClick;
        RockUI.text = "rocks" + ResourceBank.Instance.rock.ToString();
        CheckPurchare() ;
         

    }

    public void AddWood()
    {
       
        ResourceBank.Instance.wood+=Woodclick;
        WoodUI.text="woods"+ ResourceBank.Instance.wood.ToString();
        CheckPurchare();
    }

    public void CheckPurchare()
    {
       for(int i = 0;i<shopItems.Length;i++)
        {
            
            if (ResourceBank.Instance.rock >= shopItems[i].rockCost& ResourceBank.Instance.wood >= shopItems[i].woodCost)
            {
                Mypurch[i].interactable = true;
            }
            else
            {
                Mypurch[i].interactable = false;
            }
        }
    }

    public void PurchItem(int btnNO)
    {
        if (ResourceBank.Instance.rock >= shopItems[btnNO].rockCost && ResourceBank.Instance.wood >= shopItems[btnNO].woodCost)
        {
         
            ResourceBank.Instance.wood -= shopItems[btnNO].woodCost;
            ResourceBank.Instance.rock-= shopItems[btnNO].rockCost;
            if (shopItems[btnNO].Title == "woodUPG")
            {
                shopItems[btnNO].productivityIncreaseWood++;
            }
            if (shopItems[btnNO].Title == "rockUPG")
            {
                shopItems[btnNO].productivityIncreaseRock++;
            }
            Woodclick += shopItems[btnNO].productivityIncreaseWood;
            RockClick += shopItems[btnNO].productivityIncreaseRock;
            WoodUI.text = "woods" + ResourceBank.Instance.wood.ToString();
            RockUI.text = "rocks" + ResourceBank.Instance.rock.ToString();
            CheckPurchare();
        }
    }

    
    void Update()
    {
        
    }

    public void loadpanels ()
    {
        for (int i = 0; i < shopItems.Length; i++)
        {
            shopPanels[i].titleText.text = shopItems[i].Title;
            shopPanels[i].DescriptionTXT.text = shopItems[i].description;
            shopPanels[i].rockTxt.text = "rocks" + shopItems[i].rockCost.ToString();
            shopPanels[i].woodTxt.text = "woods" + shopItems[i].woodCost.ToString();
        }
    }
}
