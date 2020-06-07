using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuManager : MonoBehaviour
{
    [SerializeField] Canvas levelCanvas;
    [SerializeField] Canvas menuCanvas;

    private void Start()
    {
        levelCanvas.gameObject.SetActive(false);
        menuCanvas.gameObject.SetActive(true);
    }
    public void ActivateLevelCanvas()
    {
        levelCanvas.gameObject.SetActive(true);
        menuCanvas.gameObject.SetActive(false);
    }
    public void ActivateMenuCanvas()
    {
        levelCanvas.gameObject.SetActive(false);
        menuCanvas.gameObject.SetActive(true);
    }
    public void ToggleSound()
    {
        AudioManager.Instance.toggleSound = !AudioManager.Instance.toggleSound;
    }
}
