using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveScript : MonoBehaviour {

	public Transform Target; //позиция цели
	public float Speed; // скорость движения

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		//меняем позицию объекта каждый раз в напровлении цели
		//Vector3 (класс для манимулирования объектами по 3 координатам (x,y,z))

		if (Vector3.Distance (transform.position, Target.position) > 1.1f) {
			Speed += 0.08f;
			float step = Speed * Time.deltaTime; // скорость * время между кадрами
			transform.position = Vector3.MoveTowards (transform.position, Target.position, step); 
		} else {
			Destroy (gameObject,0.2f);
		}
	}
}
