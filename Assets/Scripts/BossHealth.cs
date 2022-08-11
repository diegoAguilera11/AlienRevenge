using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossHealth : MonoBehaviour
{
    #region CLASS_VARIABLES
    public int quantityTouches;
    public int maxQuantityTouches;
    private AudioManager _AudioManager;
    private HudManagerBoss _hudManagerBoss;
    #endregion

    #region CLASS_METHODS 

    void Start()
    {
        _AudioManager = FindObjectOfType<AudioManager>();
        _hudManagerBoss = FindObjectOfType<HudManagerBoss>();
        quantityTouches = 0;
    }    
    public void collisionAlien()
    {
        _AudioManager.PlayShotSound();
        Debug.Log("Estas tocando");
        quantityTouches++;
        DamageBoss();
        if (quantityTouches == maxQuantityTouches)
        {
            quantityTouches = 0;
            DamageBoss();
            DestroyAlien();
        }


    }
    public void DestroyAlien()
    {
        this.gameObject.SetActive(false);

    }
    void DamageBoss()
    {
        _hudManagerBoss.bossLife(1);
    }

    #endregion
}
