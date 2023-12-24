using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class BollMove : MonoBehaviour
{
    // ���x
    public  float Speed;
    // �p�x
    public float Angle;
    // �ړ��x�N�g��
    Vector3 vec;

 

    // Start is called before the first frame update
    void Start()
    {
       
        // �p�x�����W�A���ɕϊ�
        float rad = Angle * Mathf.Deg2Rad;
        // ���W�A������i�s������ݒ�
        Vector3 direction = new Vector3(Mathf.Cos(rad), Mathf.Sin(rad), 0);
        // �����ɑ��x���|�����킹�Ĉړ��x�N�g�������߂�
        vec = direction * Speed * Time.deltaTime;
    }

    // Update is called once per frame
    void Update()
    {
        // ���̂��ړ�����
        // transform.position += vec;
        StartCoroutine("bollStop");


    }
    public IEnumerator bollStop()
    {
        transform.position += vec;
        yield return new WaitForSeconds(4.0f);
        vec.y = 0;
        vec.x = 0;

    }


  
}
