using UnityEngine;
using UnityEngine.UI;

public class SliderScript : MonoBehaviour
{
    public Slider m_slider;
    public float RightValue;
    public RectMask2D rectMask;

    [SerializeField] private float minVal = 550f;
    [SerializeField] private float maxVal = 0.0001f;

    private void Update()
    {
        float SliderValue = m_slider.value;

        RightValue = minVal + (SliderValue * (maxVal - minVal));

        rectMask.padding = new Vector4(0, 0, RightValue, 0);
    }
}
