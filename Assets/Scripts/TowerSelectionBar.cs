using System;
using DefaultNamespace;
using UnityEngine;

public class TowerSelectionBar : MonoBehaviour
{
    private static TowerSelectionBar _activeSelectionBar;

    private void Start()
    {
        Disable();
    }

    public void Toggle()
    {
        DisableActive();
        Enable();
    }

    public static void DisableActive()
    {
        if (_activeSelectionBar == null)
        {
            return;
        }
            
        _activeSelectionBar.gameObject.SetActive(false);
        _activeSelectionBar = null;
    }

    private void Enable()
    {
        gameObject.SetActive(true);
        _activeSelectionBar = this;
    }

    private void Disable()
    {
        gameObject.SetActive(false);
    }
}