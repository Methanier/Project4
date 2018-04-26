using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomRangeAttribute : PropertyAttribute {
    
    private float _min;
    private float _max;
    
    public float min { get { return _min; } set { _min = value; } }
    public float man { get { return _max; } set { _max = value; } }

    public CustomRangeAttribute(float x, float y)
    {
        this._min = x;
        this._max = y;
    }
}
