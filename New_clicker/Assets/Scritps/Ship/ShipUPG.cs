using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class ShipUpg : MonoBehaviour
{
    [FormerlySerializedAs("EndShipSpire")] public Sprite endShipSpire;
    public Sprite upgradedShipSprite;
    public Sprite BuildShip;

    public void buildShip()
    {
        GetComponent<SpriteRenderer>().sprite = BuildShip;
    }

    public void ApplyUpgrade()
    {
        GetComponent<SpriteRenderer>().sprite = upgradedShipSprite;
    }

    public void EndGame()
    {
        GetComponent<SpriteRenderer>().sprite = endShipSpire;
    }

    private void Start()
    {
        ShopManager.Instance.ItemSold += ButtonActive;
    }

    private void ButtonActive(string obj)
    {
        if (obj == "BuildShip")
        {
            buildShip();
        }

        if (obj == "UpgShip")
        { 
            ApplyUpgrade();
        }

        if (obj == "EndGame")
        {
            EndGame();
        }
    }
    private void OnDestroy()
    {
        ShopManager.Instance.ItemSold -= ButtonActive;
    }
}

