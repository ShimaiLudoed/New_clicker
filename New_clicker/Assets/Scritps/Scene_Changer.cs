using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneChanger : MonoBehaviour
{
    public void PlayGame(string Start_location)
    {
        SceneManager.LoadScene(G.M.Scene);
    }
}
