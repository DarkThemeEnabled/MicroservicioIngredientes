using Aplication;
using Aplication.Interfaces;
using Infraestructure.Command;
using Infraestructure.Persistence;
using Infraestructure.Querys;

Console.WriteLine("hello world");
IngredientesDBContext context = new IngredientesDBContext();

IIngredienteCommand commandIngrediente = new IngredienteCommand(context);
IIngredienteQuery queryIngrdiente = new IngredienteQuery(context);

ITipoIngredienteCommand commandTipoIngrediente = new TipoIngredienteCommand(context);

ITipoMedidaCommand commandTipoMedida = new TipoMedidaCommand(context);

InsertadorDeTodosLosObjetos insertAll = new InsertadorDeTodosLosObjetos(commandIngrediente, commandTipoIngrediente, commandTipoMedida, queryIngrdiente);

await insertAll.InsertarIngrediente("TodosLosIngredientes.csv");
