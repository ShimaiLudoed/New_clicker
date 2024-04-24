using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipUPG : MonoBehaviour
{
    public Sprite EndShipSpire;
    public Sprite upgradedShipSprite; 
    public void ApplyUpgrade()
    {
        GetComponent<SpriteRenderer>().sprite = upgradedShipSprite;
    }

    public void endGame()
    {
        GetComponent<SpriteRenderer>().sprite = EndShipSpire;
    }
}
