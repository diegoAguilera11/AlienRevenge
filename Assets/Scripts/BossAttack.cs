using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossAttack : MonoBehaviour
{
    #region CLASS_VARIABLE
    public int damagePoints;

    PlayerHealthBoss _playerHealthBoss;

    float tiempo;

    #endregion


    void Start()
    {
        _playerHealthBoss = FindObjectOfType<PlayerHealthBoss>();

    }
    private void Update()
    {
        tiempo += Time.deltaTime;
        if (tiempo >= 8f)
        {
            attackPlayer();
            tiempo = 0;

        }
    }


    #region CLASS_METHODS
    public void attackPlayer()
    {

        _playerHealthBoss.takeDamege(damagePoints);

    }

    #endregion
}
