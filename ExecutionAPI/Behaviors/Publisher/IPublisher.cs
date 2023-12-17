﻿using ExecutionAPI.Model;

namespace ExecutionAPI.Behaviors.Publisher
{
    public interface IPublisher
    {
        void Publish(OrderRequest orderRequest);
    }
}
