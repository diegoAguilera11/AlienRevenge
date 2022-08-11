using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene_OneToBoss : MonoBehaviour
{
    #region CLASS_VARIABLES

    AudioManager _AudioManager;


    #endregion

    void Start()
    {
        _AudioManager = FindObjectOfType<AudioManager>();
    }

    #region CLASS_METHODS

    public void LoadSceneNew()
    {
        _AudioManager.playSoundButton();
        SceneManager.LoadScene("BossLevel");
    }

    #endregion
}
