using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class down : MonoBehaviour
{
    Rigidbody m_Rigidbody;
    Vector3 m_YAxis;
    float m_Speed;

    void Start()
    {
        //���W�b�g�{�f�B���擾
        m_Rigidbody = GetComponent<Rigidbody>();
        //m_Rigidbody.constraints = RigidbodyConstraints.None;
       //* m_YAxis = new Vector3(0, 5, 0);
        //m_Speed = 20.0f;
    }

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.C)) //C�����������Ă���Ƃ�
        {
            //�g�����X�t�H�[���̈ʒu���擾
            Vector3 pos = gameObject.transform.position;
            //���������l�����
            pos.y += -0.7f;
            //�l���ʒu�ɕԂ�
            gameObject.transform.position = pos;
            //���W�b�g�{�f�B�̈ʒu�E��]���Œ�
            m_Rigidbody.constraints = RigidbodyConstraints.FreezeAll;
        }
        if (Input.GetKeyUp(KeyCode.C))�@//C�𗣂����Ƃ�
        {
            //�g�����X�t�H�[���̈ʒu���擾
            Vector3 pos = gameObject.transform.position;
            //��̒l�̃}�C�i�X�����
            pos.y += 0.7f;
            //�l���ʒu�ɕԂ�
            gameObject.transform.position = pos;
            //���W�b�g�{�f�B�̈ʒu�E��]�̌Œ������
            m_Rigidbody.constraints = RigidbodyConstraints.None;
            //���W�b�g�{�f�B�̉�]���Œ�
            m_Rigidbody.constraints = RigidbodyConstraints.FreezeRotation;
        }
    }

}
