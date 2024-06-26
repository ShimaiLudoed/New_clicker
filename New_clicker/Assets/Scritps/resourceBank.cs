using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class ResourceBank : MonoBehaviour
{
    public int Rock;
    public int Wood;
    public int Wool;
    public int Iron;
    public int Rope;
    public int Leaf;


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
    [FormerlySerializedAs("EndGameIsUnl")] public bool endGameIsUnl;

    public void Update()
    {
        if(Input.GetKeyDown(KeyCode.Keypad7))
        {
            ResourceBank.Instance.Iron += 250;
            ResourceBank.Instance.Leaf += 250;
            ResourceBank.Instance.Wool += 250;
            ResourceBank.Instance.Rock += 250;
            ResourceBank.Instance.Wood += 250;
        }
    }
}
