using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5.0f; // 이동 속도
    private CharacterController controller; // CharacterController 컴포넌트
    private Vector3 moveDirection; // 이동 방향

    private void Start()
    {
        controller = GetComponent<CharacterController>(); // CharacterController 컴포넌트 초기화
    }

    private void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal"); // 수평 방향 이동 입력 감지 (좌,우)
        float verticalInput = Input.GetAxis("Vertical"); // 수직 방향 이동 입력 감지 (앞, 뒤)

        // 이동 방향 설정
        Vector3 move = transform.TransformDirection(new Vector3(horizontalInput, 0, verticalInput));
        moveDirection = move * moveSpeed;

        // 이동 실행
        controller.Move(moveDirection * Time.deltaTime);
    }
}


