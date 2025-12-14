using UnityEngine;

public class MouseDrag : MonoBehaviour
{
    [SerializeField]
    private RectTransform dragRectangle;        // 마우스로 드래그한 범위를 보여줌

    private Rect dragRect;                     // 드래그한 범위
    private Vector2 start = Vector2.zero;        // 드래그 시작 위치
    private Vector2 end = Vector2.zero;          // 드래그 종료 위치

    private Camera mainCamera;
    //private AppleController appleController;

    //private void Awake()
    //{
    //    mainCamera = Camera.main;
    //    appleController = GetComponent<AppleController>();

    //    // start, end가 (0, 0)인 상태로 이미지의 크기를 (0, 0)으로 설정해 화면에 보이지 않도록 설정
    //    DrawDragRectangle();
    //}

    //void Update()
    //{
    //    // 마우스 왼쪽 버튼 클릭 시
    //    if(Input.GetMouseButtonDown(0))
    //    {
    //        start = Input.mousePosition;
    //        dragRect = new Rect();
    //    }

    //    // 마우스 왼쪽 버튼을 누르고 있을 때
    //    if(Input.GetMouseButton(0))
    //    {
    //        end = Input.mousePosition;

    //        // 마우스를 클릭한 상태로 드래그 하는 동안 드래고 범위를 이미지로 표현
    //        DrawDragRectangle();
    //    }
    //}
}
