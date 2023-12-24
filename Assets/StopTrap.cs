using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StopTrap : MonoBehaviour
{
    

    private PlayerController ball;
   

    void Start()
    {
        

    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
           

 
            // Ball�̓������i��X�N���v�g���I�t�ɂ���B
            ball = collision.gameObject.GetComponent<PlayerController>();
            ball.enabled = false;

            // �Q�b��Ƀ{�[����������悤�ɂ���B
            Invoke("StopOff", 2.0f);

            Debug.Log("�S�[��");

          
        }

    }

    void StopOff()
    {
  
        // Ball�̓������i��X�N���v�g���I���ɂ���B
        ball.enabled = true;
    }

    void Update()
    {
      
    }

}
