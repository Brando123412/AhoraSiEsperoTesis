 using ScenesManager;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public enum TypeScene {SceneInstrucciones,ScenePrueba,SceneMenu,Scene1, Scene2, Scene3, Scene4, Scene5, Scene6, Scene7 };
public class ControladorScenes : MonoBehaviour
{
    [SerializeField] PlayerPositionReferences playerPositionReferences;
    [SerializeField] private GameEvent[] controllerScenes;



    private void Start()
    {
       controllerScenes[0].Raise();
    }
    private void Update()
    {
    }
    public void InicialScenes()
    {
    }

    public bool IsSceneLoaded(string sceneName)
    {
        Scene scene = SceneManager.GetSceneByName(sceneName);
        return scene.isLoaded;
    }
    public void positionUpdateType()
    {
        switch (playerPositionReferences.typeScenePlayer)
        {
            case TypeScene.Scene1:
                controllerScenes[0].Raise();
                print("Scene1");
                break;
            case TypeScene.Scene2:
                controllerScenes[1].Raise();
                print("Scene2");
                break;
            case TypeScene.Scene3:
                controllerScenes[2].Raise();
                print("Scene3");
                break;
            case TypeScene.Scene4:
                controllerScenes[3].Raise();
                print("Scene4");
                break;
            case TypeScene.Scene5:
                controllerScenes[4].Raise();
                print("Scene5");
                break;
            case TypeScene.Scene6:
                controllerScenes[5].Raise();
                print("Scene6");
                break;
            case TypeScene.Scene7:
                controllerScenes[6].Raise();
                print("Scene7");
                break;
        }
    }

    public void InvokeSceneAdditive(SceneConfiguration scene)
    {
        if (!IsSceneLoaded(scene.SceneName))
        {
            SceneGlobalManager.Instance.LoadScene(scene);
        }else if (IsSceneLoaded(scene.SceneName))
        {
            EnableGameObjects(scene);
        }
    }
    public void UnLoadSceneAdditive(SceneConfiguration scene)
    {
        if (IsSceneLoaded(scene.SceneName))
        {
            SceneGlobalManager.Instance.UnloadScene(scene);
        }
    }

    public void DisableGameObjects(SceneConfiguration scene)
    {
        scene.DisableGameObjects(this.gameObject);
    }

    public void EnableGameObjects(SceneConfiguration scene)
    {
        scene.EnableGameObjects(this.gameObject);
    }

}