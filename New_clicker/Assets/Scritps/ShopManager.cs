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
    public TMP_Text LeafUI;
    public TMP_Text RopeUI;
    public ShopItem[] shopItems;
    //public GameObject[] shopPanelsGO;
    public ShopTemplate[] shopPanels;
    public Button[] Mypurch;
    private Click click;
    
    void Start()
    {
        for (int i = 0; i < shopItems.Length; i++)
        {
            shopPanels[i].gameObject.SetActive(true);
        }
     
        WoodUI.text = "woods" + ResourceBank.Instance.wood.ToString();
        RockUI.text = "rocks" + ResourceBank.Instance.rock.ToString();
        WoolUI.text = "wools" + ResourceBank.Instance.wool.ToString();
        IronUI.text = "irons" + ResourceBank.Instance.iron.ToString();
        
        loadpanels();
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
                click.Woodclick++;
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

            click.WoolClick += shopItems[btnNO].WoolproductivityIncrease;
            click.IronClick += shopItems[btnNO].IronproductivityIncrease;
            click. Woodclick += shopItems[btnNO].WoodproductivityIncrease;
            click.RockClick += shopItems[btnNO].RockproductivityIncrease;
            
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
