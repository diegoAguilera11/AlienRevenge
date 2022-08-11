using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossTouch : MonoBehaviour
{
    #region CLASS_VARIABLES
    private BossHealth _EnemyHealthBoss;
    public bool stateTouch;
    private string name_tag;

    #endregion

    #region CLASS_METHODS 
    void Update()
    {
        touchAlien();
    }
    private void OnMouseDown()
    {

    }


    public void touchAlien()
    {
        if (Input.touchCount > 0 && stateTouch == true)
        {
            Touch touch = Input.GetTouch(0);

            if (touch.phase == TouchPhase.Began)
            {

                Ray ray = Camera.main.ScreenPointToRay(touch.position);
                RaycastHit2D hit = Physics2D.Raycast(transform.position, ray.direction);
                float rayDistance = 100f;

                Debug.DrawRay(ray.origin, ray.direction * rayDistance, Color.green);

                if (hit.collider != null && stateTouch == true)
                {
                    _EnemyHealthBoss = hit.collider.GetComponent<BossHealth>();
                    Debug.Log("......");
                    _EnemyHealthBoss.collisionAlien();

                }
            }
        }

        /*if (Input.GetMouseButtonDown(0) == true && stateTouch == true)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast(transform.position, ray.direction);

            float rayDistance = 100f;

            Debug.DrawRay(ray.origin, ray.direction * rayDistance, Color.green);

            if (hit.collider != null)
            {
                Debug.Log("......");
                _EnemyHealth.collisionAlien();

            }


        }*/

        if (Input.GetMouseButtonDown(0) == true && stateTouch == true)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;


            float rayDistance = 100f;

            Debug.DrawRay(ray.origin, ray.direction * rayDistance, Color.green);

            if (Physics.Raycast(ray, out hit) == true)
            {
                name_tag = hit.transform.tag;

                if (name_tag.Equals("Boss"))
                {
                    _EnemyHealthBoss = hit.collider.GetComponent<BossHealth>();
                    Debug.Log("......");
                    _EnemyHealthBoss.collisionAlien();
                }

            }


        }

    }
    #endregion
}
