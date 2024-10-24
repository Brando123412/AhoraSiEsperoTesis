using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Antlr3.Runtime;
using UnityEngine;

public class DoorAnimatorController : MonoBehaviour
{
    [SerializeField] private Animator door1;
    [SerializeField] private Animator door2;
    [SerializeField] private Animator door3;
    [SerializeField] private bool isOpen1 = false;
    [SerializeField] private bool isOpen2 = false;
    [SerializeField] private bool isOpen3 = false;

    public void ToggleDoor1()
    {
        isOpen1 = !isOpen1;
        door1.SetBool("IsOpen", isOpen1);
    }

    public void ToggleDoor2()
    {
        isOpen2 = !isOpen2;
        door2.SetBool("IsOpen", isOpen2);
    }
    public void ToggleDoor3()
    {
        isOpen3 = !isOpen3;
        door3.SetBool("IsOpen", isOpen3);
    }
}
