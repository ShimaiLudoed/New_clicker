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
 public int LeafCost;
 public int WoodproductivityIncrease=0;
 public int WoolproductivityIncrease=0;
 public int IronproductivityIncrease=0;
 public int RockproductivityIncrease=0;
 public int Leafprod = 0;
 public int ropeprod = 0;
}