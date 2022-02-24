using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveData : MonoBehaviour
{
    [HideInInspector] public int fpsInt;
    [HideInInspector] public float masterVolume;
    [HideInInspector] public float vfxvolume;
    [HideInInspector] public float musicVolume;
    
    private void Update()
    {
        Debug.Log($"{fpsInt} {masterVolume} {vfxvolume} {musicVolume}");
    }
}
