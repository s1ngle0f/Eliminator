using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarsLevels : MonoBehaviour
{
    public GameObject test;
    private void Start()
    {
        test = Resources.Load("Eliminator/Levels/4/lada_21099") as GameObject;
        Debug.Log(test?.GetType());
        var arr = Resources.LoadAll("Eliminator/Levels/4", typeof(GameObject));
        foreach (GameObject i in arr)
            Debug.Log(i.name);
    }

    //private void Update()
    //{
    //    Debug.Log(Random.RandomRange(0,2));
    //}
}
