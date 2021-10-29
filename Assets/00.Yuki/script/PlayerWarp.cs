using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWarp : MonoBehaviour
{
    [Header("���[�v������W�iW�L�[�j")]
    public float X = 0f;
    public float Y = 0f;
    public float Z = 0f;

    private float timeElapsed;
    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.W))
        {
            timeElapsed += Time.deltaTime;
            if (timeElapsed <= 1)
            {
                GetComponent<Invector.vCharacterController.vThirdPersonInput>().enabled = false;
                transform.position = new Vector3(X, Y, Z);
                return;
            }
            
        }
        if (timeElapsed <= 2)
        {
            GetComponent<Invector.vCharacterController.vThirdPersonInput>().enabled = true;
            return;
        }
        timeElapsed = 0;

    }
    void OnCollisionEnter(Collision obj)
    {
        if (obj.transform.name == "WarpObject")
        //�@�u""�v�̒��͂ǂ̃I�u�W�F�N�g�ƏՓ˂��邩
        {
            timeElapsed += Time.deltaTime;
            if (timeElapsed <= 1)
            {
                GetComponent<Invector.vCharacterController.vThirdPersonInput>().enabled = false;
                transform.position = new Vector3(X, Y, Z);
                return;
            }


            if (timeElapsed <= 2)
            {
                GetComponent<Invector.vCharacterController.vThirdPersonInput>().enabled = true;
                return;
            }
            timeElapsed = 0;
        }
    }
}
