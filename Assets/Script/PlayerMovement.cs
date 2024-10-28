using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5.0f; // �̵� �ӵ�
    private CharacterController controller; // CharacterController ������Ʈ
    private Vector3 moveDirection; // �̵� ����

    private void Start()
    {
        controller = GetComponent<CharacterController>(); // CharacterController ������Ʈ �ʱ�ȭ
    }

    private void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal"); // ���� ���� �̵� �Է� ���� (��,��)
        float verticalInput = Input.GetAxis("Vertical"); // ���� ���� �̵� �Է� ���� (��, ��)

        // �̵� ���� ����
        Vector3 move = transform.TransformDirection(new Vector3(horizontalInput, 0, verticalInput));
        moveDirection = move * moveSpeed;

        // �̵� ����
        controller.Move(moveDirection * Time.deltaTime);
    }
}


