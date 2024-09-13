using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandlerEventSceneController : MonoBehaviour
{
    public EventListenersScene EventListenersScene;
    private void OnEnable()
    {
        for (int i = 0; i < EventListenersScene.SOEvent.Count; i++)
        {
            EventListenersScene.SOEvent[i].OnEnable();
        }
    }
    private void OnDisable()
    {
        for (int i = 0; i < EventListenersScene.SOEvent.Count; i++)
        {
            EventListenersScene.SOEvent[i].OnDisable();
        }
    }
}

[Serializable]
public class EventListenersScene
{
    public List<GameSceneEventListeners> SOEvent = new();
}