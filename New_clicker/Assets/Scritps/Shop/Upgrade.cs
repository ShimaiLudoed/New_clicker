using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Upgrade : MonoBehaviour
{
    public int WoodproductivityIncrease { get; set; }
    public int WoolproductivityIncrease { get; set; }
    public int IronproductivityIncrease { get; set; }
    public int RockproductivityIncrease { get; set; }
    public int Leafprod { get; set; }
    public int Ropeprod { get; set; }
    
    public static Upgrade Instance { get; private set; }
    
    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
        DontDestroyOnLoad(target:this);

    }
}
