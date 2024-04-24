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
    public void WoolTP()
    {
        SceneManager.LoadScene("S.L");
    }
    public void IronTP()
    {
        SceneManager.LoadScene("I.L");
    }
    public void RockTP()
    {
        SceneManager.LoadScene("R.L");
    }
    public void LeafTP()
    {
        SceneManager.LoadScene("L.L");
    }
}
