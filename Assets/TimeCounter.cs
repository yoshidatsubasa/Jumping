using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TimeCounter : MonoBehaviour
{
    //�J�E���g�_�E��
    public float countdown = 5.0f;

    //���Ԃ�\������Text�^�̕ϐ�
    public Text timeText;

    private void Start()
    {
    }


    // Update is called once per frame
    void Update()
    {
        //���Ԃ��J�E���g�_�E������
        countdown -= Time.deltaTime;

        //���Ԃ�\������
        timeText.text = countdown.ToString("f1");

        //countdown��0�ȉ��ɂȂ����Ƃ�
        if (countdown <= 0)
        {
            SceneManager.LoadScene("Result");
        }

       
    }
}