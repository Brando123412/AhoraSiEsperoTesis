using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ControllerPresentation : MonoBehaviour
{
    [SerializeField] private Sprite[] presentationSprites;
    [SerializeField] private Image imagePresentation;
    private int index=0;
    
    public void NextPresentation()
    {
        Debug.Log("Next");
        if(index < presentationSprites.Length-1)
        {
            index++;
            imagePresentation.sprite = presentationSprites[index];
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
