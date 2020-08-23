using System;
using System.Linq;
using UnityEngine;

namespace DefaultNamespace
{
    public class TowerCreator : MonoBehaviour
    {
        private void Awake()
        {
            foreach (ITowerSelector towerSelector in FindObjectsOfType<MonoBehaviour>().OfType<ITowerSelector>())
            {
                towerSelector.OnTowerSelected += CreateTower;
            }
        }

        private void CreateTower(TowerData obj)
        {
            Debug.Log("creating");
        }
    }
}