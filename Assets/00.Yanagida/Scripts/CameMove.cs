using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameMove : MonoBehaviour
{
	

	
		public float speed = 5.0f;

	// Update is called once per frame
	void Update()
	{
		//Unity���ɃC���v�b�g����Ă���up���g���Ė��̏�������Ƃ��̕����ɓ�����B
		if (Input.GetKey("up"))
		{
			//�ꏊ�͉������������O�ɐi��Řb���Ǝ~�܂��B
			transform.position += transform.forward * speed * Time.deltaTime;
		}
		//����͉��B
		if (Input.GetKey("down"))
		{
			transform.position -= transform.forward * speed * Time.deltaTime;
		}
		//����͉E�B
		if (Input.GetKey("right"))
		{
			transform.position += transform.right * speed * Time.deltaTime;
		}
		//����͍��B
		if (Input.GetKey("left"))
		{
			transform.position -= transform.right * speed * Time.deltaTime;
		}
	}

}
