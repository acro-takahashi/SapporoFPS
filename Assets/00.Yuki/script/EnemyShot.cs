using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShot : MonoBehaviour
{

    public GameObject enemyShotPrefab;
    
    [Header("�����Ŏˏo����܂ł̎���")]
    public float shotInterval=1.0f;
    float timeCount;

 
    // Update is called once per frame
    void Update()
    {
        //���Ԍv��
        timeCount += Time.deltaTime;
        //�w��̕b���ȏ�ɂȂ����ꍇ
        if (timeCount >= shotInterval)
        {
            //�J�E���g�����Z�b�g
            timeCount = 0;
            //�e�𐶐�
            var pos = transform.position + transform.forward * 2 + transform.up * 1;
            Instantiate(enemyShotPrefab, pos, transform.rotation);
           // Instantiate(enemyShotPrefab, transform.position, Quaternion.identity);
        }
    }
}
