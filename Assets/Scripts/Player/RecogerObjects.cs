using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class RecogerObjects : MonoBehaviour
{
    [SerializeField] List<GameObject> objects = new();
    [SerializeField] int cambiarObjects;
    [SerializeField] Transform positionMano;
    bool agarrarConditions = false;
    [SerializeField] GameObject objetoAgarrar;
    [SerializeField] int countObjects;
    private void Update()
    {
        countObjects = objects.Count;
    }
    #region Inputs
    void OnRecojerObjects(InputValue value)
    {
        if (value.isPressed && agarrarConditions)
        {
            Agarrar();
            ChangeObject();
        }
    }
    void OnCambiarObjets(InputValue value)
    {
        float currentValue = value.Get<Vector2>().y;
        if (currentValue != 0)
        {
            UpdateCurrentObjectIndex(currentValue);
            ChangeObject();
        }   
    }
    void OnBotarObjets(InputValue value)
    {
        if (value.isPressed && objects.Count > 0)
        {
            objects[cambiarObjects].tag = "Objetos";
            objects[cambiarObjects].transform.parent = null;
            objects.Remove(objects[cambiarObjects]);
        }
    }
    #endregion
    private void UpdateCurrentObjectIndex(float scrollValue)
    {
        if (scrollValue > 0)
            cambiarObjects++;
        else
            cambiarObjects--;

        if (cambiarObjects >= objects.Count)
            cambiarObjects = 0;
        else if (cambiarObjects < 0)
            cambiarObjects = objects.Count - 1;
    }
    private void ChangeObject()
    {
        if (objects.Count >0)
        {
            foreach (GameObject obj in objects)
            {
                obj.SetActive(false);
            }
            objects[cambiarObjects].SetActive(true);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Objetos"))
        {
            print("Hola");
            agarrarConditions = true;
            objetoAgarrar = other.gameObject;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Objetos"))
        {
            agarrarConditions = false;
            objetoAgarrar = null;
        }
    }
    void Agarrar()
    {
        objetoAgarrar.tag = "ObjetoNull";
        objetoAgarrar.gameObject.transform.SetParent(positionMano);
        objetoAgarrar.gameObject.transform.localPosition = Vector3.zero;
        objects.Add(objetoAgarrar.gameObject);      
    }
}
