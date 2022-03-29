using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BilibiliUtilities.Live.Message;
using BilibiliUtilities.Live.Lib;
using System.Threading.Tasks;

namespace Script.Bilibili
{
    public class MessageHandler : IMessageHandler
    {
        //public Rigidbody2D
        public long Id;
        public string Damu_Username;
        public string Username;
        public string DamuConnect;
        public int New_User_flag = 0;
        public int ChangeMusicFlag = 0;
        

        Task IMessageHandler.AudiencesHandlerAsync(int audiences)
        {
            return null;
        }

        Task IMessageHandler.ComboEndMessageHandlerAsync(ComboEndMessage comboEndMessage)
        {
            return null;
        }

        Task IMessageHandler.DanmuMessageHandlerAsync(DanmuMessage danmuMessage)
        {
            Id=danmuMessage.UserId;
            Damu_Username=danmuMessage.Username;
            DamuConnect = danmuMessage.Content;
            if (DamuConnect.Contains("ÇÐ¸è"))
            { 
                ChangeMusicFlag = 1;
                Debug.Log("ChangeMuisc");
            }
            
            Debug.Log(Damu_Username);
            Debug.Log(DamuConnect);
            return null;
        }

        Task IMessageHandler.EntryEffectMessageHandlerAsync(EntryEffectMessage entryEffectMessage)
        {
            return null;
        }

        Task IMessageHandler.GiftMessageHandlerAsync(GiftMessage giftMessage)
        {
            return null;
        }

        Task IMessageHandler.GuardBuyMessageHandlerAsync(GuardBuyMessage guardBuyMessage)
        {
            return null;
        }

        Task IMessageHandler.InteractWordMessageHandlerAsync(InteractWordMessage message)
        {
            Username = message.Username;
            New_User_flag = 1;
            Debug.Log("welcome");
            return null;
        }

        Task IMessageHandler.LiveStartMessageHandlerAsync(int roomId)
        {
            return null;
        }

        Task IMessageHandler.LiveStopMessageHandlerAsync(int roomId)
        {
            return null;
        }

        Task IMessageHandler.NoticeMessageHandlerAsync(NoticeMessage noticeMessage)
        {
            return null;
        }

        Task IMessageHandler.RoomUpdateMessageHandlerAsync(RoomUpdateMessage roomUpdateMessage)
        {
            return null;
        }

        Task IMessageHandler.UserToastMessageHandlerAsync(UserToastMessage userToastMessage)
        {
            return null;
        }

        Task IMessageHandler.WelcomeGuardMessageHandlerAsync(WelcomeGuardMessage welcomeGuardMessage)
        {
            return null;
        }

        Task IMessageHandler.WelcomeMessageHandlerAsync(WelcomeMessage welcomeMessage)
        {
            return null;
        }

        
    }
}



