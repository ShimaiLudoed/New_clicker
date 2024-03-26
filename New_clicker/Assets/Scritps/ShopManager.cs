using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class ShopManager : MonoBehaviour
{
    public int coins;
    public TMP_Text CoinsUI;
    public ShopItem[] shopItems;
    public GameObject[] shopPanelsGO;
    public ShopTemplate[] shopPanels;
    public Button[] Mypurch;
    void Start()
    {
        for (int i = 0; i < shopItems.Length; i++)
        
            shopPanelsGO[i].SetActive(true);
        
        CoinsUI.text = "coins" + coins.ToString();
        loadpanels();
        CheckPurchare();
    }

    public void AddCoin()
    {
        coins++;
        CoinsUI.text = "coins" + coins.ToString();
        CheckPurchare() ;

    }

    public void CheckPurchare()
    {
       for(int i = 0;i<shopItems.Length;i++)
        {
            if (coins >= shopItems[i].Cost)
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
        if (coins >= shopItems[btnNO].Cost)
        {
            coins= coins - shopItems[btnNO].Cost;
            CoinsUI.text="coins"+coins.ToString();
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
        }
    }
}
