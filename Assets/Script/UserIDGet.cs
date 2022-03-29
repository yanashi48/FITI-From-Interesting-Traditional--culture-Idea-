using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Script.Bilibili;
using BilibiliUtilities.Live;

public class UserIDGet : MonoBehaviour
{
    public string Username;
    public Text text;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        int flag = 1;
        if(flag==1)
        {
            NameGet();
        }
        
    }
    
    private void NameGet()
    {
        Username = bilibili.mh.Username;
        text.text= Username;

    }
}
