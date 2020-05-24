using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collider : MonoBehaviour
{
    private BoxCollider col;

    // Start is called before the first frame update
    void Start()
    {
        col = GetComponent<BoxCollider>();
    }

    // Update is called once per frame
    void Update()
    {
        //if(Input.GetKeyDown(KeyCode.W))
        //{
        //    //Debug.Log("col.bounds" + col.bounds);                   //bounds의 값은 물체의 위치 + 콜라이더의 위치(center)의 결과값이다.
        //    //Debug.Log("col.bounds.extents" + col.bounds.extents);   //size의 반 - bounds : 변경 불가능, 나머지는 다 가능
        //    //Debug.Log("col.bounds.extents.x" + col.bounds.extents.x);
        //    //Debug.Log("col.size" + col.size);
        //    //Debug.Log("col.center" + col.center);
        //    //사이즈 변경
        //    //col.size = new Vector3(3, 3, 3);
        //
        //    
        //}
        //메서드들
        //레이저를 쏴서 맞은 곳의 정보를 가져온다. (레이저좌표, 정보, 사정거리)
        //col.Raycast()
        //0이면 좌버튼
        //if (Input.GetMouseButtonDown(0))
        //{
        //    //레이저
        //    Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);       //Camera.main - 메인카메라 ScreenPointToRay 화면위로 레이저 쏜다. Input.bousePosition - 마우스 위치
        //    //레이저를 쏴서 맞은 곳에 대한 정보
        //    RaycastHit hitInfo;
        //    if(col.Raycast(ray, out hitInfo, 1000))
        //    {
        //        this.transform.position = hitInfo.point;
        //    }
        //
        //}
    }
    //Is Trigger가 체크된 상태에서 콜라이더에 다른 콜라이더가 들어오면 발동된다.
    private void OnTriggerEnter(UnityEngine.Collider other)
    {
        
    }
    //나갈때
    private void OnTriggerExit(UnityEngine.Collider other)
    {
        other.transform.position = new Vector3(0, 2, 0);
    }
    //머무를때
    private void OnTriggerStay(UnityEngine.Collider other)
    {
        other.transform.position += new Vector3(0, 0, 0.01f);
    }
    //실제 충돌이 일어났을 때 Is Collision이 체크 해제됬을때
    private void OnCollisionEnter(Collision collision)
    {
        
    }
    private void OnCollisionExit(Collision collision)
    {
        
    }
    //실제로 물리법칙에서 겹칠 순 없으니까 겹쳤을 때 오류 제거해주기 위해 존재
    private void OnCollisionStay(Collision collision)
    {
        
    }
}
