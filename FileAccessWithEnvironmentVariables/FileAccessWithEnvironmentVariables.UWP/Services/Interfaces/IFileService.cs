﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileAccessWithEnvironmentVariables.UWP.Services.Interfaces
{
    public interface IFileService
    {
        Task<string> LoadFileContentUsingPathFromEnvironemntVariable(string environmentVariableName);
    }
}
