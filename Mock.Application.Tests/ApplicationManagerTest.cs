using Moq;
using Xunit;

namespace Mock.Application.Tests
{
    public class StudentApplicationManagerTest
    {        

        public StudentApplicationManagerTest()
        {
            
        }

        /// <summary>
        /// Un estudiante con nota media 4.15 y 18 años realiza una solitud de admisión y es ACEPTADO
        /// </summary>
        [Fact]
        public void ShouldBeAccepted()
        {
            // Arrange

            // Act
            // applicationManager.CheckApplication

            // Assert            

        }

        /// <summary>        
        /// Un estudiante con nota media de 2 y 16 años realiza una solitud de admisión y es RECHAZADO
        /// </summary>
        [Fact]
        public void ShouldBeRejected()
        {
            

        }       
    }
}