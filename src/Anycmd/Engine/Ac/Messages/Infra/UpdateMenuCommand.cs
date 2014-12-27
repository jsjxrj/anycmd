﻿
namespace Anycmd.Engine.Ac.Messages.Infra
{
    using Commands;
    using InOuts;
    using Model;

    public class UpdateMenuCommand : UpdateEntityCommand<IMenuUpdateIo>, ISysCommand
    {
        public UpdateMenuCommand(IMenuUpdateIo input)
            : base(input)
        {

        }
    }
}