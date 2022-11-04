using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PenguinCamera : MonoBehaviour
{
    public float offset = 2.0f; //�������� �� ��� X
    public bool faceleft; //����� ������� �����
    public Transform player; //������� ������
    

    // Start is called before the first frame update
    void Start()
    {
        // ������ ��������
        offset = Mathf.Abs(offset);
        player = GameObject.FindGameObjectWithTag("Player").transform;

    }

    // Update is called once per frame
    void Update()
    {
        // ������� ��������� � ����� Player
        if(faceleft) // ���� ������� �����
        {
            transform.position = new Vector3(player.position.x - offset, transform.position.y, transform.position.z);
        }
        else // ���� ������� ������
        {
            transform.position = new Vector3(player.position.x + offset, transform.position.y, transform.position.z);
        }

    }
}
