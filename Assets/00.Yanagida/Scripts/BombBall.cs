using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombBall : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("Explode", 1.5f); // グレネードが作られてから1.5秒後に爆発させる
    }
 
    // Update is called once per frame
    void Update()
    {
        
    }
 
    void Explode()
    {
        GameObject[] cubes = GameObject.FindGameObjectsWithTag("Enemy"); //「Cube」タグのついたオブジェクトを全て検索して配列にいれる
 
        if (cubes.Length == 0) return; // 「Cube」タグがついたオブジェクトがなければ何もしない。
 
        foreach (GameObject cube in cubes) // 配列に入れた一つひとつのオブジェクト
        {
            if (cube.GetComponent<Rigidbody>()) // Rigidbodyがあれば、グレネードを中心とした爆発の力を加える
            {
                cube.GetComponent<Rigidbody>().AddExplosionForce(100f, transform.position, 30f, 5f, ForceMode.Impulse);
            }
        }
    }
}
