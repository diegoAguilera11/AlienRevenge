using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAtack : MonoBehaviour
{
    #region CLASS_VARIABLE
    public int damagePoints;

    PlayerHealth _playerHealth;

    float tiempo;

    #endregion


    void Start()
    {
        _playerHealth = FindObjectOfType<PlayerHealth>();

    }
    private void Update()
    {
        tiempo += Time.deltaTime;
        if (tiempo >= 5f)
        {
            attackPlayer();
            tiempo = 0;

        }
    }


    #region CLASS_METHODS
    public void attackPlayer()
    {

        _playerHealth.takeDamege(damagePoints);

    }

    #endregion

}
