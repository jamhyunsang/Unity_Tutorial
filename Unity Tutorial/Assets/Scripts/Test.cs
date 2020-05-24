using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    Vector3 rotation;
    //public으로 하면 인스펙터창에서 뜬다
    [SerializeField] //강제로 인스펙터창에 띄운다
    private GameObject go_camera = null;

    void Start()
    {
        rotation = this.transform.eulerAngles;       
    }

    // Update is called once per frame
    void Update()
    {

        //기준으로 잡은 물체 주위를 돈다
        transform.RotateAround(go_camera.transform.position, Vector3.up, 100 * Time.deltaTime);
        //if(Input.GetKey(KeyCode.W))
        //{
        //    //트랜스폼을 직접 수정하는 방법
        //    //this.transform.position = this.transform.position + new Vector3(0, 0, 1) * Time.deltaTime; //Time.deltaTime - 한프레임에 걸리는 시간 대략 60분의 1값
        //    //Translate를 이용하는 방법
        //    //this.transform.Translate(new Vector3(0, 0, 1) * Time.deltaTime);
        //
        //    //회전하기
        //    rotation = rotation + new Vector3(90, 0, 0) * Time.deltaTime;
        //
        ////오일러 앵글 사용하는 방법
        ////this.transform.eulerAngles = rotation;
        ////Debug.Log(transform.eulerAngles);
        ////메서드 이용 방법 - 메서드 이용하는 것을 권장함
        ////this.transform.Rotate(new Vector3(90, 0, 0) * Time.deltaTime);
        ////쿼터니언을 이용하는 방법 - 각 값은 1이 최대값, 값을 직접 입력하는건 지양
        ////쿼터니언을 이용하는 이유 - 한축을 고정했을 때(90도로) 다른축이 맛탱이 가버리는 현상 ( 짐볼락 현상) 이 일어나지 않는다.
        ////this.transform.rotation = Quaternion.Euler(rotation);
        //
        ////크기조절
        ////this.transform.localScale = this.transform.localScale + new Vector3(2, 2, 2) * Time.deltaTime;
        //
        ////기본적인 속성들
        ////this.transform.forward - 정규화 벡터(방향만을 알려주는 녀석) new Vector3(0, 0, 1)의 값을 가짐
        ////this.transform.up - 정규화 벡터(방향만을 알려주는 녀석) new Vector3(0, 1, 0)의 값을 가짐
        ////this.transform.right - 정규화 벡터(방향만을 알려주는 녀석) new Vector3(1, 0, 0)의 값을 가짐
        //
        ////자주쓰는 메서드들
        ////특정 대상을 바라보게하는 메서드
        //this.transform.LookAt(go_camera.transform.position);
        //}
    }
}
