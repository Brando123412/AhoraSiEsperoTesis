using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPositionReferences : MonoBehaviour
{
    public TypeScene typeScenePlayer;
    [SerializeField] ControladorScenes controllerScene;

    private void UpdatePostion()
    {
        if (transform.position.z >= -10 && transform.position.z <= 10)
        {
            print("Scena1");
            typeScenePlayer = TypeScene.Scene1;
        }
        else if (transform.position.z > -39.09f && transform.position.z <= -10)
        {
            print("Scena2");
            typeScenePlayer = TypeScene.Scene2;
        }
        else if (transform.position.z > -68.25f && transform.position.z <= -39.09f)
        {
            print("Scena3");
            typeScenePlayer = TypeScene.Scene3;
        }
        else if (transform.position.z > -97.5f && transform.position.z <= -68.25f)
        {
            print("Scena4");
            typeScenePlayer = TypeScene.Scene4;
        }
        else if (transform.position.z > -126.66f && transform.position.z <= -97.5f)
        {
            print("Scena5");
            typeScenePlayer = TypeScene.Scene5;
        }
        else if (transform.position.z > -155.88f && transform.position.z <= -126.66f)
        {
            print("Scena6");
            typeScenePlayer = TypeScene.Scene6;
        }
        else if (transform.position.z > -200.3f && transform.position.z <= -155.88f)
        {
            print("Scena7");
            typeScenePlayer = TypeScene.Scene7;
        }
        else {
            print("Estas fuera");
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Prueba"))
        {
            UpdatePostion();
            controllerScene.positionUpdateType();
        }
    }

}
