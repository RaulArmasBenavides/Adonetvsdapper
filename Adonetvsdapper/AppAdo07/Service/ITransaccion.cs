﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppAdo07.Service
{
    public interface ITransaccion <T>
    {
        // definir la firma
        int Registrar(T t);
    }

}
