using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PenguinCamera : MonoBehaviour
{
    public float offset = 2.0f; //смещение по оси X
    public bool faceleft; //игрок смотрит влево
    public Transform player; //позиция игрока
    

    // Start is called before the first frame update
    void Start()
    {
        // задаем смещение
        offset = Mathf.Abs(offset);
        player = GameObject.FindGameObjectWithTag("Player").transform;

    }

    // Update is called once per frame
    void Update()
    {
        // находим персонажа с тегом Player
        if(faceleft) // если смотрит влево
        {
            transform.position = new Vector3(player.position.x - offset, transform.position.y, transform.position.z);
        }
        else // если смотрит вправо
        {
            transform.position = new Vector3(player.position.x + offset, transform.position.y, transform.position.z);
        }

    }
}
