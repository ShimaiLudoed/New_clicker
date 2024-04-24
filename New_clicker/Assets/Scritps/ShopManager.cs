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
    public ShopTemplate[] shopPanels;
    public Button[] Mypurch;
    public Click click;
    public ShipUPG ShipUpg;
    void Start()
    {
        for (int i = 0; i < shopItems.Length; i++)
        {
            shopPanels[i].gameObject.SetActive(true);
        }

        RopeUI.text = "ropes" + ResourceBank.Instance.rope.ToString();
        LeafUI.text = "leafs" + ResourceBank.Instance.leaf.ToString();
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
            
            if (ResourceBank.Instance.rock >= shopItems[i].rockCost& ResourceBank.Instance.wood >= shopItems[i].woodCost & ResourceBank.Instance.wool>= shopItems[i].woolCost & ResourceBank.Instance.iron>=shopItems[i].ironCost & ResourceBank.Instance.leaf>=shopItems[i].LeafCost & ResourceBank.Instance.rope>=shopItems[i].RopeCost)
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
        if (ResourceBank.Instance.rock >= shopItems[btnNO].rockCost & ResourceBank.Instance.wood >= shopItems[btnNO].woodCost & ResourceBank.Instance.wool>= shopItems[btnNO].woolCost & ResourceBank.Instance.iron>=shopItems[btnNO].ironCost & ResourceBank.Instance.leaf>=shopItems[btnNO].LeafCost & ResourceBank.Instance.rope>=shopItems[btnNO].RopeCost)
        {
            ResourceBank.Instance.iron -= shopItems[btnNO].ironCost;
            ResourceBank.Instance.wool -= shopItems[btnNO].woolCost;
            ResourceBank.Instance.wood -= shopItems[btnNO].woodCost;
            ResourceBank.Instance.rock -= shopItems[btnNO].rockCost;
            ResourceBank.Instance.leaf -= shopItems[btnNO].LeafCost;
            ResourceBank.Instance.rope -= shopItems[btnNO].RopeCost;
            
            if (shopItems[btnNO].Title == "WoodUpg")
            {
                Upgrade.Instance.WoodproductivityIncrease++;
                shopItems[btnNO].woodCost *=2;
               
            }
            if (shopItems[btnNO].Title == "rockUPG")
            {
                Upgrade.Instance.RockproductivityIncrease++;
                shopItems[btnNO].rockCost *=2;
            }
            if (shopItems[btnNO].Title == "IronUPG")
            {
                Upgrade.Instance.IronproductivityIncrease++;
                shopItems[btnNO].ironCost *=2;
            }
            if (shopItems[btnNO].Title=="WoolUPG")
            {
                Upgrade.Instance.WoolproductivityIncrease++;
                shopItems[btnNO].woolCost *=2;
            }
            if (shopItems[btnNO].Title=="LeafUPG")
            {
                Upgrade.Instance.Leafprod++;
                shopItems[btnNO].LeafCost *=2;
            }
            
            WoolUI.text = "wools" + ResourceBank.Instance.wool.ToString();
            IronUI.text = "irons" + ResourceBank.Instance.iron.ToString();
            WoodUI.text = "woods" + ResourceBank.Instance.wood.ToString();
            RockUI.text = "rocks" + ResourceBank.Instance.rock.ToString();
            LeafUI.text = "leafs" + ResourceBank.Instance.leaf.ToString();
            RopeUI.text = "ropes" + ResourceBank.Instance.rope.ToString();
            CheckPurchare();
        }
    }
    void Update()
    {
        RopeUI.text = "ropes" + ResourceBank.Instance.rope.ToString();
        LeafUI.text = "leafs" + ResourceBank.Instance.leaf.ToString();
        RockUI.text = "rocks" + ResourceBank.Instance.rock.ToString();
        WoolUI.text = "wools" + ResourceBank.Instance.wool.ToString();
        WoodUI.text = "woods" + ResourceBank.Instance.wood.ToString();
        IronUI.text = "irons" + ResourceBank.Instance.iron.ToString();
        CheckPurchare();
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
            shopPanels[i].leafTxt.text = "leafs" + shopItems[i].LeafCost.ToString();
            shopPanels[i].ropeTxt.text = "ropes" + shopItems[i].RopeCost.ToString();
        }
    }
}
