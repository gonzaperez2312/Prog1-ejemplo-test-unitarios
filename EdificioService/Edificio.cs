namespace EdificioService
{
    public class Edificio
    {
        public List<Departamento> Departamentos { get; set; }

        public Edificio() { 
            Departamentos = new List<Departamento>();
        }

        public bool AgregarDepartamento(int nroDepartamento, string nombreDueño) { 
            Departamento departamento = new Departamento();
            departamento.NombreDueño = nombreDueño;
            departamento.NroDepartamento = nroDepartamento;

            Departamentos.Add(departamento);

            return true;
        }

        public List<Departamento> ObtenerDepartamentosDesocupados() {
            List<Departamento> departamentosFiltrados = Departamentos.FindAll(x => x.NombreDueño == null);

            return departamentosFiltrados;
        }

        public string ObtenerNombreDepartamento(int nroDepartamento) {
            Departamento departamento = Departamentos.FirstOrDefault(x => x.NroDepartamento == nroDepartamento);

            if (departamento== null)
            {
                return null;
            }

            return departamento.ObtenerNombreCompletoDueño();
        }
    }
}