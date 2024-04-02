using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class ShopManager : MonoBehaviour
{
    
    
    public TMP_Text WoodUI;
    public TMP_Text CoinsUI;
    public ShopItem[] shopItems;
    //public GameObject[] shopPanelsGO;
    public ShopTemplate[] shopPanels;
    public Button[] Mypurch;
    public int Woodclick = 1;
    public int CoinClick = 1;
    
  
    void Start()
    {
        for (int i = 0; i < shopItems.Length; i++)
        
            shopPanels[i].gameObject.SetActive(true);

        WoodUI.text = "woods" + ResourceBank.Instance.wood.ToString();
        CoinsUI.text = "coins" + ResourceBank.Instance.coins.ToString();
        loadpanels();
        CheckPurchare();
    }

    public void AddCoin()
    {
        
        ResourceBank.Instance.coins+=CoinClick;
        CoinsUI.text = "coins" + ResourceBank.Instance.coins.ToString();
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
            
            if (ResourceBank.Instance.coins >= shopItems[i].Cost& ResourceBank.Instance.wood >= shopItems[i].woodCost)
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
        if (ResourceBank.Instance.coins >= shopItems[btnNO].Cost && ResourceBank.Instance.wood >= shopItems[btnNO].woodCost)
        {
         
            ResourceBank.Instance.wood -= shopItems[btnNO].woodCost;
            ResourceBank.Instance.coins-= shopItems[btnNO].Cost;
            if (shopItems[btnNO] is ShopItem item)
            {
                shopItems[btnNO].productivityIncreaseWood++;
            }
            if (shopItems[btnNO].Title == "coinUPG")
            {
                shopItems[btnNO].productivityIncreaseCoin++;
            }
            Woodclick += shopItems[btnNO].productivityIncreaseWood;
            CoinClick += shopItems[btnNO].productivityIncreaseCoin;
            WoodUI.text = "woods" + ResourceBank.Instance.wood.ToString();
            CoinsUI.text = "coins" + ResourceBank.Instance.coins.ToString();
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
            shopPanels[i].costTxt.text = "coins" + shopItems[i].Cost.ToString();
            shopPanels[i].woodTxt.text = "woods" + shopItems[i].woodCost.ToString();
        }
    }
}
