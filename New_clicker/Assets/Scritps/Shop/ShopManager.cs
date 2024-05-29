using System;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.VisualScripting;
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
    [FormerlySerializedAs("UnlockRockTP")] public GameObject unlockRockTp;
    [FormerlySerializedAs("UnlockIronTP")] public GameObject unlockIronTp;
    [FormerlySerializedAs("UnlockLeafTP")] public GameObject unlockLeafTp;
    [FormerlySerializedAs("Rope")] public GameObject rope;
    [FormerlySerializedAs("UnlockwoolTP")] public GameObject unlockwoolTp;
    public GameObject EndGameTP;
    public ShopItem[] shopItems;
    public ShopTemplate[] shopPanels;
    public GameObject player;
    private Animator _characterAnimator;
    public Button[] mypurch;
    public ShipUpg shipUpg;
    [FormerlySerializedAs("RockUi")] public GameObject rockUi;
    [FormerlySerializedAs("LeafUi")] public GameObject leafUi;
    [FormerlySerializedAs("RopeUi")] public GameObject ropeUi;
    [FormerlySerializedAs("IronUi")] public GameObject ironUi;
    [FormerlySerializedAs("WoolUi")] public GameObject woolUi;
    private TutorMage _tutor;
    [FormerlySerializedAs("Infopan")] public GameObject infopan;

    
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

        if (ResourceBank.Instance.endGameIsUnl)
        {
            EndGameTP.SetActive(true);
        }
        
        if (ResourceBank.Instance.isRockLocationUnlocked)
        {
            unlockRockTp.SetActive(true);
            rockUi.SetActive(true);
            
        }
        if (ResourceBank.Instance.isLeafLocationUnlocked)
        {
            unlockLeafTp.SetActive(true);
            rope.SetActive(true);
            leafUi.SetActive(true);
            ropeUi.SetActive(true);
        }
        if (ResourceBank.Instance.isIronLocationUnlocked)
        {
            unlockIronTp.SetActive(true);
            ironUi.SetActive(true);
        }
        if (ResourceBank.Instance.isWoolLocationUnlocked)
        {
            unlockwoolTp.SetActive(true);
            woolUi.SetActive(true);
        }
        
        _characterAnimator = player.GetComponent<Animator>();
        if (_characterAnimator == null)
        {
            Debug.LogError("Animator component not found on the player!");
        }
        

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
            
            if (shopItems[btnNo].title == "BuildShip")
            {
                shipUpg.buildShip();
               HidePurchasedItem(btnNo);
            }
            
            if (shopItems[btnNo].title == "UpgShip")
            {
                shipUpg.ApplyUpgrade();
             HidePurchasedItem(btnNo);
            }
            
            if (shopItems[btnNo].title == "EndGame")
            {
                shipUpg.EndGame();
                HidePurchasedItem(btnNo);
                ResourceBank.Instance.endGameIsUnl = true;
                Start(); 
            }

            if (shopItems[btnNo].title == "Локация с камнем")
            {
                ResourceBank.Instance.isRockLocationUnlocked = true;
                unlockRockTp.SetActive(true); 
                HidePurchasedItem(btnNo);
                rockUi.SetActive(true);
                TutorCon.Instance.InfoPan5 = false;
                infopan.SetActive(false);
            }
            
            if (shopItems[btnNo].title == "Локация с железом")
            {
                unlockIronTp.SetActive(true);
                ResourceBank.Instance.isIronLocationUnlocked = true;
              HidePurchasedItem(btnNo);
                ironUi.SetActive(true);
            }
            if (shopItems[btnNo].title == "Локация с растенями")
            {
                ResourceBank.Instance.isLeafLocationUnlocked = true;
                unlockLeafTp.SetActive(true);
                rope.SetActive(true);
                HidePurchasedItem(btnNo);
                leafUi.SetActive(true);
            }
            if (shopItems[btnNo].title == "Локация с овцами")
            {
                ResourceBank.Instance.isWoolLocationUnlocked = true;
                unlockwoolTp.SetActive(true);
                HidePurchasedItem(btnNo);
                woolUi.SetActive(true);
            }
            
            if (shopItems[btnNo].title == "Улучшение дерева")
            {
                Upgrade.Instance.WoodproductivityIncrease *=2 ;
                HidePurchasedItem(btnNo);
            }
            if (shopItems[btnNo].title == "Улучшение дерева 2")
            {
                Upgrade.Instance.WoodproductivityIncrease *=2 ;
                HidePurchasedItem(btnNo);
            }
            if (shopItems[btnNo].title == "Улучшение дерева 3")
            {
                Upgrade.Instance.WoodproductivityIncrease *=2 ;
                HidePurchasedItem(btnNo);
            }
            if (shopItems[btnNo].title == "Улучшение дерева 4")
            {
                Upgrade.Instance.WoodproductivityIncrease *=2 ;
                HidePurchasedItem(btnNo);
            }
            if (shopItems[btnNo].title == "Улучшение дерева 5")
            {
                Upgrade.Instance.WoodproductivityIncrease *=2 ;
                HidePurchasedItem(btnNo);
            }
            if (shopItems[btnNo].title == "Улучшение железа ")
            {
                Upgrade.Instance.IronproductivityIncrease*=2 ;
                HidePurchasedItem(btnNo);
            }
            if (shopItems[btnNo].title == "Улучшение железа 2")
            {
                Upgrade.Instance.IronproductivityIncrease *=2 ;
                HidePurchasedItem(btnNo);
            }

            if (shopItems[btnNo].title == "Улучшение железа 3")
            {
                Upgrade.Instance.IronproductivityIncrease *= 2;
                HidePurchasedItem(btnNo);
            }
            if (shopItems[btnNo].title == "Улучшение железа 4")
            {
                Upgrade.Instance.IronproductivityIncrease *=2 ;
                HidePurchasedItem(btnNo);
            }
            if (shopItems[btnNo].title == "Улучшение железа 5")
            {
                Upgrade.Instance.IronproductivityIncrease *=2 ;
                HidePurchasedItem(btnNo);
            }
            if (shopItems[btnNo].title == "Улучшение растений")
            {
                Upgrade.Instance.Leafprod *=2 ;
                HidePurchasedItem(btnNo);
            }
            if (shopItems[btnNo].title == "Улучшение растений 2")
            {
                Upgrade.Instance.Leafprod *=2 ;
                HidePurchasedItem(btnNo);
            }
            if (shopItems[btnNo].title == "Улучшение растений 3")
            {
                Upgrade.Instance.Leafprod *=2 ;
                HidePurchasedItem(btnNo);
            }
            if (shopItems[btnNo].title == "Улучшение растений 4")
            {
                Upgrade.Instance.Leafprod *=2 ;
                HidePurchasedItem(btnNo);
            }
            if (shopItems[btnNo].title == "Улучшение растений 5")
            {
                Upgrade.Instance.Leafprod *=2 ;
                HidePurchasedItem(btnNo);
            }
            if (shopItems[btnNo].title == "Верёвка")
            {
                ResourceBank.Instance.Rope++;
            }
            if (shopItems[btnNo].title == "Улучшение камня")
            {
                Upgrade.Instance.RockproductivityIncrease *=2 ;
                HidePurchasedItem(btnNo);
            }
            if (shopItems[btnNo].title == "Улучшение камня 2")
            {
                Upgrade.Instance.RockproductivityIncrease *=2 ;
                HidePurchasedItem(btnNo);
            }
            if (shopItems[btnNo].title == "Улучшение камня 3")
            {
                Upgrade.Instance.RockproductivityIncrease *=2 ;
                HidePurchasedItem(btnNo);
            }
            if (shopItems[btnNo].title == "Улучшение камня 4")
            {
                Upgrade.Instance.RockproductivityIncrease *=2 ;
                HidePurchasedItem(btnNo);
            }
            if (shopItems[btnNo].title == "Улучшение камня 5")
            {
                Upgrade.Instance.RockproductivityIncrease *=2 ;
                HidePurchasedItem(btnNo);
            }
            if (shopItems[btnNo].title == "Улучшение шерсти")
            {
                Upgrade.Instance.WoolproductivityIncrease *=2 ;
                HidePurchasedItem(btnNo);
            }
            if (shopItems[btnNo].title == "Улучшение шерсти 2")
            {
                Upgrade.Instance.WoolproductivityIncrease *=2 ;
                HidePurchasedItem(btnNo);
            }
            if (shopItems[btnNo].title == "Улучшение шерсти 3")
            {
                Upgrade.Instance.WoolproductivityIncrease *=2 ;
                HidePurchasedItem(btnNo);
            } 
            if (shopItems[btnNo].title == "Улучшение шерсти 4")
            {
                Upgrade.Instance.WoolproductivityIncrease *=2 ;
                HidePurchasedItem(btnNo);
            }
            if (shopItems[btnNo].title == "Улучшение шерсти 5")
            {
                Upgrade.Instance.WoolproductivityIncrease *=2 ;
                HidePurchasedItem(btnNo);
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
    public void HidePurchasedItem(int index)
    {
        shopPanels[index].gameObject.SetActive(false); 
    }
  
}
