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
    public class ClientControllerTests
    {
        private ClientController _clientController;
        private Mock<IClientRepository> _moqClientRepository;

        public ClientControllerTests()
        {
            _moqClientRepository = new Mock<IClientRepository>();
            _clientController = new ClientController(_moqClientRepository.Object);
        }

        [Fact]
        public void GetAllClentsTest()
        {
            List<Client> list = new List<Client>();
            list.Add(new Client());
            list.Add(new Client());
            list.Add(new Client());

            _moqClientRepository.Setup(repository => repository.GetAll()).Returns(list);

            var operationResult = _clientController.GetAll();

            Assert.IsType<OkObjectResult>(operationResult.Result);
            Assert.IsAssignableFrom<List<Client>>(((OkObjectResult)operationResult.Result).Value);

            _moqClientRepository.Verify(repository => repository.GetAll(), Times.AtLeastOnce());
        }

        public static readonly object[][] CorrectCreateClientData =
        {
            new object[] { new DateTime(1985, 5, 20), "123 1234", "Иванов", "Андрей", "Сергеевич" },
            new object[] { new DateTime(1987, 2, 18), "123 2222", "Петров", "Михаил", "Александрович" },
            new object[] { new DateTime(1979, 1, 22), "123 4321", "Сидовров", "Олег", "Константинович" },
        };

        [Theory]
        [MemberData(nameof(CorrectCreateClientData))]
        public void CreateClientTest(DateTime birthday, string document, string surName, string firstName, string patronymic)
        {
            _moqClientRepository.Setup(repository =>
            repository
                .Create(It.IsNotNull<Client>()))
                .Returns(1).Verifiable();

            var operationResult = _clientController.Create(new CreateClientRequest
            {
                Birthday = birthday,
                Document = document,
                SurName = surName,
                FirstName = firstName,
                Patronymic = patronymic
            });

            Assert.IsType<OkObjectResult>(operationResult.Result);
            Assert.IsAssignableFrom<int>(((OkObjectResult)operationResult.Result).Value);
            _moqClientRepository.Verify(repository =>
                repository.Create(It.IsNotNull<Client>()), Times.AtLeastOnce());
        }

        public static readonly object[][] CorrectUpdateClientData =
        {
            new object[] {1, new DateTime(1985, 5, 20), "123 1234", "Иванов", "Андрей", "Сергеевич" },
            new object[] {2, new DateTime(1987, 2, 18), "123 2222", "Петров", "Михаил", "Александрович" },
            new object[] {3, new DateTime(1979, 1, 22), "123 4321", "Сидовров", "Олег", "Константинович" },
        };

        [Theory]
        [MemberData(nameof(CorrectUpdateClientData))]
        public void UpdateClientTest(int ClientId, DateTime birthday, string document, string surName, string firstName, string patronymic)
        {
            _moqClientRepository.Setup(repository =>
            repository
                .Update(It.IsNotNull<Client>()))
                .Returns(1).Verifiable();

            var operationResult = _clientController.Update(new UpdateClientRequest
            {
                ClientId = ClientId,
                Birthday = birthday,
                Document = document,
                SurName = surName,
                FirstName = firstName,
                Patronymic = patronymic
            });

            Assert.IsType<OkObjectResult>(operationResult.Result);
            Assert.IsAssignableFrom<int>(((OkObjectResult)operationResult.Result).Value);
            _moqClientRepository.Verify(repository =>
                repository.Update(It.IsNotNull<Client>()), Times.AtLeastOnce());
        }

        public static readonly object[][] CorrectDeleteClientData =
        {
            new object[]{1},
            new object[]{2},
            new object[]{3}
        };

        [Theory]
        [MemberData(nameof(CorrectDeleteClientData))]
        public void DeleteClientTest(int ClientId)
        {
            _moqClientRepository.Setup(repository =>
            repository
                .Delete(It.IsNotNull<int>()))
                .Returns(1).Verifiable();

            var operationResult = _clientController.Delete(ClientId);

            Assert.IsType<OkObjectResult>(operationResult.Result);
            Assert.IsAssignableFrom<int>(((OkObjectResult)operationResult.Result).Value);
            _moqClientRepository.Verify(repository =>
                repository.Delete(It.IsNotNull<int>()), Times.AtLeastOnce());
        }
    }
}
