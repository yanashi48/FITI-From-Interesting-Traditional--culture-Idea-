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
                Debug.Log( "���ӳɹ�,��ʼ��ȡֱ����Ļ");
                room.ReadMessageLoop();
            }else
            {
                Debug.Log("����ʧ��,��ʼ��ȡֱ����Ļ");
            }
        }
    }
}