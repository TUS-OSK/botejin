using UnityEngine;
using System.Diagnostics;
public class InputManager : MonoBehaviour
{
    public static InputManager Singleton;
    public delegate void OnDirectionEventHandler(Direction dir);
    public event OnDirectionEventHandler OnSwipe;
    private Vector2 StartPos;
    private Vector2 EndPos;

    private void Awake()
    {
        Singleton = this;
        OnSwipe += _ => { };
    }

    private void Update()
    {
        TouchInput();
        ClickInput();
    }
    private void TouchInput()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            switch (touch.phase)
            {
                case TouchPhase.Began:
                    OnTouchStart(touch.position);
                    break;
                case TouchPhase.Ended:
                    OnTouchEnd(touch.position);
                    break;
            }
        }
    }

    [Conditional("UNITY_EDITOR")]
    private void ClickInput()
    {
        if (Input.GetMouseButtonDown(0))
        {
            OnTouchStart(Input.mousePosition);
        }
        if (Input.GetMouseButtonUp(0))
        {
            OnTouchEnd(Input.mousePosition);
        }
    }

    private void OnTouchStart(Vector2 pos)
    {
        StartPos = pos;
    }
    private void OnTouchEnd(Vector2 pos)
    {
        var delta = pos - StartPos;
        OnSwipe(ConvertDeltaPos2Direction(delta.normalized));
    }
    private static Direction ConvertDeltaPos2Direction(Vector2 delta)
    {
        if(Mathf.Abs(delta.x) >= Mathf.Abs(delta.y))
        {
            return (delta.x >= 0) ? Direction.right : Direction.left;
        }
        else
        {
            return (delta.y >= 0) ? Direction.up : Direction.down;
        }
    }
}