using System;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.VisualScripting;
using UnityEngine.Serialization;
using UnityEngine.UI;


public class ShopManager : MonoBehaviour
{

    public ShopItem[] shopItems;
    public ShopTemplate[] shopPanels;
    public GameObject player;
    private Animator _characterAnimator;
    public Button[] mypurch;
    public ShipUpg shipUpg;
    private Teleport _teleport;
    private TutorMage _tutor;

    
    public event Action<string> ItemSold; 
    
    void Start()
    {
        for (int i = 0; i < shopItems.Length; i++)
        {
            shopPanels[i].gameObject.SetActive(true);
        }
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
            
            if (shopItems[btnNo].title == "BuildShip")
            {
               
               HidePurchasedItem(btnNo);
            }
            
            if (shopItems[btnNo].title == "UpgShip")
            { 
           
             HidePurchasedItem(btnNo);
            }
            
            if (shopItems[btnNo].title == "EndGame")
            {
               
                HidePurchasedItem(btnNo);
                ResourceBank.Instance.endGameIsUnl = true;
            }

            if (shopItems[btnNo].title == "Локация с камнем")
            {
                ResourceBank.Instance.isRockLocationUnlocked = true;
         
                HidePurchasedItem(btnNo);
            }
            
            if (shopItems[btnNo].title == "Локация с железом")
            {
           
                ResourceBank.Instance.isIronLocationUnlocked = true;
              HidePurchasedItem(btnNo);
            
            }
            if (shopItems[btnNo].title == "Локация с растенями")
            {
                ResourceBank.Instance.isLeafLocationUnlocked = true;
      
         
                HidePurchasedItem(btnNo);
          
            }
            if (shopItems[btnNo].title == "Локация с овцами")
            {
                ResourceBank.Instance.isWoolLocationUnlocked = true;
           
                HidePurchasedItem(btnNo);
           
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

            CheckPurchare();
            ItemSold?.Invoke(shopItems[btnNo].title);
        }
    }
    void Update()
    {

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
    
    public static ShopManager Instance { get; private set; }
    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
        DontDestroyOnLoad(target:this);
        for (var index = 0; index < mypurch.Length; index++)
        {
            var Taken = mypurch[index];
            var index1 = index;
            Taken.onClick.AddListener(()=> PurchItem(index1));
        }
    }  
    
}
