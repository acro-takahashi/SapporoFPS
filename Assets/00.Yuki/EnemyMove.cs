using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    public ParticleSystem effect;//�C���X�y�N�^�[��ɃG�t�F�N�g�ݒ肪�s����p
    void OnCollisionEnter(Collision obj)
    {
        if (obj.transform.name == "ShotCube(Clone)")
        //�@�u""�v�̒��͂ǂ̃I�u�W�F�N�g�ƏՓ˂��邩
        //�@���̃\�[�X��ShotCube�Ƃ����e��ł������ɐ�������Ă���uShotCube(Clone)�v�Őݒ�
        {
            effect.Play();//�G�t�F�N�g�ɐݒ肳��Ă������̂��Đ�
            Debug.Log("hit");//�f�o�b�O�p�B���������Ƃ��ɃR���\�[����hit���o�Ă����炱���܂Œʂ��Ă�
        }
    }
}