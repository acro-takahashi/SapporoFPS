using Invector.vCharacterController;
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
    [Header("HP0�̂Ƃ��ɍ폜���鎩�L�����ƃJ������ǉ�")]
    public GameObject playerPrefab;
    public GameObject deleteCamera;

    [Header("HP0�̂Ƃ��ɒǉ�����J����")]
    public GameObject addCamera;


    void OnCollisionEnter(Collision obj)
    {
        if (obj.transform.name == "EnemyShot(Clone)")
        //�@�u""�v�̒��͂ǂ̃I�u�W�F�N�g�ƏՓ˂��邩
        {
            effect.Play();//�G�t�F�N�g�ɐݒ肳��Ă������̂��Đ�
            Destroy(obj.gameObject);

            if (HP > 0)
            {
                HP--;
                //Debug.Log(HP);
                if (HP == 0)
                {

                    hitPointText.text = "       GameOver";
                    Debug.Log("����OFF��");
                    Destroy(playerPrefab);
                    Destroy(deleteCamera);

                    var pos = transform.position + transform.forward + transform.up;
                    var del = Instantiate(addCamera, pos, transform.rotation);
                }
                else
                {
                    string str = hitPointText.text;
                    string str1 = str.Substring(0, str.IndexOf(":") + 1);
                    string str2 = HP.ToString();
                    hitPointText.text = str1 + str2;
                }
            }
        }
    }

    void Start()
    {
        string str = hitPointText.text;
        string str1 = str.Substring(0, str.IndexOf(":") + 1);
        string str2 = HP.ToString();
        hitPointText.text = str1 + str2;
    }
}
