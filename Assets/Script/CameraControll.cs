using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControll : MonoBehaviour
{
    //ĳ������ Transform ������Ʈ ����
    public Transform targetTransform;

    //ĳ���Ϳ��� �Ÿ�
    public float dist = 7.0f;

    //ĳ���Ϳ��� ����
    public float height = 2.0f;

    //�ε巯�� ������ ���� ����
    public float dampTrace = 20.0f;


    //Camera �ڽ��� Transform ������Ʈ ����
    private Transform _transform;


    //Use this for initialization
    private void Start()
    {
        _transform = GetComponent<Transform>();
    }

    //ĳ������ �̵��� ���� �� ī�޶� �̵��ϱ� ���� LateUpdate �Լ� ���
    private void LateUpdate()
    {
        _transform.position = Vector3.Lerp(_transform.position, targetTransform.position - (targetTransform.forward * dist) + (Vector3.up * height ), Time.deltaTime * dampTrace);

        //ī�޶� Ÿ���� �ٶ� �� �ְ� ����
        _transform.LookAt(targetTransform.position);
    }
}
