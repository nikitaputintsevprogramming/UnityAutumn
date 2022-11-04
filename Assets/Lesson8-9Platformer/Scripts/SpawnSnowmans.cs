using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnSnowmans : MonoBehaviour
{
    public GameObject prefab; // ���� ����� ���������? � Unity ��������� ����������
    public int SpawnTime = 10;

    // Start is called before the first frame update
    void Start()
    {
        // InvokeRepeating(��� ������, ����� ������� ������� ��� �������, ��� ����� ���������)
        InvokeRepeating("prefabSpawn", SpawnTime * 10.5f, Random.value * SpawnTime);
    }

    // Update is called once per frame
    void Update()
    {
        // Instantiate - ������� ������ �� ������ �������
        GameObject newSnowman = Instantiate(prefab, transform.position, Quaternion.identity) as GameObject;
    }
}
