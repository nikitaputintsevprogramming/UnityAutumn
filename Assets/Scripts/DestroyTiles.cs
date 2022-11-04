using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class DestroyTiles : MonoBehaviour
{
    public Tilemap tilemapLayer1;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos=Camera.main.ScreenToWorldPoint(Input.mousePosition);

        if(Input.GetMouseButtonDown(0))
        {
            Vector3Int selectedTile = tilemapLayer1.WorldToCell(pos);
            tilemapLayer1.SetTile(selectedTile, null);
        }
    }
}
   
