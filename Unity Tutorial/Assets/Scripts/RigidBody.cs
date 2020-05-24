using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RigidBody : MonoBehaviour
{
    private Rigidbody myRigid;
    private Vector3 rotation;

    // Start is called before the first frame update
    void Start()
    {
        myRigid = this.GetComponent<Rigidbody>();
        rotation = this.transform.eulerAngles;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.W))
        {
            //속도
            //myRigid.velocity = new Vector3(0, 0, 1); // == Vector3.forward
            //회전속도
            //myRigid.angularVelocity = new Vector3(1, 0, 0); // == Vector3.right;
            //회전 최대 속도 - 기본 값 7
            //myRigid.maxAngularVelocity = 100;
            //myRigid.angularVelocity = Vector3.right * 100;
            //myRigid.useGravity = true;
            //myRigid.isKinematic = true;
            //일정 방향으로 이동시키는것
            //myRigid.MovePosition(transform.forward);
            //각도 움직이는것 - MovePosition과 MoveRotation은 관성과 중력 영향 받지 않음
            //rotation = rotation + new Vector3(90, 0, 0) * Time.deltaTime;
            //myRigid.MoveRotation(Quaternion.Euler(rotation));
            //관성 중력 받는것 - 이동
            //myRigid.AddForce(Vector3.forward);
            //회전
            //myRigid.AddTorque(Vector3.up);
            //폭발 같은 효과 주기 ( 폭발 강도, 위치, 범위 )
            myRigid.AddExplosionForce(10, this.transform.right, 10);
        }
    }
}
