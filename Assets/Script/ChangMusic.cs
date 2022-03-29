using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Script.Bilibili;
using BilibiliUtilities.Live;
public class ChangMusic : MonoBehaviour
{
    public AudioClip[] audios;
    public int i =1;
    // Start is called before the first frame update
    void Start()
    {
        this.GetComponent<AudioSource>().clip = audios[0];
        this.GetComponent<AudioSource>().Play();
    }

    // Update is called once per frame
    void Update()
    {
        if(bilibili.mh.ChangeMusicFlag ==1)
        {
            this.GetComponent<AudioSource>().clip = audios[i];
            this.GetComponent<AudioSource>().Play();
            i++;
            if(i==5)
            {
                i = 0;
            }
            bilibili.mh.ChangeMusicFlag = 0;
            Debug.Log("music"+i);
        }
    }
}
