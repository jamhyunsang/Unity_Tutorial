using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scene9 : MonoBehaviour
{
    private Animator anim;
    private Rigidbody rigid;

    [SerializeField] private float moveSpeed;
    [SerializeField] private float jumpForce;
    [SerializeField] private LayerMask layerMask;
    private BoxCollider col;
    private bool isMove;
    private bool isJump;
    private bool isFall;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        rigid = GetComponent<Rigidbody>();
        col = GetComponent<BoxCollider>();
    }

    // Update is called once per frame
    void Update()
    {


        float _dirX = Input.GetAxisRaw("Horizontal");
        float _dirZ = Input.GetAxisRaw("Vertical");

        Vector3 direction = new Vector3(_dirX, 0, _dirZ);
        isMove = false;
        //anim.SetBool("Right", false);
        //anim.SetBool("Left", false);
        //anim.SetBool("Up", false);
        //anim.SetBool("Down", false);

        if (direction != Vector3.zero)
        {
            isMove = true;
            this.transform.Translate(direction.normalized * moveSpeed * Time.deltaTime);
            //
            //       if(direction.x>0)
            //       {
            //           anim.SetBool("Right", true);
            //       }
            //       else if (direction.x < 0)
            //       {
            //           anim.SetBool("Left", true);
            //       }
            //       else if (direction.z > 0)
            //       {
            //           anim.SetBool("Up", true);
            //       }
            //       else if (direction.z < 0)
            //       {
            //           anim.SetBool("Down", true);
            //       }
        }

        anim.SetBool("Move", isMove);
        anim.SetFloat("DirX", direction.x);
        anim.SetFloat("DirZ", direction.z);
        if (isJump)
        {
            if (rigid.velocity.y <= -0.1 && !isFall)
            {
                isFall = true;
                anim.SetTrigger("fall");
            }
            RaycastHit hitInfo;
            if (Physics.Raycast(transform.position, -transform.up, out hitInfo, col.bounds.extents.y + 0.1f, layerMask))
            {
                anim.SetTrigger("land");
                isJump = false;
                isFall = false;
            }
        }
        if (Input.GetKeyDown(KeyCode.Space)&&!isJump)
        {
            
            isJump = true;
            rigid.AddForce(Vector3.up * jumpForce);
            anim.SetTrigger("jump");

        }
    }
}