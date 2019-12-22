using UnityEngine;
using UnityEngine.UI;
public class ToggleColorChange : MonoBehaviour
{
    [SerializeField]
    Toggle stateSource = null;
    [SerializeField]
    Graphic targetGraphic = null;
    [SerializeField]
    Color activeColor = Color.white;
    [SerializeField]
    Color deactiveColor = Color.gray;

    // Start is called before the first frame update
    void Start()
    {
        stateSource.onValueChanged.AddListener(OnToggleChange);
        SetTargetGraphicColor();
    }

    public void ForceUpdate()
    {
        SetTargetGraphicColor();
    }

    void OnToggleChange(bool isOn)
    {
        SetTargetGraphicColor(isOn);
    }

    void SetTargetGraphicColor()
    {
        targetGraphic.color = _SetTargetGraphicColor(stateSource.isOn);
    }

    void SetTargetGraphicColor(bool isOn)
    {
        targetGraphic.color = _SetTargetGraphicColor(isOn);
    }

    Color _SetTargetGraphicColor(bool isOn)
    {
        return (isOn ? activeColor : deactiveColor);
    }
}
