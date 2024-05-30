using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sounds : MonoBehaviour
{
    public AudioClip soundClip; // Аудиоклип для проигрывания
    private AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>(); // Получаем компонент AudioSource из объекта, к которому присоединен этот скрипт
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) // Можно изменить на любую другую кнопку
        {
            PlaySound(); // Вызываем метод проигрывания звука
        }
    }

    public void PlaySound()
    {
        audioSource.PlayOneShot(soundClip); // Проигрываем звук, когда вызывается этот метод
    }
}
