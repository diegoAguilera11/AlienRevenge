using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DestroyOnTouch : MonoBehaviour
{

    #region CLASS_VARIABLES
    private EnemyHealth _EnemyHealth;
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
                    _EnemyHealth = hit.collider.GetComponent<EnemyHealth>();
                    Debug.Log("......");
                    _EnemyHealth.collisionAlien();

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

                if (name_tag.Equals("AlienDefault"))
                {
                    _EnemyHealth = hit.collider.GetComponent<EnemyHealth>();
                    Debug.Log("......");
                    _EnemyHealth.collisionAlien();
                }

            }


        }

    }
    #endregion
}
