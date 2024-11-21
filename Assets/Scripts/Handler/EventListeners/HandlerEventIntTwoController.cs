using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandlerEventIntTwoController : MonoBehaviour
{
    [SerializeField] EventListenersIntTwo eventListenersIntTwo;
    private void OnEnable()
    {
        for (int i = 0; i < eventListenersIntTwo.SOEvent.Count; i++)
        {
            eventListenersIntTwo.SOEvent[i].OnEnable();
        }
    }
    private void OnDisable()
    {
        for (int i = 0; i < eventListenersIntTwo.SOEvent.Count; i++)
        {
            eventListenersIntTwo.SOEvent[i].OnDisable();
        }
    }

}
[Serializable]
public class EventListenersIntTwo
{
    public List<GameIntTwoEventListeners> SOEvent;
}
