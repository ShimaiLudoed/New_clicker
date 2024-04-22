using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResourceBank : MonoBehaviour
{
    public int rock { get; set; } 
    public int wood { get; set; }
    public int wool { get; set; }
    public int iron { get; set; }
    public int rope { get; set; }

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
}
