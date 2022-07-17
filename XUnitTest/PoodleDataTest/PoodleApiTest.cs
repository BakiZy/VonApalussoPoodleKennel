using AutoMapper;
using FirstRealApp.Controllers;
using FirstRealApp.Interfaces;
using FirstRealApp.Models;
using FirstRealApp.Models.DTO_models.PoodleDTos;
using FirstRealApp.Models.PoodleEntity;
using FirstRealApp.Repository;
using Microsoft.AspNetCore.Mvc;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace XUnitTest.PoodleDataTest
{
    public class PoodleApiTest
    {
        [Fact]

        public void GetPoodle_Valid_ReturnObject()
        {
            Poodle poodle = new Poodle()
            {
                Id = 1,
                Name = "Toy Love Story Don Juan",
                DateOfBirth = new DateTime(2020, 2, 1),
                GeneticTests = false,
                PedigreeNumber = "111",
                PoodleColor = new PoodleColor{ Id = 1, Name = "color1" },
                PoodleSize = new PoodleSize { Id = 1, Name = "size1"},
                Image = "https://i.imgur.com/oWXLx57.jpeg"
            };

            PoodleDTO poodleDTO = new PoodleDTO()
            {

                Id = 1,
                Name = "Toy Love Story Don Juan",
                DateOfBirth = new DateTime(2020, 2, 1),
                GeneticTests = false,
                PedigreeNumber = "111",
                PoodleColorName = "color1",
                PoodleSizeName = "size1",
                Image = "https://i.imgur.com/oWXLx57.jpeg"

            };

            var mockRepos = new Mock<IPoodlesRepository>();
            mockRepos.Setup(x => x.GetById(1)).Returns(poodle);

            var mapperConf = new MapperConfiguration(cfg => cfg.AddProfile(new PoodleProfile()));
            IMapper mapper = new Mapper(mapperConf);

            var controller = new PoodlesController(mockRepos.Object, mapper);

            //act
            var actionRes = controller.GetPoodleById(1) as OkObjectResult;

            //asert
            Assert.NotNull(actionRes);
            Assert.NotNull(actionRes.Value);

            PoodleDTO dtoResult = actionRes.Value as PoodleDTO;
            Assert.Equal(poodle.Id, dtoResult.Id);
            Assert.Equal(poodle.Name, dtoResult.Name);
            Assert.Equal(poodle.DateOfBirth, dtoResult.DateOfBirth);
            Assert.Equal(poodle.GeneticTests, dtoResult.GeneticTests);
            Assert.Equal(poodle.PoodleSize.Name, dtoResult.PoodleSizeName);
            Assert.Equal(poodle.PoodleColor.Name, dtoResult.PoodleColorName);
            Assert.Equal(poodle.Image, dtoResult.Image);



        }
        [Fact]
        public void PostPoodle_ValidReq_SetsHeader()
        {
            Poodle poodle = new Poodle()
            {
                Id = 1,
                Name = "Toy Love Story Don Juan",
                DateOfBirth = new DateTime(2020, 2, 1),
                GeneticTests = false,
                PedigreeNumber = "111",
                PoodleColor = new PoodleColor { Id = 1, Name = "color1" },
                PoodleSize = new PoodleSize { Id = 1, Name = "size1" },
                Image = "https://i.imgur.com/oWXLx57.jpeg"
            };

            var mockRepos = new Mock<IPoodlesRepository>();
            mockRepos.Setup(x => x.GetById(1)).Returns(poodle);

            var mapperConf = new MapperConfiguration(cfg => cfg.AddProfile(new PoodleProfile()));
            IMapper mapper = new Mapper(mapperConf);

            var controller = new PoodlesController(mockRepos.Object, mapper);

            //act
            var actionRes = controller.AddNewPoodle(poodle) as CreatedAtActionResult;

            //assert
            Assert.NotNull(actionRes);

            Assert.Equal("GetPoodleById", actionRes.ActionName);
            Assert.Equal(1, actionRes.RouteValues["id"]);
            Assert.Equal(poodle, actionRes.Value);

        }

        [Fact]

        public void PutPoodle_ValidReq_ReturnObject()
        {   //arrange
            Poodle poodle = new Poodle()
            {
                Id = 1,
                Name = "Toy Love Story Don Juan",
                DateOfBirth = new DateTime(2020, 2, 1),
                GeneticTests = false,
                PedigreeNumber = "111",
                PoodleColor = new PoodleColor { Id = 1, Name = "color1" },
                PoodleSize = new PoodleSize { Id = 1, Name = "size1" },
                Image = "https://i.imgur.com/oWXLx57.jpeg"
            };


            var mockRepos = new Mock<IPoodlesRepository>();
            mockRepos.Setup(x => x.GetById(1)).Returns(poodle);

            var mapperConf = new MapperConfiguration(cfg => cfg.AddProfile(new PoodleProfile()));
            IMapper mapper = new Mapper(mapperConf);

            var controller = new PoodlesController(mockRepos.Object, mapper);

            //act
            var actionRes = controller.UpdatePoodle(1, poodle) as OkObjectResult;

            //asert 

            Assert.NotNull(actionRes);
            Assert.NotNull(actionRes.Value);

            
        }





    }
}
