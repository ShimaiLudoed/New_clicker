using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class ShopManager : MonoBehaviour
{
    public TMP_Text IronUI;
    public TMP_Text WoolUI;
    public TMP_Text WoodUI;
    public TMP_Text RockUI;
    public ShopItem[] shopItems;
    //public GameObject[] shopPanelsGO;
    public ShopTemplate[] shopPanels;
    public Button[] Mypurch;
    public int Woodclick = 1;
    public int RockClick = 1;
    public int WoolClick = 1;
    public int IronClick = 1;
    
  
  
    void Start()
    {
        for (int i = 0; i < shopItems.Length; i++)
        {
            shopPanels[i].gameObject.SetActive(true);
        }
        WoolUI.text = "wools" + ResourceBank.Instance.wool.ToString();
        IronUI.text = "irons" + ResourceBank.Instance.wood.ToString();
        WoodUI.text = "woods" + ResourceBank.Instance.wood.ToString();
        RockUI.text = "rocks" + ResourceBank.Instance.rock.ToString();
        
        loadpanels();
        CheckPurchare();
    }

    public void AddIron()
    {
        ResourceBank.Instance.iron += IronClick;
        IronUI.text = "irons" + ResourceBank.Instance.iron.ToString();
    }

    public void AddWool()
    {
        ResourceBank.Instance.wool += WoolClick;
        WoolUI.text = "wools" + ResourceBank.Instance.wool.ToString();
        CheckPurchare();
    }

    public void AddRock()
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
            
            if (ResourceBank.Instance.rock >= shopItems[i].rockCost& ResourceBank.Instance.wood >= shopItems[i].woodCost & ResourceBank.Instance.wool>= shopItems[i].woolCost & ResourceBank.Instance.iron>=shopItems[i].ironCost)
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
        if (ResourceBank.Instance.rock >= shopItems[btnNO].rockCost & ResourceBank.Instance.wood >= shopItems[btnNO].woodCost & ResourceBank.Instance.wool>= shopItems[btnNO].woolCost & ResourceBank.Instance.iron>=shopItems[btnNO].ironCost)
        {
            ResourceBank.Instance.iron -= shopItems[btnNO].ironCost;
            ResourceBank.Instance.wool -= shopItems[btnNO].woolCost;
            ResourceBank.Instance.wood -= shopItems[btnNO].woodCost;
            ResourceBank.Instance.rock -= shopItems[btnNO].rockCost;
            
            if (shopItems[btnNO].Title == "WoodUpg")
            {
                Woodclick++;
            }
            if (shopItems[btnNO].Title == "rockUPG")
            {
                shopItems[btnNO].RockproductivityIncrease++;
            }
            if (shopItems[btnNO].Title == "IronUPG")
            {
                shopItems[btnNO].IronproductivityIncrease++;
            }
            if (shopItems[btnNO].Title=="WoolUPG")
            {
                shopItems[btnNO].WoolproductivityIncrease++;
            }

            WoolClick += shopItems[btnNO].WoolproductivityIncrease;
            IronClick += shopItems[btnNO].IronproductivityIncrease;
            Woodclick += shopItems[btnNO].WoodproductivityIncrease;
            RockClick += shopItems[btnNO].RockproductivityIncrease;
            
            WoolUI.text = "wools" + ResourceBank.Instance.wool.ToString();
            IronUI.text = "irons" + ResourceBank.Instance.iron.ToString();
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
            shopPanels[i].ironTxt.text = "irons" + shopItems[i].ironCost.ToString();
            shopPanels[i].woolTxt.text = "wools" + shopItems[i].woolCost.ToString();
        }
    }
}
