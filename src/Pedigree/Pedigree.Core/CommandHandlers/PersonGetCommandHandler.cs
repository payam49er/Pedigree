﻿using Microsoft.EntityFrameworkCore;
using Pedigree.Common.Models;
using Pedigree.Common.ViewModels;
using Vouzamo.EntityFramework.CommandHandlers;
using Vouzamo.Interop.Interfaces;

namespace Pedigree.Core.CommandHandlers
{
    public class PersonGetCommandHandler : GetCommandHandler<Person, PersonViewModel>
    {
        public PersonGetCommandHandler(IMapper mapper, DbContext context) : base(mapper, context)
        {

        }
    }
}
