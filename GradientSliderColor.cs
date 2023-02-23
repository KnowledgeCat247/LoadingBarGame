using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GradientSliderColor : MonoBehaviour
{
    public Gradient gradient;
    [SerializeField]
    private Image fill;
    [SerializeField]
    private Slider slider;


    // Update is called once per frame
    void Update()
    {
        fill.color = gradient.Evaluate(slider.normalizedValue);
    }
}
