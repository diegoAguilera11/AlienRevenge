using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemyDefault : MonoBehaviour
{
    #region CLASS_VARIABLES
    public Transform[] pointToSpawn;
    public GameObject objectToSpawn;
    public bool canISpawn = false;
    public float timer = 2f;

    #endregion

    #region UNITY_METHODS
    void Start()
    {
        canISpawn = true;
    }
    void Update()
    {
        int randomNumber = Random.Range(0, pointToSpawn.Length);
        timer = timer - Time.deltaTime;

        if (canISpawn && timer < 0)
        {
            Instantiate(objectToSpawn, pointToSpawn[randomNumber]);
            timer = 2f;
        }

    }
    #endregion
}
