using ClinicService.Controllers;
using ClinicService.Models;
using ClinicService.Models.Requests;
using ClinicService.Services;
using Microsoft.AspNetCore.Mvc;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicServiceTests
{
    public class PetControllerTests
    {
        private PetController _petController;
        private Mock<IPetRepository> _moqPetRepository;

        public PetControllerTests()
        {
            _moqPetRepository = new Mock<IPetRepository>();
            _petController = new PetController(_moqPetRepository.Object);
        }

        [Fact]
        public void GetAllPetsTest()
        {
            List<Pet> list = new List<Pet>();
            list.Add(new Pet());
            list.Add(new Pet());
            list.Add(new Pet());

            _moqPetRepository.Setup(repository => repository.GetAll()).Returns(list);

            var operationResult = _petController.GetAll();

            Assert.IsType<OkObjectResult>(operationResult.Result);
            Assert.IsAssignableFrom<List<Pet>>(((OkObjectResult)operationResult.Result).Value);

            _moqPetRepository.Verify(repository => repository.GetAll(), Times.AtLeastOnce());
        }

        public static readonly object[][] CorrectCreatePetData =
        {
            new object[] { 1, "Bobik", new DateTime(1985, 5, 20) },
            new object[] { 2, "Reks", new DateTime(1987, 2, 18) },
            new object[] { 3, "Murzik", new DateTime(1979, 1, 22) },
        };

        [Theory]
        [MemberData(nameof(CorrectCreatePetData))]
        public void CreatePetTest(int clientId, string name, DateTime birthday)
        {
            _moqPetRepository.Setup(repository =>
            repository
                .Create(It.IsNotNull<Pet>()))
                .Returns(1).Verifiable();

            var operationResult = _petController.Create(new CreatePetRequest
            {
                ClientId = clientId,
                Name = name,
                Birthday = birthday
            });

            Assert.IsType<OkObjectResult>(operationResult.Result);
            Assert.IsAssignableFrom<int>(((OkObjectResult)operationResult.Result).Value);
            _moqPetRepository.Verify(repository =>
                repository.Create(It.IsNotNull<Pet>()), Times.AtLeastOnce());
        }

        public static readonly object[][] CorrectUpdatePetData =
        {
            new object[] { 1, 1, "Bobik", new DateTime(1985, 5, 20) },
            new object[] { 2, 2, "Reks", new DateTime(1987, 2, 18) },
            new object[] { 3, 3, "Murzik", new DateTime(1979, 1, 22) },
        };

        [Theory]
        [MemberData(nameof(CorrectUpdatePetData))]
        public void UpdatePetTest(int petId, int clientId, string name, DateTime birthday)
        {
            _moqPetRepository.Setup(repository =>
            repository
                .Update(It.IsNotNull<Pet>()))
                .Returns(1).Verifiable();

            var operationResult = _petController.Update(new UpdatePetRequest
            {
                PetId = petId,
                ClientId = clientId,
                Name = name,
                Birthday = birthday
            });

            Assert.IsType<OkObjectResult>(operationResult.Result);
            Assert.IsAssignableFrom<int>(((OkObjectResult)operationResult.Result).Value);
            _moqPetRepository.Verify(repository =>
                repository.Update(It.IsNotNull<Pet>()), Times.AtLeastOnce());
        }

        public static readonly object[][] CorrectDeletePetData =
        {
            new object[]{1},
            new object[]{2},
            new object[]{3}
        };

        [Theory]
        [MemberData(nameof(CorrectDeletePetData))]
        public void DeletePetTest(int PetId)
        {
            _moqPetRepository.Setup(repository =>
            repository
                .Delete(It.IsNotNull<int>()))
                .Returns(1).Verifiable();

            var operationResult = _petController.Delete(PetId);

            Assert.IsType<OkObjectResult>(operationResult.Result);
            Assert.IsAssignableFrom<int>(((OkObjectResult)operationResult.Result).Value);
            _moqPetRepository.Verify(repository =>
                repository.Delete(It.IsNotNull<int>()), Times.AtLeastOnce());
        }
    }
}
