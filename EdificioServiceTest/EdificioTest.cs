using EdificioService;

namespace EdificioServiceTest
{
    public class EdificioTest
    {
        Edificio edificio = new Edificio();

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ObtenerDepartamentosLibresConTodosOcupados_Ok()
        {
            //Arrange
            List<Departamento> departamentos = new List<Departamento>();
            departamentos.Add(new Departamento()
            {
                NroDepartamento = 101,
                NombreDue�o = "Gonzalo"
            });

            departamentos.Add(new Departamento()
            {
                NroDepartamento = 102,
                NombreDue�o = "Maxi"
            });

            edificio.Departamentos = departamentos;

            //Act
            List<Departamento> departamentosResultado = edificio.ObtenerDepartamentosDesocupados();

            //Asserts
            Assert.That(departamentosResultado.Count, Is.EqualTo(0));
        }

        [Test]
        public void ObtenerDepartamentosLibresConDosDesocupados_Ok()
        {
            //Arrange
            List<Departamento> departamentos = new List<Departamento>();
            departamentos.Add(new Departamento()
            {
                NroDepartamento = 101,
                NombreDue�o = "Gonzalo"
            });

            departamentos.Add(new Departamento()
            {
                NroDepartamento = 102
            });

            departamentos.Add(new Departamento()
            {
                NroDepartamento = 103
            });

            edificio.Departamentos = departamentos;

            //Act
            List<Departamento> departamentosResultado = edificio.ObtenerDepartamentosDesocupados();

            //Asserts
            Assert.That(departamentosResultado.Count, Is.EqualTo(2));
        }
    }
}