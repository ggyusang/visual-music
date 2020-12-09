using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drag2test : MonoBehaviour
{
    
    public float rotationSpeed = 2f; //회전속도
    Vector3 pos = new Vector3(0, 0, 0); // 중심값
    public Camera MainCamera; //좌표를 참고할 카메라
    [SerializeField] private Vector3 FirstTouch; //첫번째 터치
    [SerializeField] private Vector3 LastTouch; // 움직인 곳의 터치

    
    void FixedUpdate()
    {
       
        if (Input.GetMouseButtonDown(0))
        {

            FirstTouch = new Vector3(Input.mousePosition.x, Input.mousePosition.y,130);
            FirstTouch = MainCamera.ScreenToWorldPoint(FirstTouch); //스크린좌표를 월드좌표로 바꿈
        }
        if (Input.GetMouseButton(0))
        {
            Vector3 firstAngle = new Vector3(0, 0, GetDegree(pos, FirstTouch));  //첫번째 터치와 중싱값의 각도 
            LastTouch = new Vector3(Input.mousePosition.x, Input.mousePosition.y,130);
            LastTouch = MainCamera.ScreenToWorldPoint(LastTouch);
            Vector3 lastAngle = new Vector3(0, 0, GetDegree(pos, LastTouch));  // 움직인 터치와 중심값의 각도
            float angle = lastAngle.z - firstAngle.z; //움직인 만큼의 각도를 구함
            //MainCamera.transform.Rotate(new Vector3(0, 0, angle * rotationSpeed));
            transform.Rotate(new Vector3(0, 0, angle * rotationSpeed));  //각도만큼 회전 * 회전속도 
            
            FirstTouch = LastTouch; //프레임마다 계속 초기화 
        }
    }




    float GetDegree(Vector3 _from, Vector3 _to)  // 두 벡터간의 각도를 구하는 함수 
    {
        return Mathf.Atan2(_to.y - _from.y, _to.x - _from.x) * 180 / Mathf.PI;

    }

   
}
