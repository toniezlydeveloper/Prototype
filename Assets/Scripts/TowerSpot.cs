using System;
using UnityEngine;

public class TowerSpot : MonoBehaviour, IInteractable
{
    [SerializeField] private TowerSelectionBar selectionBar;

    public void Interact()
    {
        selectionBar.Toggle();
    }
}