using ScenesManager;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControllerLoging : MonoBehaviour
{
    [SerializeField] private SceneConfiguration MainScene;
    [SerializeField] ChannelManager chanel1;
    private void Start()
    {
        SceneGlobalManager.OnStartProgress?.Invoke();
    }
    public void GoToSceneMenu()
    {
        SceneGlobalManager.OnFinishProgress?.Invoke();
        SceneGlobalManager.Instance.LoadScene(MainScene);
    }

    public void Hola()
    {
        print("Hola");
    }
}
