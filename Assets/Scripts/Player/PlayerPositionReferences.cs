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
        else if (transform.position.z > -40 && transform.position.z <= -10)
        {
            print("Scena2");
            typeScenePlayer = TypeScene.Scene2;
        }
        else if (transform.position.z > -70 && transform.position.z <= -40)
        {
            print("Scena3");
            typeScenePlayer = TypeScene.Scene3;
        }
        else if (transform.position.z > -100 && transform.position.z <= -70)
        {
            print("Scena4");
            typeScenePlayer = TypeScene.Scene4;
        }
        else if (transform.position.z > -130 && transform.position.z <= -100)
        {
            print("Scena5");
            typeScenePlayer = TypeScene.Scene5;
        }
        else if (transform.position.z > -160 && transform.position.z <= -130)
        {
            print("Scena6");
            typeScenePlayer = TypeScene.Scene6;
        }
        else if (transform.position.z > -190 && transform.position.z <= -160)
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
