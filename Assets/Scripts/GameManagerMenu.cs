using ScenesManager;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManagerMenu : MonoBehaviour
{
    [Header("Scenes SO")]
    [SerializeField] private SceneConfiguration scenePrueba;
    [SerializeField] private SceneConfiguration sceneSelection;
    [SerializeField] Slider[] sliderButton;
    [SerializeField] ChannelManager[] SOChanelManager;

    private void Start()
    {
        SceneGlobalManager.OnStartProgress?.Invoke();
        SOManager();
    }
    public void GoToSceneTest()
    {
        SceneGlobalManager.OnFinishProgress?.Invoke();
        SceneGlobalManager.Instance.LoadScene(scenePrueba);
    }
    public void GoToSceneInstrucciones()
    {
        SceneGlobalManager.OnFinishProgress?.Invoke();
        SceneGlobalManager.Instance.LoadScene(sceneSelection);
    }
    public void QuitApplication()           
    {
        Application.Quit();
    }
    public void SetObjectTrue(GameObject objectReferences)
    {
        objectReferences.SetActive(true);
    }
    public void SetObjectfalse(GameObject objectReferences)
    {
        objectReferences.SetActive(false);
    }
    public void SOManager()
    {
        print("Hola Perro");
        sliderButton[0].value = SOChanelManager[0].currentVolume;
        sliderButton[1].value = SOChanelManager[1].currentVolume;
        sliderButton[2].value = SOChanelManager[2].currentVolume;
    }
    public void ButtonConfigAdelante(RectTransform panel)
    {
        panel.localPosition= new Vector3(0,0,-3);
    }

}
