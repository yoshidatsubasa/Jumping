using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class StartCount : MonoBehaviour
{
    //[SerializeField] private GameObject pausePanel;

    //���Ԃ�\������Text�^�̕ϐ�
   
    public Text timeText;
    public Text CountText;
    public Text CountText2;
    public float totaltime = 10.0f;
    float retTime;
    float countdown = 4f;
    int count;
    new public Rigidbody rigidbody;

    public float jumppower = 5;

    void Start()
    {
        
   
        //pausePanel.SetActive(true);
       
        //Time.timeScale = 0;  // ���Ԓ�~
        
    }

    private void Update()
    {
        if(countdown>=1)
        {
            countdown -= Time.deltaTime;
            count = (int)countdown;
            CountText.text = count.ToString();
            rigidbody.velocity = Vector3.zero;
            rigidbody.velocity = Vector3.up * jumppower;
        }
        if(countdown<=1)
        {
           //pausePanel.SetActive(false);
            CountText.text = "";
            CountText2.text = "Start!!";
            totaltime -= Time.deltaTime;
            retTime = (float)totaltime;
            timeText.text = retTime.ToString("f1");
            if(retTime<=0)
            {
                SceneManager.LoadScene("Result");
            }

        }
        if(CountText2.text=="Start!!")
        {
            Destroy(CountText2, 0.5f);
        }
    }
    
    //private void Pouse()
    //{
    //    Time.timeScale = 0;  // ���Ԓ�~
    //    pausePanel.SetActive(true);



    //}

    //private void Resume()
    //{
    //    Time.timeScale = 1;  // �ĊJ
    //    pausePanel.SetActive(false);


    //}
}