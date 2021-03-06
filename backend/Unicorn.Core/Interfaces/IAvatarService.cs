﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unicorn.Core.Interfaces
{
    public interface IAvatarService
    {
        Task UploadAvatar(string imageUrl, long id);
        Task UploadCroppedAvatar(string imageUrl, long id);
        Task UploadBackground(string imageUrl, long id);
    }
}
