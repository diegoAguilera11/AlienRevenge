using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEngine.UI;

public class Close_MenuPause : MonoBehaviour
{
    #region VARIABLES
    public GameObject canvas;
    public GameObject canvasButton;

    private AudioManager _audioManager;
    #endregion

    void Start()
    {
        _audioManager = FindObjectOfType<AudioManager>();
    }

    #region CLASS_METHODS
    public void DesactiveCanvas()
    {
        Time.timeScale = 1;
        _audioManager.playSoundButton();
        canvas.SetActive(false);
        _audioManager.PlayLevelOnetheme();
        canvasButton.SetActive(true);
    }

    public void DesactiveCanvasBoss()
    {
        Time.timeScale = 1;
        _audioManager.playSoundButton();
        canvas.SetActive(false);
        _audioManager.PlayLevelBosstheme();
        canvasButton.SetActive(true);
    }

    #endregion
}
