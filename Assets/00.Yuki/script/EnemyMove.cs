using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    [Header("�Đ�����p�[�e�B�N���̐ݒ�")]
    public ParticleSystem effect;
    private float timeElapsed;

    [Header("HP0�̂Ƃ��ɍ폜����L����������B�܂肱�̃X�N���v�g���ꂽ�v���n�u")]
    public GameObject Prefab;
    public  int constHP = 2;
    private int HP;//HP�̏����l��ۑ�����

    [Header("��b�ڂɈړ����鋗��")]
    public float X=-0.05f;
    public float Y=0f;
    public float Z = 0;
    [Header("�����b�ڂɈړ����鋗��")]
    public float X2= 0.05f;
    public float Y2= 0.15f;
    public float Z2=0;

    [Header("�����擾�̂��ߕύX�s�v")]
    public Vector3 DefaultPos;

    void Start()
    {
        HP = constHP;
        DefaultPos = gameObject.transform.position;
    }

    // Update is called once per frame
    void Update()
    {

        timeElapsed += Time.deltaTime;
        if (timeElapsed <= 1)
        {
            transform.Translate(X, Y, Z);
            return;
        }
        else if (timeElapsed <= 2)
        {
            return;
        }
        else if (timeElapsed <= 3)
        {
            transform.Translate(X2, Y2, Z2);
            return;
        }
        else if (timeElapsed <= 4)
        {
            return;
        }
        timeElapsed = 0;

    }

    void OnCollisionEnter(Collision obj)
    {
        if (obj.transform.name == "PlayerShot(Clone)")
        //�@�u""�v�̒��͂ǂ̃I�u�W�F�N�g�ƏՓ˂��邩
        //�@���̃\�[�X��ShotCube�Ƃ����e��ł������ɐ�������Ă���uShotCube(Clone)�v�Őݒ�
        {
            effect.Play();//�G�t�F�N�g�ɐݒ肳��Ă������̂��Đ�
            Debug.Log("hit");//�f�o�b�O�p�B���������Ƃ��ɃR���\�[����hit���o�Ă����炱���܂Œʂ��Ă�
            Destroy(obj.gameObject);

            if (HP > 0)
            {
                HP--;
                Debug.Log(HP);
                if (HP == 0)
                {
                    HP = constHP;

                    gameObject.transform.position = DefaultPos;

                    Prefab.SetActive(false);
                }

                else
                {
                    //string str = hitPointText.text;
                    //string str1 = str.Substring(0, str.IndexOf(":") + 1);
                    //string str2 = HP.ToString();
                    //hitPointText.text = str1 + str2;
                }
            }
        }
    }
}