using System;
using DefaultNamespace;

public interface ITowerSelector
{
    event Action<TowerData> OnTowerSelected;
}