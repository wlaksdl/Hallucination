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
        _transform = GetComponent<Transform>(); //������Ʈ�� ������ �Ҵ�

        Cursor.lockState = CursorLockMode.Locked;
    }

    //Update is called once per frame
    void Update()
    {
        _horizontal = Input.GetAxis("Horizontal"); //Input Manager�� ������ ���� �޾Ƶ���

        _vertical = Input.GetAxis("Vertical"); //Input Manager�� ������ ���� �޾Ƶ���


        //���� ���� ����ϱ� ���� Vector3 ���� : ��/��/��/�� �̵� ���� ����
        Vector3 moveDirect = (Vector3.forward * _vertical) + (Vector3.right * _horizontal);

        //���� ������Ʈ�� �̵� ó���� ���ϰ� �� �� �ִ� �Լ�
        _transform.Translate(moveDirect.normalized * Time.deltaTime * moveSpd, Space.Self);

        //ĳ������ ȸ���� ���� �Լ�
        _transform.Rotate(Vector3.up * Time.deltaTime * rotateSpd * Input.GetAxis("Mouse X"));
    }
}
