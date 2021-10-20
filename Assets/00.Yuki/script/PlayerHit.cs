using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHit : MonoBehaviour
{
    [Header("HP��UI�e�L�X�g��D��D")]
    public Text hitPointText;

    [Header("�Đ�����p�[�e�B�N���̐ݒ�")]
    public ParticleSystem effect;
    public int HP = 2;
    void OnCollisionEnter(Collision obj)
    {
        if (obj.transform.name == "EnemyShot(Clone)")
        //�@�u""�v�̒��͂ǂ̃I�u�W�F�N�g�ƏՓ˂��邩
        {
            effect.Play();//�G�t�F�N�g�ɐݒ肳��Ă������̂��Đ�
            //Debug.Log("hit");//�f�o�b�O�p�B���������Ƃ��ɃR���\�[����hit���o�Ă����炱���܂Œʂ��Ă�
            Destroy(obj.gameObject);

            if (HP > 0) 
            {
                HP--;
                Debug.Log(HP);
                if (HP == 0)
                {
                    Debug.Log("Gameover");
                }

            }

            string str = hitPointText.text;
            string str1 = str.Substring(0, str.IndexOf(":") + 1);
            Debug.Log(str1);
            string str2 = str.Substring(str.IndexOf(":") + 1);
            Debug.Log(str2);
            str2 =HP.ToString();
            hitPointText.text = str1 + str2;
        }
    }
}
