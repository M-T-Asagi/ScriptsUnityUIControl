using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIObjectArranger : MonoBehaviour
{
    [System.Serializable]
    public enum Position
    {
        LeftTop = 0,
        Top,
        RightTop,
        Left,
        Middle,
        Right,
        LeftBottom,
        Bottom,
        RightBottom
    }

    [SerializeField]
    GameObject canvas = null;

    [SerializeField]
    RectTransform uiTransform = null;

    [SerializeField]
    Vector2 margin = Vector2.zero;

    [SerializeField]
    Position position = 0;

    RectTransform canvasTransform = null;
    Vector2 lastCanvasSize = Vector2.zero;

    private void Start()
    {
        canvasTransform = canvas.GetComponent<RectTransform>();
    }

    // Update is called once per frame
    void Update()
    {
        if(lastCanvasSize != canvasTransform.sizeDelta)
        {
            SetPosition();
            lastCanvasSize = canvasTransform.sizeDelta;
        }
    }

    void SetPosition()
    {
        Vector2 canvasSize = canvasTransform.sizeDelta;
        Vector2 uiSize = uiTransform.sizeDelta; 
        Vector2 newPos;

        switch(position)
        {
            case Position.LeftTop:
                newPos = new Vector2((-canvasSize.x + uiSize.x) / 2f + margin.x, (canvasSize.y - uiSize.y) / 2f - margin.y);
                break;
            case Position.Top:
                newPos = new Vector2(margin.x, (canvasSize.y - uiSize.y) / 2f - margin.y);
                break;
            case Position.RightTop:
                newPos = new Vector2((canvasSize.x - uiSize.x) / 2f - margin.x, (canvasSize.y - uiSize.y) / 2f - margin.y);
                break;
            case Position.Left:
                newPos = new Vector2((-canvasSize.x + uiSize.x) / 2f + margin.x, margin.y);
                break;
            case Position.Right:
                newPos = new Vector2((canvasSize.x - uiSize.x) / 2f - margin.x, margin.y);
                break;
            case Position.LeftBottom:
                newPos = new Vector2((-canvasSize.x + uiSize.x) / 2f + margin.x, (-canvasSize.y + uiSize.y) / 2f + margin.y);
                break;
            case Position.Bottom:
                newPos = new Vector2(margin.x, (-canvasSize.y + uiSize.y) / 2f + margin.y);
                break;
            case Position.RightBottom:
                newPos = new Vector2((canvasSize.x - uiSize.x) / 2f - margin.x, (-canvasSize.y + uiSize.y) / 2f + margin.y);
                break;
            default:
                newPos = margin;
                break;
        }

        uiTransform.anchoredPosition = newPos;
    }
}
