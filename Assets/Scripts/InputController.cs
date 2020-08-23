using System;
using UnityEngine;

public class InputController : MonoBehaviour
{
    private Camera _mainCamera;
        
    private void Start()
    {
        _mainCamera = Camera.main;
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            ToggleSelectionBar();
        }
    }

    private void ToggleSelectionBar()
    {
        Ray ray = _mainCamera.ScreenPointToRay(Input.mousePosition);

        if (!Physics.Raycast(ray, out RaycastHit hit))
        {
            return;
        }
        
        if (hit.transform.TryGetComponent(out IInteractable interactable))
        {
            interactable.Interact();
        }
        else
        {
            TowerSelectionBar.DisableActive();
        }
    }
}