using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    [Header("再生するパーティクルの設定")]
    public ParticleSystem effect;
    private float timeElapsed;

    [Header("HP0のときに削除するキャラを入れる。つまりこのスクリプト入れたプレハブ")]
    public GameObject Prefab;
    public  int constHP = 2;
    private int HP;//HPの初期値を保存する

    [Header("奇数秒目に移動する距離")]
    public float X=-0.05f;
    public float Y=0f;
    public float Z = 0;
    [Header("偶数秒目に移動する距離")]
    public float X2= 0.05f;
    public float Y2= 0.15f;
    public float Z2=0;

    [Header("自動取得のため変更不要")]
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
        //　「""」の中はどのオブジェクトと衝突するか
        //　このソースはShotCubeという弾を打った時に生成されている「ShotCube(Clone)」で設定
        {
            effect.Play();//エフェクトに設定されていたものを再生
            Debug.Log("hit");//デバッグ用。当たったときにコンソールにhitが出ていたらここまで通ってる
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