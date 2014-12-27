﻿
namespace Anycmd.Engine.Edi.Messages
{
    using Commands;
    using InOuts;
    using Model;

    public class AddOrganizationActionCommand: AddEntityCommand<IOrganizationActionCreateIo>, ISysCommand
    {
        public AddOrganizationActionCommand(IOrganizationActionCreateIo input)
            : base(input)
        {

        }
    }
}