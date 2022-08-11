using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuButtons : MonoBehaviour
{
    //Metodo para salir de la app

    AudioManager _AudioManager;


    void Start()
    {
        _AudioManager = FindObjectOfType<AudioManager>();
    }

    #region CLASS_METHODS
    public void QuitApk()
    {
        //Cierra la APP en la build
        _AudioManager.playSoundButton();
        Application.Quit();
    }
    #endregion
}
