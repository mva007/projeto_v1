﻿using Examples.Charge.Application.Messages.Response;
using System.Threading.Tasks;

namespace Examples.Charge.Application.Interfaces
{
    public interface IPersonPhoneFacade
    {
        Task<PersonPhoneListResponse> FindAllAsync();
    }
}