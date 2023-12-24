using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class Coincounter : MonoBehaviour
{
    public Coincounter playerController;

    public Text textComponent;

    public static int coinCount;

    float lifeTime = 0.5f;  // �l����̐������� 

    float speed = 100f;

    bool isGet;             // �l���ς݃t���O

  
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag=="Player")
        {
            playerController.AddCoinCount();
            Destroy(gameObject);
            

            isGet = true;
        }
    }

    public void AddCoinCount()
    {
        coinCount = coinCount + 1;
        Debug.Log("CoinCount;" + coinCount);

        textComponent.text = "X" + coinCount;
    }

    public static int getscore()
    {
        return coinCount;
    }
   

    private void Start()
    {
        GameObject managerObject = GameObject.Find("Coin");

        playerController = managerObject.GetComponent<Coincounter>();

    }

    private void Update()
    {
        // �l����
        if (isGet)
        {
            // �f������]
            transform.Rotate(Vector3.up * speed * 10f * Time.deltaTime, Space.World);

            // �������Ԃ����炷
            lifeTime -= Time.deltaTime;

            // �������Ԃ�0�ȉ��ɂȂ��������
            if (lifeTime <= 0)
            {
                Destroy(gameObject);
            }
        }
        // �l���O
        else
        {
            // ��������]
            transform.Rotate(Vector3.up * speed * Time.deltaTime, Space.World);
        }

    }

   
}