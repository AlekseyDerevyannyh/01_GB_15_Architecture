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
    public class ConsultationControllerTests
    {
        private ConsultationController _consultationController;
        private Mock<IConsultationRepository> _moqConsultationRepository;

        public ConsultationControllerTests() { 
            _moqConsultationRepository = new Mock<IConsultationRepository>();
            _consultationController = new ConsultationController(_moqConsultationRepository.Object);
        }

        [Fact]
        public void GetAllConsultationsTest()
        {
            List<Consultation> list = new List<Consultation>();
            list.Add(new Consultation());
            list.Add(new Consultation());
            list.Add(new Consultation());

            _moqConsultationRepository.Setup(repository => repository.GetAll()).Returns(list);

            var operationResult = _consultationController.GetAll();

            Assert.IsType<OkObjectResult>(operationResult.Result);
            Assert.IsAssignableFrom<List<Consultation>>(((OkObjectResult)operationResult.Result).Value);

            _moqConsultationRepository.Verify(repository => repository.GetAll(), Times.AtLeastOnce());
        }

        public static readonly object[][] CorrectCreateConsultationData =
        {
            new object[] {1, 1, new DateTime(1985, 5, 20), "new consultation" },
            new object[] {2, 2, new DateTime(1987, 2, 18), "some consultation" },
            new object[] {3, 3, new DateTime(1979, 1, 22), "consultation" },
        };

        [Theory]
        [MemberData(nameof(CorrectCreateConsultationData))]
        public void CreateConsultationTest(int clientId, int petId, DateTime consultationDate, string description)
        {
            _moqConsultationRepository.Setup(repository =>
            repository
                .Create(It.IsNotNull<Consultation>()))
                .Returns(1).Verifiable();

            var operationResult = _consultationController.Create(new CreateConsultationRequest
            {
                ClientId = clientId,
                PetId = petId,
                ConsultationDate = consultationDate,
                Description = description,
            });

            Assert.IsType<OkObjectResult>(operationResult.Result);
            Assert.IsAssignableFrom<int>(((OkObjectResult)operationResult.Result).Value);
            _moqConsultationRepository.Verify(repository =>
                repository.Create(It.IsNotNull<Consultation>()), Times.AtLeastOnce());
        }

        public static readonly object[][] CorrectUpdateConsultationData =
        {
            new object[] {1, 1, 1, new DateTime(1985, 5, 20), "new consultation" },
            new object[] {2, 2, 2, new DateTime(1987, 2, 18), "some consultation" },
            new object[] {3, 3, 3, new DateTime(1979, 1, 22), "consultation" },
        };

        [Theory]
        [MemberData(nameof(CorrectUpdateConsultationData))]
        public void UpdateClientTest(int consultationId, int clientId, int petId, DateTime consultationDate, string description)
        {
            _moqConsultationRepository.Setup(repository =>
            repository
                .Update(It.IsNotNull<Consultation>()))
                .Returns(1).Verifiable();

            var operationResult = _consultationController.Update(new UpdateConsultationRequest
            {
                ConsultationId = consultationId,
                ClientId = clientId,
                PetId = petId,
                ConsultationDate = consultationDate,
                Description = description,
            });

            Assert.IsType<OkObjectResult>(operationResult.Result);
            Assert.IsAssignableFrom<int>(((OkObjectResult)operationResult.Result).Value);
            _moqConsultationRepository.Verify(repository =>
                repository.Update(It.IsNotNull<Consultation>()), Times.AtLeastOnce());
        }

        public static readonly object[][] CorrectDeleteConsultationData =
        {
            new object[]{1},
            new object[]{2},
            new object[]{3}
        };

        [Theory]
        [MemberData(nameof(CorrectDeleteConsultationData))]
        public void DeleteClientTest(int ConsultationId)
        {
            _moqConsultationRepository.Setup(repository =>
            repository
                .Delete(It.IsNotNull<int>()))
                .Returns(1).Verifiable();

            var operationResult = _consultationController.Delete(ConsultationId);

            Assert.IsType<OkObjectResult>(operationResult.Result);
            Assert.IsAssignableFrom<int>(((OkObjectResult)operationResult.Result).Value);
            _moqConsultationRepository.Verify(repository =>
                repository.Delete(It.IsNotNull<int>()), Times.AtLeastOnce());
        }
    }
}
