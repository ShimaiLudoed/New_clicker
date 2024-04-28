using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.Serialization;
using UnityEngine.UI;

public class ShopManager : MonoBehaviour
{
    [FormerlySerializedAs("IronUI")] public TMP_Text ironUI;
    [FormerlySerializedAs("WoolUI")] public TMP_Text woolUI;
    [FormerlySerializedAs("WoodUI")] public TMP_Text woodUI;
    [FormerlySerializedAs("RockUI")] public TMP_Text rockUI;
    [FormerlySerializedAs("LeafUI")] public TMP_Text leafUI;
    [FormerlySerializedAs("RopeUI")] public TMP_Text ropeUI;
    public ShopItem[] shopItems;
    public ShopTemplate[] shopPanels;
    [FormerlySerializedAs("Mypurch")] public Button[] mypurch;
    public Click click;
    [FormerlySerializedAs("ShipUpg")] public ShipUpg shipUpg;
    void Start()
    {
        for (int i = 0; i < shopItems.Length; i++)
        {
            shopPanels[i].gameObject.SetActive(true);
        }

        ropeUI.text = "ropes" + ResourceBank.Instance.Rope.ToString();
        leafUI.text = "leafs" + ResourceBank.Instance.Leaf.ToString();
        woodUI.text = "woods" + ResourceBank.Instance.Wood.ToString();
        rockUI.text = "rocks" + ResourceBank.Instance.Rock.ToString();
        woolUI.text = "wools" + ResourceBank.Instance.Wool.ToString();
        ironUI.text = "irons" + ResourceBank.Instance.Iron.ToString();
        
        Loadpanels();
        CheckPurchare();
    }
    public void CheckPurchare()
    {
       for(int i = 0;i<shopItems.Length;i++)
        {
            
            if (ResourceBank.Instance.Rock >= shopItems[i].rockCost& ResourceBank.Instance.Wood >= shopItems[i].woodCost & ResourceBank.Instance.Wool>= shopItems[i].woolCost & ResourceBank.Instance.Iron>=shopItems[i].ironCost & ResourceBank.Instance.Leaf>=shopItems[i].leafCost & ResourceBank.Instance.Rope>=shopItems[i].ropeCost)
            {
                mypurch[i].interactable = true;
            }
            else
            {
                mypurch[i].interactable = false;
            }
        }
    }
    public void PurchItem(int btnNo)
    {
        if (ResourceBank.Instance.Rock >= shopItems[btnNo].rockCost & ResourceBank.Instance.Wood >= shopItems[btnNo].woodCost & ResourceBank.Instance.Wool>= shopItems[btnNo].woolCost & ResourceBank.Instance.Iron>=shopItems[btnNo].ironCost & ResourceBank.Instance.Leaf>=shopItems[btnNo].leafCost & ResourceBank.Instance.Rope>=shopItems[btnNo].ropeCost)
        {
            ResourceBank.Instance.Iron -= shopItems[btnNo].ironCost;
            ResourceBank.Instance.Wool -= shopItems[btnNo].woolCost;
            ResourceBank.Instance.Wood -= shopItems[btnNo].woodCost;
            ResourceBank.Instance.Rock -= shopItems[btnNo].rockCost;
            ResourceBank.Instance.Leaf -= shopItems[btnNo].leafCost;
            ResourceBank.Instance.Rope -= shopItems[btnNo].ropeCost;
            
            if (shopItems[btnNo].title == "WoodUpg")
            {
                Upgrade.Instance.WoodproductivityIncrease++;
                shopItems[btnNo].woodCost *=2;
               
            }
            if (shopItems[btnNo].title == "rockUPG")
            {
                Upgrade.Instance.RockproductivityIncrease++;
                shopItems[btnNo].rockCost *=2;
            }
            if (shopItems[btnNo].title == "IronUPG")
            {
                Upgrade.Instance.IronproductivityIncrease++;
                shopItems[btnNo].ironCost *=2;
            }
            if (shopItems[btnNo].title=="WoolUPG")
            {
                Upgrade.Instance.WoolproductivityIncrease++;
                shopItems[btnNo].woolCost *=2;
            }
            if (shopItems[btnNo].title=="LeafUPG")
            {
                Upgrade.Instance.Leafprod++;
                shopItems[btnNo].leafCost *=2;
            }
            
            woolUI.text = "wools" + ResourceBank.Instance.Wool.ToString();
            ironUI.text = "irons" + ResourceBank.Instance.Iron.ToString();
            woodUI.text = "woods" + ResourceBank.Instance.Wood.ToString();
            rockUI.text = "rocks" + ResourceBank.Instance.Rock.ToString();
            leafUI.text = "leafs" + ResourceBank.Instance.Leaf.ToString();
            ropeUI.text = "ropes" + ResourceBank.Instance.Rope.ToString();
            CheckPurchare();
        }
    }
    void Update()
    {
        ropeUI.text = "ropes" + ResourceBank.Instance.Rope.ToString();
        leafUI.text = "leafs" + ResourceBank.Instance.Leaf.ToString();
        rockUI.text = "rocks" + ResourceBank.Instance.Rock.ToString();
        woolUI.text = "wools" + ResourceBank.Instance.Wool.ToString();
        woodUI.text = "woods" + ResourceBank.Instance.Wood.ToString();
        ironUI.text = "irons" + ResourceBank.Instance.Iron.ToString();
        CheckPurchare();
    }
    public void Loadpanels ()
    {
        for (int i = 0; i < shopItems.Length; i++)
        {
            shopPanels[i].titleText.text = shopItems[i].title;
            shopPanels[i].descriptionTxt.text = shopItems[i].description;
            shopPanels[i].rockTxt.text = "rocks" + shopItems[i].rockCost.ToString();
            shopPanels[i].woodTxt.text = "woods" + shopItems[i].woodCost.ToString();
            shopPanels[i].ironTxt.text = "irons" + shopItems[i].ironCost.ToString();
            shopPanels[i].woolTxt.text = "wools" + shopItems[i].woolCost.ToString();
            shopPanels[i].leafTxt.text = "leafs" + shopItems[i].leafCost.ToString();
            shopPanels[i].ropeTxt.text = "ropes" + shopItems[i].ropeCost.ToString();
        }
    }
}
