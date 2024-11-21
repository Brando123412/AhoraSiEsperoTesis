using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[CreateAssetMenu(fileName = "ScriptableObject", menuName = "ScriptableObjects/GameIntEventTwo", order = 1)]
public class GameIntTwoEvent : ScriptableObject
{
    private List<GameIntTwoEventListeners> gameListeners;
    private void OnEnable()
    {
        gameListeners = new();
    }
    private void OnDisable()
    {
        gameListeners.Clear();
    }
    public void Raise(int index, int value)
    {
        foreach (var listener in gameListeners)
        {
            listener.OnRaiseNotified(index,value);
        }
    }
    public void RegistryListaner(GameIntTwoEventListeners gameListener)
    {
        gameListeners.Add(gameListener);
    }
    public void UnRegistryListaner(GameIntTwoEventListeners gameListener)
    {
        if (gameListeners.Contains(gameListener))
        {
            gameListeners.Remove(gameListener);
        }
    }
}
