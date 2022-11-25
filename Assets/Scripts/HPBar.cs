using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HPBar : MonoBehaviour
{
  public Slider hpSlider;

  public void SetValue(float hpvalue) 
    {
        hpSlider.value = hpvalue;
    }

}
