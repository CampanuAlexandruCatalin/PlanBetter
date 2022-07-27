using AutoMapper;
using Moq;
using PlanBetter.Business.Services;
using PlanBetter.Domain.Entities;
using PlanBetter.Domain.IRepositories;

namespace UnitTests
{
    [TestClass]
    public class StudentServiceTests
    {
        private Mock<IStudentRepository> _studentRepositoryMock;
        private Mock<IMapper> _mapperMock;
        [TestInitialize]
        public void TestInitialize()
        {
            _studentRepositoryMock = new Mock<IStudentRepository>();
            _mapperMock = new Mock<IMapper>();
        }
        [TestMethod]
        public void DeleteStudent_ShouldNotDeletStudent_WheenStudentExists()
        {
            // Arrange
            // Could just not mock it, but it's better to be explicit
            Student student = null;
            _studentRepositoryMock.Setup(r => r.GetById(It.IsAny<int>())).Returns(student);
            var studentRepository = _studentRepositoryMock.Object;
            var mapper = _mapperMock.Object;
            var sut = new StudentService(studentRepository, mapper);

            // Act
            sut.DeleteStudent(1);

            // Assert
            _studentRepositoryMock.Verify(r => r.Delete(It.IsAny<Student>()), Times.Never);
        }
    }
}