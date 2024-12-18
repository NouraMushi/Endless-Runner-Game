using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class MainMenuScript : MonoBehaviour
{
    private void Awake()
    {
        Time.timeScale = 0;
    }

    public void PlayGame()
    {
        Time.timeScale = 1;
        transform.DOMoveY(-230, 1f);
    }

    public void PauseGame()
    {
        transform.DOMoveY(500, 1f).OnComplete(() =>
        {
            Time.timeScale = 0;
        });
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}