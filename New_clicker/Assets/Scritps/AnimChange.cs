using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.Serialization;

public class animCont : MonoBehaviour
{
    [FormerlySerializedAs("Player")] public GameObject player;
    
    public void PlayPurchaseAnimation()
    {
        Animator characterAnimator = player.GetComponentInChildren<Animator>();
        if (characterAnimator != null)
        {
            characterAnimator.Play("Buy");
        }
        else
        {
            Debug.LogError("Animator component not found on the character model or its children!");
        }
    }
}