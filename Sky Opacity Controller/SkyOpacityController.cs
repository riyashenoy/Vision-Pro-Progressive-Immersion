using System;
using UnityEngine;

public class SkyOpacityController : MonoBehaviour
{
    [Header("Assign slider fill renderer (from SpatialUISlider)")]
    public MeshRenderer sliderFillRenderer;

    [Header("Assign your sky sphere mesh renderer")]
    public MeshRenderer skySphereRenderer;

    void Update()
    {
        if (sliderFillRenderer == null || skySphereRenderer == null)
            return;

        // 1. Read slider percentage
        float percentage = sliderFillRenderer.material.GetFloat("_Percentage");
        percentage = Mathf.Clamp01(percentage);

        // 2. Reverse it
        float reversed = 1f - percentage;

        // 3. Apply reversed value to sky alpha
        Material skyMat = skySphereRenderer.material;
        Color c = skyMat.color;
        c.a = reversed;
        skyMat.color = c;
    }
}