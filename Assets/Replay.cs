using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Replay : MonoBehaviour
{
    [SerializeField]
    [Tooltip("Destroy")]
    private GameObject playerPrefab;

    // �ǉ��F�v���C���[�������钼�O�̈ʒu
    private Vector3 playerPosition;

    // Update is called once per frame
    void Update()
    {
        // �ݒ肵��playerPrefab�Ɠ������O(�����"PlayerSphere")��GameObject��T���Ď擾
        GameObject playerObj = GameObject.Find(playerPrefab.name);

        // playerObj�����݂��Ă��Ȃ��ꍇ
        if (playerObj == null)
        {
            // playerPrefab����V����GameObject���쐬
            // �C���F�쐬���ɍ쐬����ꏊ(playerPosition)���w��
            GameObject newPlayerObj = Instantiate(playerPrefab, playerPosition, Quaternion.identity);

            // �ǉ��F���v���C���ꂽ���Ƃ��킩��₷���悤�ɐF��ς���
            newPlayerObj.GetComponent<Renderer>().material.color = Color.yellow;

            // �V�����쐬����GameObject�̖��O���Đݒ�(�����"PlayerSphere"�ƂȂ�)
            newPlayerObj.name = playerPrefab.name;
            // �������Ŗ��O���Đݒ肵�Ȃ��ꍇ�A�����Ō��܂閼�O�́A"PlayerSphere(Clone)"�ƂȂ邽��
            //   13�s�ڂŒT���Ă���"PlayerSphere"���i���Ɍ�����Ȃ����ƂɂȂ�Aplayer�������ɐ��Y�����
            //   �ǂ��������Ƃ��́A23�s�ڂ��R�����g�A�E�g���ăQ�[�������s����΂킩��܂��B
        }
        else
        {
            // �ǉ��F�v���C���[�̈ʒu��s�x�X�V
            playerPosition = playerObj.transform.localPosition;

        }
    }
}