using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Click : MonoBehaviour
{
    private ShopManager shop;
    public int Woodclick = 1;
    public int RockClick = 1;
    public int WoolClick = 1;
    public int IronClick = 1;
    public int LeafClick = 1;
    
    public void AddIron()
    {
        ResourceBank.Instance.iron += IronClick;
        shop.IronUI.text = "irons" + ResourceBank.Instance.iron.ToString();
        shop.CheckPurchare();
    }
    public void AddLeaf()
    {
        ResourceBank.Instance.iron += IronClick;
        shop.IronUI.text = "irons" + ResourceBank.Instance.iron.ToString();
        shop.CheckPurchare();
    }

    public void AddWool()
    {
        ResourceBank.Instance.wool += WoolClick;
        shop.WoolUI.text = "wools" + ResourceBank.Instance.wool.ToString();
        shop.CheckPurchare();
    }

    public void AddRock()
    {
        
        ResourceBank.Instance.rock+=RockClick;
        shop.RockUI.text = "rocks" + ResourceBank.Instance.rock.ToString();
        shop.CheckPurchare() ;
         

    }

    public void AddWood()
    {
        ResourceBank.Instance.wood+=Woodclick;
        if (shop.WoodUI != null)
        {
            shop.WoodUI.text = "woods" + ResourceBank.Instance.wood.ToString();
        }

        shop.CheckPurchare();
    }
}
