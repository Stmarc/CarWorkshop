﻿using CarWorkShop.Application.CarWorkshop;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarWorkShop.Application.CarWorkshop.Queris.GetAllCarWorkshop
{
    public class GetAllCarWorkshopQuery : IRequest<IEnumerable<CarWorkshopDto>>
    {
    }
}
