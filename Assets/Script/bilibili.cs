using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BilibiliUtilities.Live;
using Script.Bilibili;

namespace Script.Bilibili
{
    public class bilibili : MonoBehaviour
    {
        public static MessageHandler mh = new MessageHandler();
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            ConnectBilibiliRoom();
        }

        private async void ConnectBilibiliRoom()
        {
            
            LiveRoom room = new LiveRoom(24489912, mh);
            if(await room.ConnectAsync())
            {
                Debug.Log( "连接成功,开始获取直播弹幕");
                room.ReadMessageLoop();
            }else
            {
                Debug.Log("连接失败,开始获取直播弹幕");
            }
        }
    }
}