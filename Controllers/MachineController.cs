using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using vega.DataAccess;
using Vega.Entities;
using Vega.Models;

namespace Vega.Controllers
{
    public class MachineController : Controller
    {

        private VegaDbContext _ctx;
       private IMapper _mapper;
       public MachineController(VegaDbContext ctx,IMapper mapper)
       {
          _ctx = ctx;
          _mapper = mapper;
       }
       [HttpGet("/api/makes")]
       
       public IEnumerable<MakeDto> GetMakes()
       {
         /* var entities= new List<Make>
          {
             new Make()
             {
                Id = 1,
                Name = "BMW",
                Models = new List<Model>
                {
                   new Model()
                   {
                      Id = 1,
                      Name = "Model 1"
                   },
                   new Model()
                   {
                      Id = 2,
                      Name = "Model2"
                   }
                }
             }
          };*/
          var entities = _ctx.Makes.ToList();
          return _mapper.Map<IEnumerable<MakeDto>>(entities);

       }

       [HttpGet("/api/features")]
       public IEnumerable<FeatureDto> GetFeatures()
       {
         /* return new List<Feature>
          {
             new Feature()
             {
                Id = 1,
                Name = "Feature1",
                Model = new Model()
                {
                   Id = 1,
                   Name = "Model1",
                   Make = new Make()
                   {
                      Id = 1,
                      Name = "BMW"
                   }
                }
             },
             
             new Feature()
             {
                Id = 2,
                Name = "Feature2",
                Model = new Model()
                {
                   Id = 1,
                   Name = "Model1",
                   Make = new Make()
                   {
                      Id = 1,
                      Name = "BMW"
                   }
                }
             }
          };*/
          var entities = _ctx.Features.ToList();
          return _mapper.Map<IEnumerable<FeatureDto>>(entities);
       }
    }
}