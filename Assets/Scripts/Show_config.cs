using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEditor;

public class Show_config : MonoBehaviour
{
    #region VARIABLES

    public GameObject canvas;
    public GameObject canvasButton;

    DestroyOnTouch _destroyOnTouch;

    private AudioManager _audioManager;

    #endregion


void Start()
{
    _audioManager = FindObjectOfType<AudioManager>();
    canvas.SetActive(false);
    canvasButton.SetActive(true);
}



    #region CLASS_METHODS


    public void ActiveCanvasLevelOne()
    {
        Time.timeScale = 0;
        _audioManager.playSoundButton();
        canvasButton.SetActive(false);
        canvas.SetActive(true);
        _audioManager.PauseLevelOnetheme();
        _destroyOnTouch.stateTouch = false;
    }
    public void ActiveCanvasLevelBoss()
    {
        Time.timeScale = 0;
        _audioManager.playSoundButton();
        canvasButton.SetActive(false);
        canvas.SetActive(true);
        _audioManager.PauseLevelBosstheme();
        _destroyOnTouch.stateTouch = false;
    }
    #endregion
}
