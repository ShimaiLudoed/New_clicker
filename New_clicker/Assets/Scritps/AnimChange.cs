using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine;

public class SceneChangeHandler : MonoBehaviour
{
    public Animator animator;
    private string currentScene;

    void Start()
    {
        currentScene = gameObject.scene.name;
    }

    void Update()
    {
        string newScene = gameObject.scene.name;
        if (newScene != currentScene)
        {
            if (newScene == "W.L")
            {
                animator.SetTrigger("cut");
                // Добавьте другие условия для других сцен
            }

            currentScene = newScene;
        }
    }
}