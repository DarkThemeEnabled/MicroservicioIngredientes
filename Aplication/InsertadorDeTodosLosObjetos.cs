using Aplication.Interfaces;
using CsvHelper;
using CsvHelper.Configuration;
using Domain.Entities;
using System.Globalization;

namespace Aplication
{
    public class InsertadorDeTodosLosObjetos
    {
        private readonly IIngredienteCommand _IngredienteCommand;
        private readonly ITipoIngredienteCommand _tipoIngredienteCommand;
        private readonly ITipoMedidaCommand _tipoMedidaCommand;
        private readonly IIngredienteQuery _Ingredientequery;

        public InsertadorDeTodosLosObjetos(IIngredienteCommand ingredienteCommand, ITipoIngredienteCommand tipoIngredienteCommand, ITipoMedidaCommand tipoMedidaCommand, IIngredienteQuery ingredientequery)
        {
            _IngredienteCommand = ingredienteCommand;
            _tipoIngredienteCommand = tipoIngredienteCommand;
            _tipoMedidaCommand = tipoMedidaCommand;
            _Ingredientequery = ingredientequery;
        }

        public async Task InsertarTodo()
        {            
                await InsertartipoMedida("TodosLosTiposDeMedida.csv");
                await InsertartipoIngrediente("TodosLosTiposDeIngredientes.csv");
                await InsertarIngrediente("TodosLosIngredientes.csv");
        }

        private async Task InsertartipoMedida(string csvTipoMedida)
        {
            string csvArchivo = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, csvTipoMedida);

            using (var reader = new StreamReader(csvArchivo))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                while (csv.Read())
                {
                    var tipoMedida = new TipoMedida
                    {
                        Name = csv.GetField<string>(0) // El índice 0 representa la primera columna en el CSV
                    };

                    await _tipoMedidaCommand.Insert(tipoMedida);
                }
            }
        }

        private async Task InsertartipoIngrediente(string csvTiposDeIngredientes)
        {
            string csvArchivo = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, csvTiposDeIngredientes);

            using (var reader = new StreamReader(csvArchivo))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                while (csv.Read())
                {
                    var tipoIngrediente = new TipoIngrediente
                    {
                        Name = csv.GetField<string>(0) // El índice 0 representa la primera columna en el CSV
                    };

                    await _tipoIngredienteCommand.Insert(tipoIngrediente);
                }
            }
        }

        public async Task InsertarIngrediente(string csvIngredientes)
        {
            string csvArchivo = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, csvIngredientes);

            using (var reader = new StreamReader(csvArchivo))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                while (csv.Read())
                {
                    // Obtener los campos de la fila
                    string nombre = csv.GetField<string>(0);
                    int tipoMedidaId = csv.GetField<int>(1);
                    int tipoIngredienteId = csv.GetField<int>(2);

                    // Crear un nuevo Ingrediente
                    var ingrediente = new Ingrediente
                    {
                        Name = nombre,
                        TipoMedidaID = tipoMedidaId,
                        TipoIngredienteID = tipoIngredienteId
                    };

                    // Insertar usando el _ingredienteCommand (o como se llame tu clase)
                    await _IngredienteCommand.Insert(ingrediente);
                }
            }
        }
    }
}
