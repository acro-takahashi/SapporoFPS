using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class shot : MonoBehaviour
{
    public GameObject prefab;
    private float timeElapsed;
    public int shotCount = 10; //�e�̐�
    private float shotInterval;
    public Text shotText;
    // Start is called before the first frame update
    void Start()
    {

    }



    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Mouse0))
        {
           shotInterval += 1;
            Debug.Log("shotInterval"+shotInterval);//�R���\�[���ɏo��悤�������ǉ�
            Debug.Log("shotCount"+shotCount);//�R���\�[���ɏo��悤�������ǉ�
            if (shotInterval % 5 == 0 && shotCount > 0)�@//shotCount��0�ɂȂ�܂Ŕ��˓��삷��
            {
                shotCount -= 1;

                // �O���ɔ���
                 var pos = transform.position + transform.forward * 2 + transform.up * 1;
                var del = Instantiate(prefab, pos, transform.rotation);

               

                   
                
                    Destroy(del, 1.0f);
            }
        }
        else if (Input.GetKeyDown(KeyCode.R))�@//shotCount��0�ɂȂ������AR�L�[�Ń����[�h����
        {
            shotCount = 10;//����10�e�Œ�ɂȂ����Ⴄ���������ϐ��p�ӂ��ē��l����o����悤�ɂ����ق����y����

        }
        string str = shotText.text;
        string str1 = str.Substring(0, str.IndexOf(":") + 1);
        string str2 = str.Substring(str.IndexOf(":") + 1);
        str2 = shotCount.ToString();
        shotText.text = str1 + str2;
        

    }
}
