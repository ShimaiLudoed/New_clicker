using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "shopMenu", menuName = "scriptableobject/new shop Item", order = 1)]
public class ShopItem : ScriptableObject
{
 public string Title;
 public int Cost; 
 public string description; 
 public int woodCost;
 public int productivityIncreaseWood;
 public int productivityIncreaseCoin;
}