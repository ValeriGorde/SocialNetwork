﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetwork.DLL.Entities
{
    public class FriendEntity
    {
        public int id { get; set; }
        public int user_id { get; set; } //?? мб изменить на int
        public int friend_id { get; set; }
    }
}
