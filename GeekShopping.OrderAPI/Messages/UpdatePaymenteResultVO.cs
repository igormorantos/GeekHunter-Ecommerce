﻿namespace GeekShopping.OrderAPI.Messages
{
    public class UpdatePaymenteResultVO
    {
        public long OrderId { get; set; }

        public bool Status { get; set; }

        public string Email { get; set; }
    }
}
