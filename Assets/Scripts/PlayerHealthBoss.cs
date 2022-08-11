using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealthBoss : MonoBehaviour
{
    #region CLASS_VARIABLES
    private int lifePoints = 3;

    public Sprite[] heart;
    public GameObject Canvas;//Screen You Lose

    public GameObject Canvas2;//Score
    public GameObject Canvas3;//Button

    public GameObject Canvas4;//Screen red

    public GameObject Canvas5; //Screen heart

    public GameObject Canvas6;

    public GameObject kingAlien;
    private bool stateEffect;

    private bool stateGameOver = false;
    private HudManagerBoss _hudManagerBoss;

    private AudioManager _AudioManager;

    private LoadSceneLevel _loadScene;

    #endregion

    #region  UNITY_METHODS

    private void Start()
    {
        stateGameOver = false;
        _hudManagerBoss = FindObjectOfType<HudManagerBoss>();
        _AudioManager = FindObjectOfType<AudioManager>();
        Time.timeScale = 1;
        _AudioManager.PlayLevelBosstheme();
        lifePoints = 3;
        stateEffect = false;
        Canvas.SetActive(false);
        Canvas2.SetActive(true);
        Canvas3.SetActive(true);
        Canvas5.SetActive(true);
        Canvas6.SetActive(true);
        Canvas4.SetActive(false);
        Invoke("activeBoss", 6f);
    }
    private void Update()
    {
        if (lifePoints <= 0)
        {
            ChangeHeartSprite();
            _AudioManager.StopLevelBossTheme();
            Time.timeScale = 0;
            if (stateGameOver == false)
            {
                _AudioManager.PlayGameOverSound();
                stateGameOver = true;

            }
            kingAlien.SetActive(false);
            Canvas.SetActive(true);
            Canvas2.SetActive(false);
            Canvas3.SetActive(false);
            Canvas4.SetActive(false);
            Canvas6.SetActive(false);
        }
        ChangeHeartSprite();
    }

    #endregion

    #region CLASS_METHODS
    public void takeDamege(int damagePoints)
    {

        lifePoints = lifePoints - damagePoints;
        _AudioManager.PlayShotPlayerDamage();
        Effect();
        Debug.Log("Tu vida es: " + lifePoints);
        Invoke("Effect", 0.5f);

    }

    void Effect()
    {
        if (stateEffect == false)
        {
            Canvas4.SetActive(true);
            stateEffect = true;
        }
        else if (stateEffect == true)
        {
            Canvas4.SetActive(false);
            stateEffect = false;
        }

    }
    public void activeBoss()
    {
        kingAlien.SetActive(true);
    }
    public void ChangeHeartSprite()
    {

        if (lifePoints == 3)
        {
            _hudManagerBoss.heartImage.sprite = _hudManagerBoss.heartSprites[0];

        }
        if (lifePoints == 2)
        {
            _hudManagerBoss.heartImage.sprite = _hudManagerBoss.heartSprites[1];

        }
        if (lifePoints == 1)
        {
            _hudManagerBoss.heartImage.sprite = _hudManagerBoss.heartSprites[2];

        }
        if (lifePoints == 0)
        {
            _hudManagerBoss.heartImage.sprite = _hudManagerBoss.heartSprites[3];

        }
    }
    #endregion
}
