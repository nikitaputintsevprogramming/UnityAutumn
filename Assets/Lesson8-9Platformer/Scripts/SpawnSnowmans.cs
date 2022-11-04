using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnSnowmans : MonoBehaviour
{
    public GameObject prefab; // кого будем создавать? в Unity заполнить переменную
    public int SpawnTime = 10;

    // Start is called before the first frame update
    void Start()
    {
        // InvokeRepeating(Имя метода, через сколько вызвать при запуске, как часто повторять)
        InvokeRepeating("prefabSpawn", SpawnTime * 10.5f, Random.value * SpawnTime);
    }

    // Update is called once per frame
    void Update()
    {
        // Instantiate - создаем объект на основе префаба
        GameObject newSnowman = Instantiate(prefab, transform.position, Quaternion.identity) as GameObject;
    }
}
