using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartPosition : MonoBehaviour
{
    private Vector3 initialPosition;
    private Vector3 currentPosition;
    private Vector3 initialRot;

    //�ϐ������
    Rigidbody rb;

    void Start()
    {
        // �����ʒu�i�Q�[���X�^�[�g���_�̈ʒu�j
        initialPosition = transform.position;

        // �����p�x�i�Q�[���X�^�[�g���_�̊p�x�j
        initialRot = transform.eulerAngles;

        //Rigidbody���擾
        rb = GetComponent<Rigidbody>();


    }

    void Update()
    {
        // ���݂̈ʒu
        currentPosition = transform.position;

        if (currentPosition.y < -20f)
        {
            // �����ʒu�ɖ߂��B
            transform.position = initialPosition;

            // �����p�x�ɖ߂��B
            transform.eulerAngles = initialRot;

            //Rigidbody���~
            rb.velocity = Vector3.zero;
        }
    }
}