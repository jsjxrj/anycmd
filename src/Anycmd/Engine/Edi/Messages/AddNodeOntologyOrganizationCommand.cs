﻿
namespace Anycmd.Engine.Edi.Messages
{
    using Commands;
    using InOuts;
    using Model;

    public class AddNodeOntologyOrganizationCommand : AddEntityCommand<INodeOntologyOrganizationCreateIo>, ISysCommand
    {
        public AddNodeOntologyOrganizationCommand(INodeOntologyOrganizationCreateIo input)
            : base(input)
        {

        }
    }
}