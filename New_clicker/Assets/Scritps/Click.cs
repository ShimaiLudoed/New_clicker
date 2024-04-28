using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class Click : MonoBehaviour
{

    [FormerlySerializedAs("Woodclick")] public int woodclick = 1;
    [FormerlySerializedAs("RockClick")] public int rockClick = 1;
    [FormerlySerializedAs("WoolClick")] public int woolClick = 1;
    [FormerlySerializedAs("IronClick")] public int ironClick = 1;
    [FormerlySerializedAs("LeafClick")] public int leafClick = 1;
    public int ropeclick = 1;
    public void AddIron()
    {
        ResourceBank.Instance.Iron += ironClick += Upgrade.Instance.IronproductivityIncrease;
    }
    public void AddLeaf()
    {
        ResourceBank.Instance.Leaf += leafClick += Upgrade.Instance.Leafprod;
    }
    public void AddWool()
    {
        ResourceBank.Instance.Wool += woolClick+= Upgrade.Instance.WoolproductivityIncrease;
    }

    public void AddRock()
    {
        ResourceBank.Instance.Rock+=rockClick += Upgrade.Instance.RockproductivityIncrease;
    }

    public void AddWood()
    {
        ResourceBank.Instance.Wood+=woodclick+=Upgrade.Instance.WoodproductivityIncrease;
    }
}
