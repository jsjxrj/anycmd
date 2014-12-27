﻿
namespace Anycmd.Engine.Edi.Messages
{
    using Commands;
    using Model;
    using System;

    public class RemoveProcessCommand : RemoveEntityCommand, ISysCommand
    {
        public RemoveProcessCommand(Guid processId)
            : base(processId)
        {

        }
    }
}