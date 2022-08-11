using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class HudManagerBoss : MonoBehaviour
{
    #region CLASS_VARIABLES

    private int BosslifePoints = 50;
    public GameObject canvas;
    public GameObject canvasLifeBoss;

    public GameObject canvasLifePoints;

    public GameObject canvasRedScreen;

    public GameObject canvasHack;

    public GameObject canvasTime;

    public GameObject canvasButton;
    public TextMeshProUGUI txtLifePointsBoss;

    private AudioManager _AudioManager;
    private DestroyOnTouch _DestroyOnTouch;

    private LoadSceneLevel _loadScenLevel;
    public Sprite[] heartSprites;
    public Image heartImage;

    private bool stateEffectBoss;

    private bool stateWinGameSound;

    #endregion

    #region UNITY_METHODS
    void Start()
    {
        _AudioManager = FindObjectOfType<AudioManager>();
        _loadScenLevel = FindObjectOfType<LoadSceneLevel>();

        stateEffectBoss = false;
        _loadScenLevel.stateLevelOne = true;
        stateWinGameSound = false;

    }
    void Update()
    {
        txtLifePointsBoss.text = "Boss life \n" + BosslifePoints;

        if (BosslifePoints == 25 && stateEffectBoss == false)
        {
            effectBoss();
        }


        if (BosslifePoints <= 0)
        {
            Time.timeScale = 0;
            _AudioManager.StopLevelBossTheme();
            canvasButton.SetActive(false);
            canvasLifePoints.SetActive(false);
            canvasLifeBoss.SetActive(false);
            canvas.SetActive(true);
            canvasRedScreen.SetActive(false);
            canvasTime.SetActive(false);
            if (stateWinGameSound == false)
            {
                playWinGame();
            }
        }
    }

    #endregion


    #region CLASS_METHODS
    public void bossLife(int touch)
    {
        BosslifePoints -= touch;
    }

    public void effectBoss()
    {
        if (stateEffectBoss == false)
        {
            canvasHack.SetActive(true);
            stateEffectBoss = true;
            Invoke("effectBoss", 5f);
        }
        else if (stateEffectBoss == true)
        {
            canvasHack.SetActive(false);
        }
    }

    public void playWinGame()
    {
        _AudioManager.PlayWinGame();
        stateWinGameSound = true;
    }

    #endregion
}
