using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ControllerPresentation : MonoBehaviour
{
    [SerializeField] private Sprite[] presentationSprites;
    [SerializeField] private Image imagePresentation;
    private int index=0;
    //[SerializeField] GameEvent EventFinishCapacitation;

    
    public void NextPresentation()
    {
        if(index < presentationSprites.Length-1)
        {
            index++;
            imagePresentation.sprite = presentationSprites[index];
        }
        
        //if (index == presentationSprites.Length-2)
        //{
        //    EventFinishCapacitation.Raise();
        //}
    }
    public void PreviousPresentation()
    {
        if (index > 0)
        {
            index--;
            imagePresentation.sprite = presentationSprites[index];
        }

    }
}
