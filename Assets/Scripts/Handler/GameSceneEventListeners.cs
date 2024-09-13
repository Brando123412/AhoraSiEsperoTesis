using ScenesManager;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[Serializable]
public class GameSceneEventListeners 
{
    [SerializeField] private string nameEventListener;
    public GameSceneEvent gameIntEvent;
    public UnityEvent<SceneConfiguration> responde;
    public void OnEnable()
    {
        gameIntEvent.RegistryListaner(this);
    }
    public void OnDisable()
    {
        gameIntEvent.UnRegistryListaner(this);
    }
    public void OnRaiseNotified(SceneConfiguration value)
    {
        responde?.Invoke(value);
    }
}
