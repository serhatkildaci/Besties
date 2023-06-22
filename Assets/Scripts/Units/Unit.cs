using System.Collections;
using System.Collections.Generic;
using Mirror;
using UnityEngine;
using UnityEngine.Events;

public class Unit : NetworkBehaviour
{
    [SerializeField] private UnitMovement unitMovement = null;
    [SerializeField] private UnityEvent onSelected = null;
    [SerializeField] private UnityEvent onDeselect = null;

    public UnitMovement GetUnitMovement()
    {
        return unitMovement;
    }

    #region Client

    public void Select()
    {
        if (!isOwned)
            return;
        
        onSelected?.Invoke();
    }

    public void Deselect()
    {
        if (!isOwned)
            return;
        
        onDeselect?.Invoke();
    }

    #endregion
}
