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
 public int productivityIncreaseWood;
 public int productivityIncreaseWool;
 public int productivityIncreaseIron;
 public int productivityIncreaseRock;
}