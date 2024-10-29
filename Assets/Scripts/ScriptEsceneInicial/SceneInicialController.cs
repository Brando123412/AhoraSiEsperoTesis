using ScenesManager;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneInicialController : MonoBehaviour
{
    [SerializeField] int misiones;

    public void GoToGame(SceneConfiguration scene)
    {
        SceneGlobalManager.Instance.LoadScene(scene);
    }

}
