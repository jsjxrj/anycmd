﻿
namespace Anycmd.Engine.Edi.Messages
{
    using Commands;
    using Model;
    using System;

    public class RemoveNodeElementActionCommand : RemoveEntityCommand, ISysCommand
    {
        public RemoveNodeElementActionCommand(Guid nodeElementActionId)
            : base(nodeElementActionId)
        {

        }
    }
}