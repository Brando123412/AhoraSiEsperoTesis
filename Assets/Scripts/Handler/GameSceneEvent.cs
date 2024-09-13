using ScenesManager;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "ScriptableObject", menuName = "ScriptableObjects/GameSceneEvent", order = 1)]
public class GameSceneEvent : ScriptableObject
{
    private List<GameSceneEventListeners> gameListeners;
    public void Raise(SceneConfiguration value)
    {
        foreach (var listener in gameListeners)
        {
            listener.OnRaiseNotified(value);
        }
    }
    public void RegistryListaner(GameSceneEventListeners gameListener)
    {
        gameListeners.Add(gameListener);
    }
    public void UnRegistryListaner(GameSceneEventListeners gameListener)
    {
        if (gameListeners.Contains(gameListener))
        {
            gameListeners.Remove(gameListener);
        }
    }
}
