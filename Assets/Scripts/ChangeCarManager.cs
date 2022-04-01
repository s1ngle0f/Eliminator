using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeCarManager : MonoBehaviour
{
    public int CurrentLevel = 1;
    public GameObject enemyCar; // Delete it later

    private GameObject GetRandomCar()
    {
        var arr = Resources.LoadAll($"Eliminator/Levels/{CurrentLevel + 1}", typeof(GameObject));
        if (arr == null || arr.Length <= 0)
            arr = Resources.LoadAll($"Eliminator/Levels/{CurrentLevel}", typeof(GameObject));
        return (GameObject)arr[Random.RandomRange(0, arr.Length)];
    }
    public GameObject Replace(GameObject newCar)
    {
        GameObject nextCar = Instantiate(newCar, transform.position, transform.rotation);
        return nextCar;
    }
    public void Upgrade()
    {
        GameObject prefab = GetRandomCar();
        Destroy(this.gameObject);
        Replace(prefab);
    }

    public void TakeEnemyCar(GameObject enemyCar)
    {
        Destroy(this.gameObject);
        Replace(enemyCar);
    }

    private void Update()
    {
        //Test Start
        if (Input.GetKeyDown(KeyCode.R))
            Upgrade();
        if (Input.GetKeyDown(KeyCode.T))
            TakeEnemyCar(enemyCar);
        //Test End
    }
}
