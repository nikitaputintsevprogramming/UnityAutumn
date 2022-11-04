using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

	public float speed = 6.0F; //скорость
	public float jumpValue = 8.0F; // высота прыжка
	public float gravity = 20.0F; // гравитация
	private Vector3 moveDirection = Vector3.zero; //направление движения
	void Update () {

		/// Получаем компонент CharacterController, который только что добавили к капсуле
		CharacterController controller = GetComponent<CharacterController>();
		if (controller.isGrounded)///Если контролер стоит на земле
		{
			//двигаем объект по горизонтали и вертикали с помощью установленных по умолчанию кнопок
			moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));

			/// Преобразуем кординаты текущего объекта из локальных в  world space
			moveDirection = transform.TransformDirection(moveDirection);

			moveDirection *= speed;
			if (Input.GetButton("Jump"))///Проверка на нажатие кнопки прыжка
				/// Тут выставляется высота Y вектора, не положение объекта
				moveDirection.y = jumpValue;
		}

		/// Работаем с гравитацией
		moveDirection.y -= gravity * Time.deltaTime;
		controller.Move(moveDirection * Time.deltaTime);
		
	}
}
