using Business.Abstract;
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
    public class WriterManager:IWriterService
    {
        [ValidationAspect(typeof(WriterValidator))]
        public void Add(Writer writer)
        {

        }
    }
}
