using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyRepop : MonoBehaviour
{
    [Header("����������G�l�~�[")]
    public GameObject prefab;

    [Header("���X�|������܂ł̊Ԋu����")]
    public float repopTime;


    private float timeElapsed;

    // Start is called before the first frame update
    void Start()
    {
        EnemyMove EnemyMove = prefab.GetComponent<EnemyMove>();     
    }

    // Update is called once per frame
    void Update()
    {
        timeElapsed += Time.deltaTime;

        if (timeElapsed >= repopTime)
        {
            timeElapsed = 0;
            prefab.SetActive(true);

        }
 
    }

}
