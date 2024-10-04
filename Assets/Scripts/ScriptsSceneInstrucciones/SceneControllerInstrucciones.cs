using ScenesManager;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneControllerInstrucciones : MonoBehaviour
{
    [Header("Scenes SO")]
    [SerializeField] private SceneConfiguration sceneMenu;

    private void Start()
    {
        SceneGlobalManager.OnStartProgress?.Invoke();
    }
    public void ReturnMenu()
    {
        SceneGlobalManager.OnFinishProgress?.Invoke();
        SceneGlobalManager.Instance.LoadScene(sceneMenu);
    }
    public void SetObjectTrue(GameObject objectReferences)
    {
        objectReferences.SetActive(true);
    }
    public void SetObjectfalse(GameObject objectReferences)
    {
        objectReferences.SetActive(false);
    }
}
