using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class RotateSpriteToFaceCameraAR : MonoBehaviour
{
    // Gets y Sets del transform a utilizar
    public Transform TargetTransform
    {
        get { return targetTransform; }
        set { targetTransform = value; }
    }

    // Variable que almacena la camara que quedara mirando el sprite
    [SerializeField] private Transform targetTransform;
    // Variable que verá como hacer el seguimiento de la camara en caso de que los Axis sean XY
    [SerializeField] private bool useCameraAsUpVector = false;

    /// <summary>
    /// Metodo que validara si a variable es nula, en caso de ser así, toma de referencia la main camera de unity
    /// </summary>   
    private void OnEnable()
    {
        // Validamos si la referencia es nula o no
        if (targetTransform == null)
        {
            // Asignamos la referencia de la camara a la del main
            targetTransform = Camera.main.transform;
        }
    }

    /// <summary>
    /// Update que mantiene al sprite mirando a la camara
    /// </summary>
    private void Update()
    {
        // Si mi target transform es nulo, retorna para no tirar referecias nulas
        if (targetTransform == null)
        {
            return;
        }

        // Se obtiene un vector que apunte desde el objetivo a la cámara principal
        Vector3 directionToTarget = targetTransform.position - transform.position;

        // Si estamos justo al lado de la cámara, la rotación es indefinida.
        if (directionToTarget.sqrMagnitude < 0.001f)
        {
            return;
        }

        // Calculamos y aplicamos la rotación necesaria para reorientar el objeto
        if (useCameraAsUpVector)
        {
            // Se rota el objeto con respencto a la camara
            transform.rotation = Quaternion.LookRotation(-directionToTarget, Camera.main.transform.up);
        }
        else
        {
            // Se rota el objeto con respencto a direccion del sprite
            transform.rotation = Quaternion.LookRotation(-directionToTarget);
        }
    }
}
