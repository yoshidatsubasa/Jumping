using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlagController : MonoBehaviour
{
    //��]�X�s�[�h
    [SerializeField] private Vector3 RotationSpeed = new Vector3();�@//���ǉ�

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //�I�C���[�p��ύX����
        transform.eulerAngles += RotationSpeed * Time.deltaTime;�@//���ǉ�
    }
}