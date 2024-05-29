using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class Click : MonoBehaviour
{



    public void AddIron()
    {
        ResourceBank.Instance.Iron  += Upgrade.Instance.IronproductivityIncrease;
    }
    public void AddLeaf()
    {
        ResourceBank.Instance.Leaf  += Upgrade.Instance.Leafprod;
    }
    public void AddWool()
    {
        ResourceBank.Instance.Wool += Upgrade.Instance.WoolproductivityIncrease;
    }

    public void AddRock()
    {
        ResourceBank.Instance.Rock += Upgrade.Instance.RockproductivityIncrease;
    }

    public void AddWood()
    {
        ResourceBank.Instance.Wood+=Upgrade.Instance.WoodproductivityIncrease;
    }
}
