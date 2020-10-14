using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntencityColorChange : MonoBehaviour
{
    

    // Interpolate light color between two colors back and forth
    public float duration = 1.0f;
    public Color color0 = Color.red;
    public Color color1 = Color.blue;

    Light lt;

    void Start()
    {
        lt = GetComponent<Light>();
    }

    // Update is called once per frame
    void Update()
    {
        // set light color
        //lt.color -= (Color.white / 10.0f) * Time.deltaTime;
        float t = Mathf.PingPong(Time.time, duration) / duration;
        lt.color = Color.Lerp(color0, color1, t);
    }
}
