using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.VisualScripting;

public class Teleport : MonoBehaviour
{
    public GameObject unlockRockTp;
    public GameObject unlockIronTp;
    public GameObject unlockLeafTp;
    public GameObject rope;
    public GameObject unlockwoolTp;
    public GameObject EndGameTP;
    public TMP_Text ironUI;
    public TMP_Text woolUI;
    public TMP_Text woodUI;
    public TMP_Text rockUI;
    public TMP_Text leafUI;
    public TMP_Text ropeUI;
    public GameObject InfoPan;
    public GameObject InfoPan4;


void Start()
{
    ShopManager.Instance.ItemSold += ButtonActive;
            
        if (ResourceBank.Instance.endGameIsUnl)
        {
            EndGameTP.SetActive(true);
        }
        
        if (ResourceBank.Instance.isRockLocationUnlocked)
        {
            unlockRockTp.SetActive(true);
            rockUI.gameObject.SetActive(true);
        }
        
        if (ResourceBank.Instance.isLeafLocationUnlocked)
        {
            unlockLeafTp.SetActive(true);
            rope.SetActive(true);
            leafUI.gameObject.SetActive(true);
            ropeUI.gameObject.SetActive(true);
        }
        if (ResourceBank.Instance.isIronLocationUnlocked)
        {
            unlockIronTp.SetActive(true);
            ironUI.gameObject.SetActive(true);
        }
        if (ResourceBank.Instance.isWoolLocationUnlocked)
        {
            unlockwoolTp.SetActive(true);
            woolUI.gameObject.SetActive(true);
        }
    }

private void ButtonActive(string obj)
{
    if (obj == "Локация с камнем")
    {
        InfoPan4.SetActive(false);
        unlockRockTp.SetActive(true);
        rockUI.gameObject.SetActive(true);
    }

    if (obj == "Локация с растенями")
    {
        unlockLeafTp.SetActive(true);
        rope.SetActive(true);
        leafUI.gameObject.SetActive(true);
        ropeUI.gameObject.SetActive(true);
    }
    if (obj == "Локация с овцами")
    {
        unlockwoolTp.SetActive(true);
        woolUI.gameObject.SetActive(true);
    }
    if (obj == "Локация с железом")
    {
        unlockIronTp.SetActive(true);
        ironUI.gameObject.SetActive(true);
    }
}


// Update is called once per frame
    void Update()
    {
        ropeUI.text = "ropes" + ResourceBank.Instance.Rope.ToString();
        leafUI.text = "leafs" + ResourceBank.Instance.Leaf.ToString();
        rockUI.text = "rocks" + ResourceBank.Instance.Rock.ToString();
        woolUI.text = "wools" + ResourceBank.Instance.Wool.ToString();
        woodUI.text = "woods" + ResourceBank.Instance.Wood.ToString();
        ironUI.text = "irons" + ResourceBank.Instance.Iron.ToString();
        InfoPan4.SetActive(TutorCon.Instance.InfoPan4);
        InfoPan.SetActive(TutorCon.Instance.InfoPan5);
    }

    private void OnDestroy()
    {
        ShopManager.Instance.ItemSold -= ButtonActive;
    }
}
