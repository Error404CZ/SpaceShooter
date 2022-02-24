using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPSLimiterGame : MonoBehaviour
{
    public SaveData SaveData;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(LoadFPSLimiter());
    }

    IEnumerator LoadFPSLimiter()
    {
        yield return new WaitForSeconds(0.1f);
        QualitySettings.vSyncCount = 0;
        Application.targetFrameRate = SaveData.fpsInt;
    }
}
