﻿
namespace Anycmd.Engine.Ac.Messages
{
    using Commands;
    using InOuts;
    using Model;

    public class AddPrivilegeBigramCommand : AddEntityCommand<IPrivilegeBigramCreateIo>, ISysCommand
    {
        public AddPrivilegeBigramCommand(IPrivilegeBigramCreateIo input)
            : base(input)
        {

        }
    }
}