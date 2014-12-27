﻿
namespace Anycmd.Engine.Ac.Messages.Infra
{
    using Commands;
    using InOuts;
    using Model;


    public class UpdateUiViewButtonCommand : UpdateEntityCommand<IUiViewButtonUpdateIo>, ISysCommand
    {
        public UpdateUiViewButtonCommand(IUiViewButtonUpdateIo input)
            : base(input)
        {

        }
    }
}