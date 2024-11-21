using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControllerPresentation : MonoBehaviour
{
    [SerializeField] private Sprite[] presentationSprites;
    [SerializeField] private Image imagePresentation;
    private int index=0;
    [SerializeField] bool SeVioTodasLasPresentaciones = false;
    [SerializeField] GameIntTwoEvent tareasController;
    
    public void NextPresentation()
    {
        Debug.Log("Next");
        if(index < presentationSprites.Length-1)
        {
            index++;
            imagePresentation.sprite = presentationSprites[index];
            if (index == presentationSprites.Length - 1 && !SeVioTodasLasPresentaciones)
            {
                tareasController.Raise(0, 1);
                SeVioTodasLasPresentaciones = true;
            }   
        }
        
    }
    public void PreviousPresentation()
    {
        Debug.Log("Previous");
        if (index > 0)
        {
            index--;
            imagePresentation.sprite = presentationSprites[index];
        }

    }
}
