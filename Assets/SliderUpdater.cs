﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderUpdater : MonoBehaviour {

    public Slider slider;

    public void UpdateSliderValue()
    {
        gameObject.GetComponent<Text>().text = slider.value.ToString();
    }
}
