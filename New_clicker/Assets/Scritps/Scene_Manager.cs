using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Scene_Manager : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("G.M.Scene");
    }

    public void WoodTP()
    {
        SceneManager.LoadScene("W.L");
    }
}
