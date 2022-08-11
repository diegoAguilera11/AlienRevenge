using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
public class HudManager : MonoBehaviour
{

    #region CLASS_VARIABLES

    private int score = 0;
    public int maxScore;
    public GameObject canvas;

    public GameObject canvasScore;

    public GameObject canvasRedScreen;

    public GameObject canvasTime;

    public GameObject canvasButton;
    public TextMeshProUGUI txtScore;

    private AudioManager _AudioManager;

    private DestroyOnTouch _DestroyOnTouch;
    public GameObject positions;

    public Sprite[] heartSprites;
    public Image heartImage;

    private bool stateWinSound;

    #endregion

    #region UNITY_METHODS
    void Start()
    {
        
        _AudioManager = FindObjectOfType<AudioManager>();
        score = 0;
        stateWinSound = false;

    }
    void Update()
    {
        txtScore.text = "Score \n" + score;
        if (score >= maxScore)
        {
            Time.timeScale = 0;

            _AudioManager.StopLevelOneTheme();
            canvasButton.SetActive(false);
            canvas.SetActive(true);
            positions.SetActive(false);
            canvasScore.SetActive(false);
            canvasRedScreen.SetActive(false);
            canvasTime.SetActive(false);
            if (stateWinSound == false)
            {
                playWinSound();
            }
        }
    }

    #endregion


    #region CLASS_METHODS

    public void scoreTotal(int newScore)
    {
        score += newScore;
    }

    public void playWinSound()
    {
        _AudioManager.PlayWinLevel();
        stateWinSound = true;

    }

    #endregion

}
