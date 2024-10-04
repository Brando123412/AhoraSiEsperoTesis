using System;
using System.Collections;
using UnityEngine;
/*using Firebase.Database;
using Unity.VisualScripting;     */

[Serializable]
public class dataToSave
{
    public string userName;
    public int totalcoins;
    public int ccrLevel;
    public int highScore;
}
public class DataSaver : MonoBehaviour
{
    public dataToSave dts;
    public string userID;
    //DatabaseReference dbref;
    private void Awake()
    {
        //dbref = FirebaseDatabase.DefaultInstance.RootReference;
       // LoadDataFn();
    }
    private void Start()
    {

    }
    public void SaveDataFn()
    {
        string json = JsonUtility.ToJson(dts);
        //dbref.Child("user").Child(userID).SetRawJsonValueAsync(json);
    }      /*
    public void LoadDataFn()
    {
        StartCoroutine(LoadDataEnum());
    }     /*
    IEnumerator LoadDataEnum()
    {
        var serverData = dbref.Child("user").Child(userID).GetValueAsync();
        yield return new WaitUntil(predicate: () => serverData.IsCompleted);  //Esperar respuesta de la base de datos

        print("Complete");

        DataSnapshot snapshot = serverData.Result;
        string jsonData = snapshot.GetRawJsonValue();

        if (jsonData != null)
        {
            print("Sever data found");
            dts = JsonUtility.FromJson<dataToSave>(jsonData);
        }
        else
        {
            print("no data found");                                 
        }

    }     */
}
