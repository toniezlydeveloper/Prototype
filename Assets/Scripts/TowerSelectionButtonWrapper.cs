using System;
using UnityEngine;
using UnityEngine.UI;

namespace DefaultNamespace
{
    public class TowerSelectionButtonWrapper : MonoBehaviour, ITowerSelector
    {
        public event Action<TowerData> OnTowerSelected;

        [SerializeField] private TowerData storedTowerData;
        
        private void Start()
        {
            GetComponent<Button>().onClick.AddListener(() => OnTowerSelected?.Invoke(storedTowerData));
        }
    }
}