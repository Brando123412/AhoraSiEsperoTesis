using ScenesManager;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneInicialController : MonoBehaviour
{
    private void Awake()
    {
       
    }
    public void GoToGame(SceneConfiguration scene)
    {
        SceneGlobalManager.Instance.LoadScene(scene);
    }
}


