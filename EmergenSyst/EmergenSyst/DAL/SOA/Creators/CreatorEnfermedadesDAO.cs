﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class CreatorEnfermedadesDAO : CreatorDatosClinicosDAO
    {
        public DatosClinicosDAO creator()
        {
            return new EnfermedadesDAO();
        }
    }
}
