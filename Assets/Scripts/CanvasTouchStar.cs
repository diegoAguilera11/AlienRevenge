using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasTouchStar : MonoBehaviour
{
    public GameObject starMessageCanvas;
    public void openMessage()
    {
        starMessageCanvas.SetActive(true);
    }
}
