﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLibrary.Interfaces
{
    public interface IValidateServices
    {
         public int ValidateSelection(int selectionMenuMaxLimit);
         public decimal ValidateDecimalInputAboveZero();

    }
}
