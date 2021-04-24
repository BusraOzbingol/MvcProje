﻿using Business.Abstract;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class HeadingManager:IHeadingService
    {
        [ValidationAspect(typeof(HeadingValidator))]
        public void Add(Heading heading)
        {

        }
    }
}
