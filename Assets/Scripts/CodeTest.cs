using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CodeTest : MonoBehaviour
{
    [SerializeField] Button butonTestA;
    [SerializeField] Button butonTestB;
    private void Update()
    {
        if (Input.GetKeyUp(KeyCode.A))
        {
            butonTestA.onClick.Invoke();
            Debug.Log("Hola");
        }
        if (Input.GetKeyUp(KeyCode.S))
        {
            butonTestB.onClick.Invoke();
            Debug.Log("Hola");
        }
    }
}
