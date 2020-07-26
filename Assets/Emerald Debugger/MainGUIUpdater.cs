using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainGUIUpdater : MonoBehaviour
{

    public Text timeDeltaDisp;
    public Text fpsDisp;
    public Text afpsDisp;
    public int afpsCount;
    public float afpsGuide;

    // Update is called once per frame
    void Update()
    {
        timeDeltaDisp.text = "Time Delta:  " + (Time.deltaTime).ToString();
        fpsDisp.text = "FPS:  " + Mathf.RoundToInt(Time.deltaTime * 3600f).ToString();
        afpsCount += 1;
        afpsGuide += Time.deltaTime * 3600f;
        afpsDisp.text = "Average FPS:  " + Mathf.RoundToInt(afpsGuide / afpsCount).ToString();
    }
}
