using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Click : MonoBehaviour
{

    public int Woodclick = 1;
    public int RockClick = 1;
    public int WoolClick = 1;
    public int IronClick = 1;
    public int LeafClick = 1;
    public int ropeclick = 1;
    public void AddIron()
    {
        ResourceBank.Instance.iron += IronClick += Upgrade.Instance.IronproductivityIncrease;
    }
    public void AddLeaf()
    {
        ResourceBank.Instance.leaf += LeafClick += Upgrade.Instance.Leafprod;
    }
    public void AddWool()
    {
        ResourceBank.Instance.wool += WoolClick+= Upgrade.Instance.WoolproductivityIncrease;
    }

    public void AddRock()
    {
        ResourceBank.Instance.rock+=RockClick += Upgrade.Instance.RockproductivityIncrease;
    }

    public void AddWood()
    {
        ResourceBank.Instance.wood+=Woodclick+=Upgrade.Instance.WoodproductivityIncrease;
    }
}
