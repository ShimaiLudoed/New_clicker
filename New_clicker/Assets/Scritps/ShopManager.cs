using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class ShopManager : MonoBehaviour
{
    public int coins;
    public TMP_Text CoinsUI;
    void Start()
    {
        CoinsUI.text = "coins" + coins.ToString();
    }

    public void AddCoin()
    {
        coins++;
        CoinsUI.text = "coins" + coins.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
