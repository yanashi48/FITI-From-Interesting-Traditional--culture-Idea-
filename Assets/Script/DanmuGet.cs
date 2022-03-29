using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Script.Bilibili;
using BilibiliUtilities.Live;

public class DanmuGet : MonoBehaviour
{
    public string DanmuContent;
    public Text text;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Danmu_Get();
    }

    private void Danmu_Get()
    {
        DanmuContent = bilibili.mh.DamuConnect;
        text.text = DanmuContent;

    }
}
