﻿using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Features
{
    public class AuthAccessRequirement : IAuthorizationRequirement
    {
        // This is empty, but you can have a bunch of properties and methods here if you like that you can later access from the AuthorizationHandler.
    }
}
