﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyLog.ApplicationLogic.DTOs;

namespace MyLog.ApplicationLogic
{
    public interface IBaseService
    {
        ParametridiConfigurazioneDTO parametriDTO { get; set; }
    }
}

//COMPLETED