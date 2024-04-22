using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

[CreateAssetMenu(fileName = "shopMenu", menuName = "scriptableobject/new shop Item", order = 1)]
public class ShopItem : ScriptableObject
{
    
 public string Title;
 public string description; 
 public int rockCost; 
 public int woodCost;
 public int woolCost;
 public int ironCost;
 public int RopeCost;
 public int WoodproductivityIncrease;
 public int WoolproductivityIncrease;
 public int IronproductivityIncrease;
 public int RockproductivityIncrease;
}