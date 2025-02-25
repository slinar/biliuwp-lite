﻿using System.Collections.ObjectModel;
using BiliLite.Models.Attributes;
using BiliLite.Models.Common.Msg;
using BiliLite.ViewModels.Common;
using PropertyChanged;

namespace BiliLite.ViewModels.Messages
{
    [RegisterTransientViewModel]
    public class MessagesViewModel : BaseViewModel
    {
        public ObservableCollection<ChatContextViewModel> ChatContexts { get; set; }

        public ChatContextViewModel SelectedChatContext { get; set; }

        public ObservableCollection<ChatMessage> ChatMessages { get; set; }

        public bool HasMoreContexts { get; set; }

        public bool HasMoreMessages { get; set; }

        public bool ChatContextLoading { get; set; }

        public bool ChatMessagesLoading { get; set; }

        [DoNotNotify]
        public string LastMsgId { get; set; }

        [DoNotNotify]
        public string NewMsgId { get; set; }
    }
}
