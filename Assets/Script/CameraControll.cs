using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControll : MonoBehaviour
{
    //캐릭터의 Transform 컴포넌트 변수
    public Transform targetTransform;

    //캐릭터와의 거리
    public float dist = 7.0f;

    //캐릭터와의 높이
    public float height = 2.0f;

    //부드러운 추적을 위한 변수
    public float dampTrace = 20.0f;


    //Camera 자신의 Transform 컴포넌트 변수
    private Transform _transform;


    //Use this for initialization
    private void Start()
    {
        _transform = GetComponent<Transform>();
    }

    //캐릭터의 이동이 끝난 후 카메라가 이동하기 위해 LateUpdate 함수 사용
    private void LateUpdate()
    {
        _transform.position = Vector3.Lerp(_transform.position, targetTransform.position - (targetTransform.forward * dist) + (Vector3.up * height ), Time.deltaTime * dampTrace);

        //카메라가 타겟을 바라볼 수 있게 설정
        _transform.LookAt(targetTransform.position);
    }
}
