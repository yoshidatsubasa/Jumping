using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform3 : MonoBehaviour
{
    [SerializeField]
    [Tooltip("X�������Ɉړ�����U��(0�ɂ���ƈړ����Ȃ�)")]
    private float amplitudeX = 4.0f;

    [SerializeField]
    [Tooltip("Y�������Ɉړ�����U��(0�ɂ���ƈړ����Ȃ�)")]
    private float amplitudeY = 4.0f;

    [SerializeField]
    [Tooltip("Z�������Ɉړ�����U��(0�ɂ���ƈړ����Ȃ�)")]
    private float amplitudeZ = 4.0f;

    [SerializeField]
    [Tooltip("�U�����鑬��")]
    private float amplitudeSpeed = 2.0f;

    /// <summary>
    /// �Q�[���J�n���̏ꏊ
    /// </summary>
    private Vector3 startPosition;

    // Start is called before the first frame update
    void Start()
    {
        // �Q�[���J�n���̈ʒu
        startPosition = this.transform.position;

    }

    private void FixedUpdate()
    {
        // �ړ�������
        transform.position = new Vector3((Mathf.Sin((Time.time) * amplitudeSpeed) * amplitudeX + startPosition.x), 
        (Mathf.Sin((Time.time) * amplitudeSpeed) * amplitudeY + startPosition.y), (Mathf.Sin((Time.time) * amplitudeSpeed) * amplitudeZ + startPosition.z));
    }
}