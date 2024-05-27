using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResourceBank : MonoBehaviour
{
    public int Rock { get; set; } 
    public int Wood { get; set; }
    public int Wool { get; set; }
    public int Iron { get; set; }
    public int Rope { get; set; }
    public int Leaf { get; set; }

    public static ResourceBank Instance { get; private set; }
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
    public bool isRockLocationUnlocked;
    public bool isIronLocationUnlocked;
    public bool isLeafLocationUnlocked;
    public bool isWoolLocationUnlocked;
}
