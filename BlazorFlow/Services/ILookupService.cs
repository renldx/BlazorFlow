using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BlazorFlow.Data;
using BlazorFlow.Enums;
using AutoMapper;

namespace BlazorFlow.Services
{
    public interface ILookupService
    {
        List<Models.FlowAnswer> GetLookupValues(FlowEntity entity);
    }
}
