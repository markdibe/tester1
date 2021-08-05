using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using tester1.IServices;
using System.Linq.Dynamic.Core;

namespace tester1
{
    public class QueryFilterBO<T> : BaseBO where T : class
    {
        private readonly IGenericRepos<T> _generic;
        public QueryFilterBO(IUnitOfWork unit, IGenericRepos<T> generic, IMapper mapper) : base(unit, mapper)
        {
            _generic = generic;
        }

        public IQueryable<T> Filter(QueryFilter filter)
        {
            var result = _generic.GetAll();
            if (filter.PropertyNames.Length == filter.PropertyValues.Length
                && filter.PropertyNames.Length > 0)
            {
                string stringBuilder = string.Empty;
                foreach (string propertyName in filter.PropertyNames)
                {
                    int propertyIndex = Array.IndexOf(filter.PropertyNames, propertyName);
                    try
                    {
                        if (filter.Condition.ToLower() == AppSetting.AND.ToLower()
                            && propertyIndex < filter.PropertyNames.Length - 1)
                        {
                            stringBuilder += $" {propertyName} == @{propertyIndex} and ";
                        }
                        else if (filter.Condition.ToLower() == AppSetting.OR.ToLower()
                            && propertyIndex < filter.PropertyNames.Length - 1)
                        {
                            stringBuilder += $" {propertyName} == @{propertyIndex} or ";
                        }
                        else
                        {
                            stringBuilder += $" {propertyName} == @{propertyIndex} ";
                        }
                    }
                    catch
                    { }
                }
                result = result.Where(stringBuilder, filter.PropertyValues);
            }
            result = result.Skip(filter.PageNumber * filter.Range).Take(filter.Range);
            if (filter.OrderByDescending && !string.IsNullOrEmpty(filter.OrderProperty))
            {
                try
                {
                    result = result.OrderBy($"{filter.OrderProperty}").Reverse();
                }
                catch { }
            }
            return result;
        }
    }
}
