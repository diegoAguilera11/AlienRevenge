using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartLevel : MonoBehaviour
{
    #region CLASS_VARIABLES

    public string sceneName;
    public GameObject restartCanvas;

    #endregion

    #region CLASS_METHODS

    public void LoadSceneNew()
    {
        restartCanvas.SetActive(false);
        SceneManager.LoadScene(sceneName);
    }

    #endregion
}
