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
}
