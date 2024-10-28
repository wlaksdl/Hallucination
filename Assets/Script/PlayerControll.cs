using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControll : MonoBehaviour
{
    private Transform _transform;
    private float _horizontal = 0.0f;
    private float _vertical = 0.0f;

    public float moveSpd = 5.0f;
    public float rotateSpd = 100.0f;

    //Use this for initialization
    private void Start()
    {
        _transform = GetComponent<Transform>(); //컴포넌트를 변수에 할당

        Cursor.lockState = CursorLockMode.Locked;
    }

    //Update is called once per frame
    void Update()
    {
        _horizontal = Input.GetAxis("Horizontal"); //Input Manager에 지정된 값을 받아들임

        _vertical = Input.GetAxis("Vertical"); //Input Manager에 지정된 값을 받아들임


        //변위 값을 계산하기 위한 Vector3 변수 : 앞/뒤/좌/우 이동 값을 저장
        Vector3 moveDirect = (Vector3.forward * _vertical) + (Vector3.right * _horizontal);

        //게임 오브젝트의 이동 처리를 편하게 할 수 있는 함수
        _transform.Translate(moveDirect.normalized * Time.deltaTime * moveSpd, Space.Self);

        //캐릭터의 회전을 위한 함수
        _transform.Rotate(Vector3.up * Time.deltaTime * rotateSpd * Input.GetAxis("Mouse X"));
    }
}
