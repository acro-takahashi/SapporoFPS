using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHit : MonoBehaviour
{
    [Header("�Đ�����p�[�e�B�N���̐ݒ�")]
    public ParticleSystem effect;

    void OnCollisionEnter(Collision obj)
    {
        if (obj.transform.name == "EnemyShot(Clone)")
        //�@�u""�v�̒��͂ǂ̃I�u�W�F�N�g�ƏՓ˂��邩
        {
            effect.Play();//�G�t�F�N�g�ɐݒ肳��Ă������̂��Đ�
            Debug.Log("hit");//�f�o�b�O�p�B���������Ƃ��ɃR���\�[����hit���o�Ă����炱���܂Œʂ��Ă�
            Destroy(obj.gameObject);
        }
    }
}
