﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ForumHCFE.Data.Models
{
    public class PrivateMessage
    {
        public int Id { get; set; }
        public string Subject { get; set; }
        public string Description { get; set; }
        public DateTime Created { get; set; }
        public virtual ApplicationUser Sender { get; set; }
        public virtual ApplicationUser Receiver { get; set; }
    }
}
