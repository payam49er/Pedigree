﻿using Pedigree.Common.Models;
using Pedigree.Common.ViewModels;
using Vouzamo.EntityFramework.CommandHandlers;
using Microsoft.EntityFrameworkCore;
using Vouzamo.Interop.Interfaces;

namespace Pedigree.Core.CommandHandlers
{
    public class DogGetCommandHandler : GetCommandHandler<Dog, DogViewModel>
    {
        public DogGetCommandHandler(IMapper mapper, DbContext context) : base(mapper, context)
        {

        }
    }
}
