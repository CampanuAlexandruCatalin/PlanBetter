using AutoMapper;
using Moq;
using PlanBetter.Business.Services;
using PlanBetter.Domain.Entities;
using PlanBetter.Domain.IRepositories;

namespace UnitTests
{
    [TestClass]
    public class TeacherServiceTests
    {
        private Mock<ITeacherRepository> _teacherRepositoryMock;
        private Mock<IMapper> _mapperMock;
        [TestInitialize]
        public void TestInitialize()
        {
            _teacherRepositoryMock = new Mock<ITeacherRepository>();
            _mapperMock = new Mock<IMapper>();
        }
        [TestMethod]
        public void DeleteTeacher_ShouldNotDeletTeacher_WhenTeacherDoesNotExists()
        {
            // Arrange
            // Could just not mock it, but it's better to be explicit
            Teacher teacher = null;
            _teacherRepositoryMock.Setup(r => r.GetById(It.IsAny<int>())).Returns(teacher);
            var teacherRepository = _teacherRepositoryMock.Object;
            var mapper = _mapperMock.Object;
            var sut =new TeacherService(teacherRepository, mapper);

            // Act
            sut.DeleteTeacher(1);

            // Assert
            _teacherRepositoryMock.Verify(r => r.Delete(It.IsAny<Teacher>()), Times.Never);
        }
    }
}