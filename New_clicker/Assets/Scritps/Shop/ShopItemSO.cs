using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

[CreateAssetMenu(fileName = "shopMenu", menuName = "scriptableobject/new shop Item", order = 1)]
public class ShopItem : ScriptableObject
{
    
 [FormerlySerializedAs("Title")] public string title;
 public string description; 
 public int rockCost; 
 public int woodCost;
 public int woolCost;
 public int ironCost;
 [FormerlySerializedAs("RopeCost")] public int ropeCost;
 [FormerlySerializedAs("LeafCost")] public int leafCost;

}