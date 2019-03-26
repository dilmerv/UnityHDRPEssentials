using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField]
    private Slider timeScaleSlider;

    [SerializeField]
    private Text timeScaleSliderLabel;

    [SerializeField]
    private Slider noiseStegthScaleSlider;

    [SerializeField]
    private Text noiseStegthSliderLabel;

    [SerializeField]
    private Slider fresnelStegthScaleSlider;

    [SerializeField]
    private Text fresnelStegthSliderLabel;


    [SerializeField]
    private Material deformationMaterial;
    
    void Update()
    {
        deformationMaterial.SetFloat("_TimeSpeed", timeScaleSlider.value);    
        timeScaleSliderLabel.text = $"Time Speed: {timeScaleSlider.value}";

        deformationMaterial.SetFloat("_NoiseStrength", noiseStegthScaleSlider.value);    
        noiseStegthSliderLabel.text = $"Noise Strength: {noiseStegthScaleSlider.value}";

        deformationMaterial.SetFloat("_FresnelStrength", fresnelStegthScaleSlider.value);    
        fresnelStegthSliderLabel.text = $"Fresnel Strength: {fresnelStegthScaleSlider.value}";
    }
}
