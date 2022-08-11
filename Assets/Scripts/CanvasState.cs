using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasState : MonoBehaviour
{
    public GameObject canvas;
    public GameObject canvasButton;
    private AudioManager _AudioManager;


    void Start()
    {
        _AudioManager = FindObjectOfType<AudioManager>();
    }

    public void loadCanvasOptions()
    {
        canvas.SetActive(true);
        _AudioManager.playSoundButton();
        canvasButton.SetActive(false);
    }

    public void closeCanvasOption()
    {
        canvas.SetActive(false);
        _AudioManager.playSoundButton();
        canvasButton.SetActive(true);
    }
}
