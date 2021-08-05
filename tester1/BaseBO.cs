using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tester1
{
    public class BaseBO
    {
        protected readonly IUnitOfWork _uow;
        protected readonly IMapper _mapper;

        public BaseBO(IUnitOfWork unit, IMapper mapper)
        {
            _uow = unit;
            _mapper = mapper;
        }
    }
}
