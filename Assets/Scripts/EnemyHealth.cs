using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    #region CLASS_VARIABLES
    public int quantityTouches;
    public int maxQuantityTouches;
    private AudioManager _AudioManager;
    private HudManager _hudManager;
    #endregion

    #region CLASS_METHODS 

    void Start()
    {
        _AudioManager = FindObjectOfType<AudioManager>();
        _hudManager = FindObjectOfType<HudManager>();
        quantityTouches = 0;
    }    
    public void collisionAlien()
    {
        _AudioManager.PlayShotSound();
        Debug.Log("Estas tocando");
        quantityTouches++;
        if (quantityTouches == maxQuantityTouches)
        {
            quantityTouches = 0;
            Score();
            DestroyAlien();
        }


    }
    public void DestroyAlien()
    {
        this.gameObject.SetActive(false);

    }
    void Score()
    {
        _hudManager.scoreTotal(100);
    }

    #endregion
}
