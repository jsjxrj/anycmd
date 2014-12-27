﻿
namespace Anycmd.Engine.Edi.Messages
{
    using Commands;
    using Model;
    using System;

    public class RemoveInfoDicCommand : RemoveEntityCommand, ISysCommand
    {
        public RemoveInfoDicCommand(Guid infoDicId)
            : base(infoDicId)
        {

        }
    }
}