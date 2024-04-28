using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class ShipUpg : MonoBehaviour
{
    [FormerlySerializedAs("EndShipSpire")] public Sprite endShipSpire;
    public Sprite upgradedShipSprite; 
    public void ApplyUpgrade()
    {
        GetComponent<SpriteRenderer>().sprite = upgradedShipSprite;
    }

    public void EndGame()
    {
        GetComponent<SpriteRenderer>().sprite = endShipSpire;
    }
}
