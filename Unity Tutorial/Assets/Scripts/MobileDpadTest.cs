using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class MobileDpadTest : MonoBehaviour, IPointerDownHandler, IPointerUpHandler, IDragHandler
{
    [SerializeField] private RectTransform rect_Background;
    [SerializeField] private RectTransform rect_JoyStick;

    private float radius;

    [SerializeField] private GameObject go_Player;
    [SerializeField] private float moveSpeed;

    private bool isTouch = false;
    private Vector3 movePosition;

    // Start is called before the first frame update
    void Start()
    {
        radius = rect_Background.rect.width * 0.5f;
    }

    // Update is called once per frame
    void Update()
    {
        if(isTouch)
        {
            go_Player.transform.position += movePosition;
        }
    }

    public void OnDrag(PointerEventData eventData)
    {
        Vector2 value = eventData.position - (Vector2)rect_Background.position;

        //가두기 ( 영역설정)
        value = Vector2.ClampMagnitude(value, radius);
        // ( 1, 4 ) -> -3 ~ 5 사이가됨

        rect_JoyStick.localPosition = value;

        float distance = Vector2.Distance(rect_Background.position, rect_JoyStick.position) / radius;
      //  value = value.normalized;   //속도는 빠지고 방향값만 남게된다. (50, 0, 30) -> (0,5, 0.3)
        movePosition = new Vector3(value.x * moveSpeed * distance * Time.deltaTime, 0f, value.y * moveSpeed * distance * Time.deltaTime);
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        isTouch = true;
    }

    public void OnPointerUp(PointerEventData eventData)
    {       
        isTouch = false;
        rect_JoyStick.localPosition = Vector3.zero;
       // movePosition = Vector3.zero;
    }
}
