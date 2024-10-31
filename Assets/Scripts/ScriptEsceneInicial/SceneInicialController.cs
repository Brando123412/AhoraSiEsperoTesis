using ScenesManager;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SceneInicialController : MonoBehaviour
{
    [SerializeField] int misiones;
    [SerializeField] Toggle[] ArregloObjetivos;
    private void Awake()
    {
       
    }
    public void GoToGame(SceneConfiguration scene)
    {
        SceneGlobalManager.Instance.LoadScene(scene);
    }
    public void asd()
    {
        ArregloObjetivos[1].isOn = true;
    }
    public void CheckWork(int i){
        ArregloObjetivos[i].isOn = true;
    }
}


