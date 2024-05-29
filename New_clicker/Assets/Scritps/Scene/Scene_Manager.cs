using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManager : MonoBehaviour
{
    public void PlayGame()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("G.M.Scene");
      
    }

    public void WoodTp()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("W.L");
 
    }

    public void WoolTp()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("S.L");
    }

    public void IronTp()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("I.L");
    }

    public void RockTp()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("R.L");
    }

    public void LeafTp()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("L.L");
    }
    public void End()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("End Game");
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene("M.M.Scene");
        }
    }
}

