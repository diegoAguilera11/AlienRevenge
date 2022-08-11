using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class messageLevelOne : MonoBehaviour
{
    public GameObject messageCanvas;
    public GameObject nextLevelCanvas;
    public void closeMessage()
    {
        messageCanvas.SetActive(false);
        nextLevelCanvas.SetActive(true);
    }
}
