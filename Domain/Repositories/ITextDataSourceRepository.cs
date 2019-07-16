﻿using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Repositories
{
    public interface ITextDataSourceRepository
    {
         List<SampleInputLine> GetListInputLine(string routeArchive);
    }
}
