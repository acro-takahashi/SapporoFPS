using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FPS
{

    public class CameDeath : MonoBehaviour
    {


        [Range(0.1f, 10f)]
        //�J�������x�A���l���傫���قǂ�蒼���I�ȑ��삪�\.
        public float lookSensitivity = 5f;
        [Range(0.1f, 1f)]
        //���l���傫���قǃJ�������������������Ɍ����܂ł̎��Ԃ������Ȃ�.
        public float lookSmooth = 0.1f;

        public Vector2 MinMaxAngle = new Vector2(-65, 65);

        private float yRot;
        private float xRot;

        private float currentYRot;
        private float currentXRot;

        private float yRotVelocity;
        private float xRotVelocity;

        void Update()
        {

            yRot += Input.GetAxis("Mouse X") * lookSensitivity; //�}�E�X�̈ړ�.
            xRot -= Input.GetAxis("Mouse Y") * lookSensitivity; //�}�E�X�̈ړ�.



            xRot = Mathf.Clamp(xRot, MinMaxAngle.x, MinMaxAngle.y);//�㉺�̊p�x�ړ��̍ő�A�ŏ�.


            currentXRot = Mathf.SmoothDamp(currentXRot, xRot, ref xRotVelocity, lookSmooth);
            currentYRot = Mathf.SmoothDamp(currentYRot, yRot, ref yRotVelocity, lookSmooth);

            transform.rotation = Quaternion.Euler(currentXRot, currentYRot, 0);


        }
    }
}