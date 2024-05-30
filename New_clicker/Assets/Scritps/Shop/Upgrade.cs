using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Upgrade : MonoBehaviour
{
    public int WoodproductivityIncrease = 1;
    public int WoolproductivityIncrease = 1;
    public int IronproductivityIncrease = 1;
    public int RockproductivityIncrease = 1;
    public int Leafprod = 1;
    
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
