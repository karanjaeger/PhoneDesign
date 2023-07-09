using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class PhoneController : MonoBehaviour
{
    public Sprite[] phoneColors; 
    public Sprite[] frontPanels;
    public Sprite[] cameraPlacements;
    public Button publishButton;
    public Bridge bridge;
    public Image winScreen;

    public Image phoneColorRenderer;
    public Image frontPanelRenderer;
    public Image cameraPlacementRenderer;

    private int currentColorIndex = 0;
    private int currentFrontPanelIndex = 0;
    private int currentCameraIndex = 0;

    private int counter;
    private int randomNum;

    private void Start()
    {
        phoneColorRenderer.sprite = phoneColors[currentColorIndex];
        frontPanelRenderer.sprite = frontPanels[currentFrontPanelIndex];
        cameraPlacementRenderer.sprite = cameraPlacements[currentCameraIndex];
        publishButton.interactable = false;
        winScreen.enabled = false;
    }

    private void IncrementCounter()
    {
        counter++;
        if(counter >= 3)
        {
            publishButton.interactable = true;
        }
    }
    public void ColorYellow()
    {
        phoneColorRenderer.sprite = phoneColors[0];
        if(phoneColorRenderer.sprite == phoneColors[0])
        {
            IncrementCounter();
        }
    }
    public void ColorRed()
    {
        phoneColorRenderer.sprite = phoneColors[1];
        if (phoneColorRenderer.sprite == phoneColors[1])
        {
            IncrementCounter();
        }
    }

    public void ColorBlue() 
    {
        phoneColorRenderer.sprite = phoneColors[2];
        if (phoneColorRenderer.sprite == phoneColors[2])
        {
            IncrementCounter();
        }
    }

    public void Fit()
    {
        frontPanelRenderer.sprite = frontPanels[0];
        if (frontPanelRenderer.sprite == frontPanels[0])
        {
            IncrementCounter();
        }
    }

    public void Wide()
    {
        frontPanelRenderer.sprite = frontPanels[1];
        if (frontPanelRenderer.sprite == frontPanels[1])
        {
            IncrementCounter();
        }
    }

    public void Narrow()
    {
        frontPanelRenderer.sprite = frontPanels[2];
        if (frontPanelRenderer.sprite == frontPanels[2])
        {
            IncrementCounter();
        }
    }

    public void CameraOne()
    {
        cameraPlacementRenderer.sprite = cameraPlacements[0];
        if (cameraPlacementRenderer.sprite == cameraPlacements[0])
        {
            IncrementCounter();
        }
    }

    public void CameraTwo()
    {
        cameraPlacementRenderer.sprite = cameraPlacements[1];
        if (cameraPlacementRenderer.sprite == cameraPlacements[1])
        {
            IncrementCounter();
        }
    }

    public void CameraThree()
    {
        cameraPlacementRenderer.sprite = cameraPlacements[2];
        if (cameraPlacementRenderer.sprite == cameraPlacements[2])
        {
            IncrementCounter();
        }
    }

    private IEnumerator GameEndCall(String status)
    {
        publishButton.enabled = false;
        yield return new WaitForSeconds(2);
        winScreen.enabled = true;
        yield return new WaitForSeconds(2);
        bridge.TriggerWebCall(status);

    }

    public void RandomNumberGenerator()
    {
        randomNum = UnityEngine.Random.Range(1, 11);
        Debug.Log(randomNum);
        if(randomNum < 4)
        {
            StartCoroutine(GameEndCall("failScenario"));
            Debug.Log("150Cr");
        }
        else
        {
            StartCoroutine(GameEndCall("winScenario"));
            Debug.Log("300Cr");
        }
    }

    

}
