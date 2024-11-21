using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[Serializable]

public class GameIntTwoEventListeners 
{
    [SerializeField] private string nameEventListener;
    public GameIntTwoEvent gameIntEvent;
    public UnityEvent<int,int> responde;
    public void OnEnable()
    {
        gameIntEvent.RegistryListaner(this);
    }
    public void OnDisable()
    {
        gameIntEvent.UnRegistryListaner(this);
    }
    public void OnRaiseNotified(int index, int value)
    {
        responde?.Invoke(index, value);
    }
}
