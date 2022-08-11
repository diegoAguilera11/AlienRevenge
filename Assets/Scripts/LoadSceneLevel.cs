using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadSceneLevel : MonoBehaviour
{
    #region CLASS_VARIABLES

    public bool stateLevelOne = false;

    public bool stateLevelBoss = false;

    #endregion

    #region CLASS_METHODS

    public void LoadSceneNew()
    { 

        if (stateLevelOne == false)
        {
            SceneManager.LoadScene("LevelOne");

        }else if(stateLevelBoss)
        {
            SceneManager.LoadScene("BossLevel");
        }

    }

    #endregion
}
