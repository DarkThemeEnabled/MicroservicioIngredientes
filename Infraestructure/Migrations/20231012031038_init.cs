﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infraestructure.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TiposIngrediente",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TiposIngrediente", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TiposMedida",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TiposMedida", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Ingredientes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TipoIngredienteID = table.Column<int>(type: "int", nullable: false),
                    TipoMedidaID = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ingredientes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ingredientes_TiposIngrediente_TipoIngredienteID",
                        column: x => x.TipoIngredienteID,
                        principalTable: "TiposIngrediente",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Ingredientes_TiposMedida_TipoMedidaID",
                        column: x => x.TipoMedidaID,
                        principalTable: "TiposMedida",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "TiposIngrediente",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Frutas" },
                    { 2, "Vegetales" },
                    { 3, "Carnes" },
                    { 4, "Pescados" },
                    { 5, "Mariscos" },
                    { 6, "Granos y Cereales" },
                    { 7, "Legumbres" },
                    { 8, "Lácteos" },
                    { 9, "Huevos" },
                    { 10, "Harinas y Granos Molidos" },
                    { 11, "Aceites y Grasas" },
                    { 12, "Frutos Secos" },
                    { 13, "Hierbas y Especias" },
                    { 14, "Condimentos y Salsas" },
                    { 15, "Productos de Panadería" },
                    { 16, "Bebidas" },
                    { 17, "Dulces y Azúcares" },
                    { 18, "Productos lácteos alternativos" },
                    { 19, "Alimentos procesados" },
                    { 20, "Productos de Soja y Alternativas Vegetales" },
                    { 21, "Algas y Vegetales del Mar" },
                    { 22, "Setas y Hongos" },
                    { 23, "Tubérculos y Raíces" },
                    { 24, "Grasas y Aceites Especiales" },
                    { 25, "Productos Fermentados" },
                    { 26, "Verduras de Hojas Verdes" },
                    { 27, "Flores Comestibles" },
                    { 28, "Frutas Exóticas" },
                    { 29, "Frutas Tropicales" },
                    { 30, "Hierbas Aromáticas" },
                    { 31, "Frutas del Bosque" },
                    { 32, "Condimentos Secos" },
                    { 33, "Condimentos Frescos" },
                    { 34, "Alimentos Integrales" },
                    { 35, "Frutas Deshidratadas" },
                    { 36, "Mariscos de Agua Dulce" },
                    { 37, "Mariscos de Agua Salada" },
                    { 38, "Cortezas y Cascas" },
                    { 39, "Alimentos Enlatados" },
                    { 40, "Productos de Origen Animal Alternativo" },
                    { 41, "Alimentos a Base de Granos Integrales" },
                    { 42, "Alimentos a Base de Legumbres" },
                    { 43, "Frutas de Hueso" },
                    { 44, "Frutas de Pepita" },
                    { 45, "Aderezos para Ensaladas" },
                    { 46, "Guarniciones" },
                    { 47, "Tés e Infusiones" },
                    { 48, "Productos de Repostería" },
                    { 49, "Sopas y Caldos" },
                    { 50, "Alimentos de Origen Silvestre" }
                });

            migrationBuilder.InsertData(
                table: "TiposMedida",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Unidad" },
                    { 2, "Kilogramo" },
                    { 3, "Gramo" },
                    { 4, "Litro" },
                    { 5, "Mililitro" },
                    { 6, "Taza" },
                    { 7, "Cucharada" },
                    { 8, "Cucharadita" },
                    { 9, "Onza" }
                });

            migrationBuilder.InsertData(
                table: "Ingredientes",
                columns: new[] { "Id", "Name", "TipoIngredienteID", "TipoMedidaID" },
                values: new object[,]
                {
                    { 1, "Aceite de Aguacate", 24, 2 },
                    { 2, "Aceite de Canola", 24, 2 },
                    { 3, "Aceite de Coco", 24, 2 },
                    { 4, "Aceite de Coco Virgen", 24, 2 },
                    { 5, "Aceite de Oliva", 24, 2 },
                    { 6, "Aceite de Oliva Virgen Extra", 24, 2 },
                    { 7, "Aceite de Pescado", 24, 2 },
                    { 8, "Aceite de Semilla de Uva", 24, 2 },
                    { 9, "Aceite de Sesamo", 24, 2 },
                    { 10, "Aceite de Sesamo Tostado", 24, 2 },
                    { 11, "Aceite de Trufa", 24, 2 },
                    { 12, "Aceitunas", 24, 2 },
                    { 13, "Aceitunas Kalamata", 24, 2 },
                    { 14, "Aceitunas Kalamata Rellenas de Queso Feta", 24, 2 },
                    { 15, "Aceitunas Negras", 24, 2 },
                    { 16, "Aceitunas Rellenas de Jalapeños", 24, 2 },
                    { 17, "Aceitunas Rellenas de Pimiento", 24, 2 },
                    { 18, "Aceitunas Stuffed", 24, 2 },
                    { 19, "Aceitunas Verdes", 24, 2 },
                    { 20, "Aceitunas Verdes Rellenas", 24, 2 },
                    { 21, "Aceitunas Verdes Rellenas de Pimiento", 24, 2 },
                    { 22, "Acelga", 26, 2 },
                    { 23, "Acelga Roja", 26, 2 },
                    { 24, "Acelga Suiza", 26, 2 },
                    { 25, "Agua con Gas", 1, 5 },
                    { 26, "Agua de Coco", 1, 5 },
                    { 27, "Aguacate", 1, 1 },
                    { 28, "Aguacates", 1, 1 },
                    { 29, "Ajo", 13, 7 },
                    { 30, "Ajo Negro", 13, 7 },
                    { 31, "Albahaca", 13, 7 },
                    { 32, "Albahaca Fresca", 13, 7 },
                    { 33, "Alcachofa", 2, 6 },
                    { 34, "Almejas", 5, 2 },
                    { 35, "Almendras", 28, 3 },
                    { 36, "Almendras Fileteadas", 28, 3 },
                    { 37, "Alubias Verdes", 7, 6 },
                    { 38, "Anacardos", 28, 3 },
                    { 39, "Anchoas", 4, 2 },
                    { 40, "Arroz", 6, 2 },
                    { 41, "Arroz Basmati", 6, 2 },
                    { 42, "Arroz Integral", 6, 2 },
                    { 43, "Arandanos", 31, 1 },
                    { 44, "Arandanos Secos", 36, 2 },
                    { 45, "Avena", 6, 2 },
                    { 46, "Avena en Hojuelas", 6, 2 },
                    { 47, "Avena Instantanea", 6, 2 },
                    { 48, "Avena Steel Cut", 6, 2 },
                    { 49, "Azafran", 13, 2 },
                    { 50, "Azucar Moreno", 17, 4 },
                    { 51, "Bacon", 3, 2 },
                    { 52, "Berenjena", 2, 6 },
                    { 53, "Berros", 26, 3 },
                    { 54, "Boniato", 23, 6 },
                    { 55, "Brocoli", 2, 6 },
                    { 56, "Cacahuetes", 28, 3 },
                    { 57, "Cacahuetes Salados", 28, 3 },
                    { 58, "Cacahuetes Tostados", 28, 3 },
                    { 59, "Cacao en Polvo", 17, 2 },
                    { 60, "Cafe", 48, 7 },
                    { 61, "Calabacïn", 2, 6 },
                    { 62, "Calabacïn Amarillo", 2, 6 },
                    { 63, "Calabaza", 29, 1 },
                    { 64, "Calabaza Butternut", 29, 1 },
                    { 65, "Calabaza Delicata", 29, 1 },
                    { 66, "Calamares", 5, 2 },
                    { 67, "Caldo de Pollo", 49, 4 },
                    { 68, "Caldo de Pollo Bajo en Sodio", 49, 4 },
                    { 69, "Caldo de Res", 49, 4 },
                    { 70, "Caldo de Verduras", 49, 4 },
                    { 71, "Caldo de Verduras Organico", 49, 4 },
                    { 72, "Camarones", 5, 2 },
                    { 73, "Camarones al Ajillo", 5, 2 },
                    { 74, "Camote", 23, 6 },
                    { 75, "Canela", 13, 2 },
                    { 76, "Canela en Polvo", 13, 2 },
                    { 77, "Canela en Rama", 13, 2 },
                    { 78, "Cangrejo", 5, 2 },
                    { 79, "Cebolla Morada", 2, 6 },
                    { 80, "Cebolla Roja", 2, 6 },
                    { 81, "Cebollas", 2, 6 },
                    { 82, "Cereal de Avena", 6, 2 },
                    { 83, "Cereal Integral", 6, 2 },
                    { 84, "Cerveza", 16, 7 },
                    { 85, "Cerveza de Trigo", 16, 7 },
                    { 86, "Cerveza Negra", 16, 7 },
                    { 87, "Champiñones", 22, 3 },
                    { 88, "Champiñones Portobello", 22, 3 },
                    { 89, "Chirimoya", 29, 1 },
                    { 90, "Chirivïa", 2, 6 },
                    { 91, "Chocolate", 17, 2 },
                    { 92, "Chocolate Amargo", 17, 2 },
                    { 93, "Chocolate Blanco", 17, 2 },
                    { 94, "Chocolate con Leche", 17, 2 },
                    { 95, "Chocolate Negro", 17, 2 },
                    { 96, "Chucrut", 2, 6 },
                    { 97, "Cilantro", 13, 7 },
                    { 98, "Cilantro en Polvo", 13, 2 },
                    { 99, "Cilantro Fresco", 13, 7 },
                    { 100, "Ciruelas", 29, 1 },
                    { 101, "Coco Desecado", 29, 2 },
                    { 102, "Coco Rallado", 29, 2 },
                    { 103, "Coliflor", 2, 6 },
                    { 104, "Coliflor Morada", 2, 6 },
                    { 105, "Crema de Almendras", 12, 2 },
                    { 106, "Crema de Cacahuate", 12, 2 },
                    { 107, "Crema de Coco", 24, 2 },
                    { 108, "Curcuma", 13, 2 },
                    { 109, "Curcuma en Polvo", 13, 2 },
                    { 110, "Eneldo", 13, 7 },
                    { 111, "Ensalada Cesar", 46, 6 },
                    { 112, "Ensalada de Garbanzos", 46, 6 },
                    { 113, "Ensalada de Quinoa", 46, 6 },
                    { 114, "Espinaca", 26, 2 },
                    { 115, "Espinacas", 26, 2 },
                    { 116, "Espinacas Baby", 26, 2 },
                    { 117, "Fideos de Arroz", 6, 2 },
                    { 118, "Fideos de Huevo", 6, 2 },
                    { 119, "Fideos de Lentejas", 6, 2 },
                    { 120, "Fideos de Soba", 6, 2 },
                    { 121, "Fideos Udon", 6, 2 },
                    { 122, "Filete de Ternera", 3, 2 },
                    { 123, "Frambuesas", 31, 1 },
                    { 124, "Fresas", 31, 1 },
                    { 125, "Fresas Frescas", 31, 1 },
                    { 126, "Frijoles Negros", 7, 6 },
                    { 127, "Frutas del Bosque", 31, 1 },
                    { 128, "Galletas", 15, 2 },
                    { 129, "Galletas de Avena", 15, 2 },
                    { 130, "Galletas de Jengibre", 15, 2 },
                    { 131, "Gelatina", 17, 4 },
                    { 132, "Ghee", 24, 2 },
                    { 133, "Granada", 29, 1 },
                    { 134, "Granola", 6, 2 },
                    { 135, "Guayaba", 29, 1 },
                    { 136, "Guindilla en Polvo", 14, 2 },
                    { 137, "Guindillas", 2, 6 },
                    { 138, "Guisantes", 7, 6 },
                    { 139, "Guisantes Congelados", 7, 6 },
                    { 140, "Guisantes Dulces", 7, 6 },
                    { 141, "Hamburguesa de Res", 3, 2 },
                    { 142, "Harina de Coco", 6, 2 },
                    { 143, "Harina de Trigo", 10, 2 },
                    { 144, "Helado de Menta", 17, 5 },
                    { 145, "Higos", 29, 1 },
                    { 146, "Hinojo", 2, 6 },
                    { 147, "Hojas de Laurel", 13, 7 },
                    { 148, "Hojas de Parra", 2, 6 },
                    { 149, "Huevo de Codorniz", 9, 1 },
                    { 150, "Huevo Duro", 9, 1 },
                    { 151, "Huevos", 9, 1 },
                    { 152, "Huevos Benedictinos", 9, 1 },
                    { 153, "Huevos de Codorniz", 9, 1 },
                    { 154, "Huevos de Pavo", 9, 1 },
                    { 155, "Huevos Revueltos", 9, 1 },
                    { 156, "Hummus", 7, 2 },
                    { 157, "Jengibre", 13, 7 },
                    { 158, "Jengibre Fresco", 13, 7 },
                    { 159, "Jugo de Arandano", 1, 5 },
                    { 160, "Jugo de Granada", 1, 5 },
                    { 161, "Jugo de Guayaba", 1, 5 },
                    { 162, "Jugo de Limon", 1, 5 },
                    { 163, "Jugo de Manzana", 1, 5 },
                    { 164, "Jugo de Naranja", 1, 5 },
                    { 165, "Jugo de Piña", 1, 5 },
                    { 166, "Jugo de Uva", 1, 5 },
                    { 167, "Kiwi", 29, 1 },
                    { 168, "Leche", 8, 4 },
                    { 169, "Lechuga Romana", 26, 3 },
                    { 170, "Lentejas", 7, 6 },
                    { 171, "Lentejas Rojas", 7, 6 },
                    { 172, "Levadura Nutricional", 12, 2 },
                    { 173, "Lima", 1, 1 },
                    { 174, "Lima Kaffir", 1, 1 },
                    { 175, "Limón", 1, 1 },
                    { 176, "Limón Arbi", 1, 1 },
                    { 177, "Lomo de Cerdo", 3, 2 },
                    { 178, "Mandarina", 1, 1 },
                    { 179, "Mango", 29, 1 },
                    { 180, "Mango Chutney", 14, 4 },
                    { 181, "Mango Deshidratado", 35, 2 },
                    { 182, "Mango Fresco", 29, 1 },
                    { 183, "Mango Seco", 35, 2 },
                    { 184, "Mantequilla", 24, 2 },
                    { 185, "Mantequilla de Almendra", 12, 2 },
                    { 186, "Mantequilla de Maní", 12, 2 },
                    { 187, "Manzanas", 1, 1 },
                    { 188, "Maïz", 7, 6 },
                    { 189, "Menta", 13, 7 },
                    { 190, "Mermelada", 17, 4 },
                    { 191, "Miel", 17, 4 },
                    { 192, "Miel de Abeja", 17, 4 },
                    { 193, "Miso", 14, 4 },
                    { 194, "Miso Rojo", 14, 4 },
                    { 195, "Molokhia", 26, 3 },
                    { 196, "Mora", 31, 1 },
                    { 197, "Mostaza", 14, 4 },
                    { 198, "Mousse de Chocolate", 17, 4 },
                    { 199, "Nabo", 2, 6 },
                    { 200, "Naranja", 1, 1 },
                    { 201, "Nueces", 28, 3 },
                    { 202, "Nueces de Brasil", 28, 3 },
                    { 203, "Nuez", 28, 3 },
                    { 204, "Nuez Moscada", 13, 3 },
                    { 205, "Paella", 6, 2 },
                    { 206, "Palta", 1, 1 },
                    { 207, "Pan Blanco", 15, 2 },
                    { 208, "Pan de Ajo", 15, 2 },
                    { 209, "Pan de Centeno", 15, 2 },
                    { 210, "Pan de Pita", 15, 2 },
                    { 211, "Pan de Pita Integral", 15, 2 },
                    { 212, "Pan Integral", 15, 2 },
                    { 213, "Pan Multicereal", 15, 2 },
                    { 214, "Papas", 23, 6 },
                    { 215, "Papas Asadas", 23, 6 },
                    { 216, "Papas Bravas", 23, 6 },
                    { 217, "Papas Fritas", 23, 6 },
                    { 218, "Papaya", 29, 1 },
                    { 219, "Paprika", 13, 2 },
                    { 220, "Pargo", 4, 2 },
                    { 221, "Pargo Rojo", 4, 2 },
                    { 222, "Pasta", 6, 2 },
                    { 223, "Pasta de Almendra", 12, 2 },
                    { 224, "Pasta de Curry Rojo", 14, 4 },
                    { 225, "Pasta Integral", 6, 2 },
                    { 226, "Pechuga de Pavo", 3, 2 },
                    { 227, "Pechuga de Pollo", 3, 2 },
                    { 228, "Pepinillos", 2, 6 },
                    { 229, "Pepino", 2, 6 },
                    { 230, "Pepitas de Calabaza", 12, 2 },
                    { 231, "Pepitas de Girasol", 12, 2 },
                    { 232, "Peras", 1, 1 },
                    { 233, "Perejil", 13, 7 },
                    { 234, "Pescado Blanco", 4, 2 },
                    { 235, "Pesto", 14, 4 },
                    { 236, "Pimienta de Cayena", 14, 2 },
                    { 237, "Pimienta de Jamaica", 14, 2 },
                    { 238, "Pimienta de Sichuan", 14, 2 },
                    { 239, "Pimienta Negra", 14, 2 },
                    { 240, "Pimienta Rosa", 14, 2 },
                    { 241, "Pimiento Rojo", 2, 6 },
                    { 242, "Pimientos", 2, 6 },
                    { 243, "Pimientos Amarillos", 2, 6 },
                    { 244, "Pimientos Jalapeños", 2, 6 },
                    { 245, "Pimientos Rojos", 2, 6 },
                    { 246, "Pimientos Rojos Asados", 2, 6 },
                    { 247, "Pimientos Verdes", 2, 6 },
                    { 248, "Pipas de Calabaza", 12, 2 },
                    { 249, "Pipas de Girasol", 12, 2 },
                    { 250, "Pistachos", 28, 3 },
                    { 251, "Piña", 29, 1 },
                    { 252, "Plátano", 1, 1 },
                    { 253, "Pomelo", 1, 1 },
                    { 254, "Puerro", 2, 6 },
                    { 255, "Queso", 8, 2 },
                    { 256, "Queso Azul", 8, 2 },
                    { 257, "Queso Cheddar", 8, 2 },
                    { 258, "Queso de Búfala", 8, 2 },
                    { 259, "Queso de Cabra", 8, 2 },
                    { 260, "Queso en Feta", 8, 2 },
                    { 261, "Queso Gouda", 8, 2 },
                    { 262, "Queso Gouda Ahumado", 8, 2 },
                    { 263, "Queso Gruyere", 8, 2 },
                    { 264, "Queso Panela", 8, 2 },
                    { 265, "Queso Parmesano", 8, 2 },
                    { 266, "Queso Ricotta", 8, 2 },
                    { 267, "Queso Roquefort", 8, 2 },
                    { 268, "Quinoa", 6, 2 },
                    { 269, "Rabano", 2, 6 },
                    { 270, "Ralladura de Naranja", 1, 1 },
                    { 271, "Relleno de Pavo", 3, 2 },
                    { 272, "Ricotta", 8, 2 },
                    { 273, "Ricotta Fresca", 8, 2 },
                    { 274, "Rábano Picante", 2, 6 },
                    { 275, "Rúcula", 26, 3 },
                    { 276, "Sal", 14, 2 },
                    { 277, "Salmón", 4, 2 },
                    { 278, "Salmón Ahumado", 4, 2 },
                    { 279, "Salsa BBQ", 14, 4 },
                    { 280, "Salsa de Ajo", 14, 4 },
                    { 281, "Salsa de Arándanos", 14, 4 },
                    { 282, "Salsa de Chile", 14, 4 },
                    { 283, "Salsa de Chile Dulce", 14, 4 },
                    { 284, "Salsa de Curry", 14, 4 },
                    { 285, "Salsa de Miel y Mostaza", 14, 4 },
                    { 286, "Salsa de Ostras", 14, 4 },
                    { 287, "Salsa de Queso", 14, 4 },
                    { 288, "Salsa de Soja", 14, 4 },
                    { 289, "Salsa de Soja Tamari", 14, 4 },
                    { 290, "Salsa de Tomate", 14, 4 },
                    { 291, "Salsa de Trufa", 14, 4 },
                    { 292, "Salsa Hoisin", 14, 4 },
                    { 293, "Salsa Pesto", 14, 4 },
                    { 294, "Salsa Sriracha", 14, 4 },
                    { 295, "Salsa Teriyaki", 14, 4 },
                    { 296, "Salsa Tártara", 14, 4 },
                    { 297, "Salsa Worcestershire", 14, 4 },
                    { 298, "Sardinas", 5, 2 },
                    { 299, "Semillas de Amapola", 12, 2 },
                    { 300, "Semillas de Chía", 12, 2 },
                    { 301, "Tahini", 12, 2 },
                    { 302, "Tamarindo", 2, 1 },
                    { 303, "Tamarindo en Pasta", 2, 1 },
                    { 304, "Ternera", 3, 2 },
                    { 305, "Tocino", 3, 2 },
                    { 306, "Tofu", 20, 2 },
                    { 307, "Tofu Ahumado", 20, 2 },
                    { 308, "Tofu Firme", 20, 2 },
                    { 309, "Tofu Sedoso", 20, 2 },
                    { 310, "Tomate Cherry", 2, 1 },
                    { 311, "Tomate", 2, 1 },
                    { 312, "Tomate Raf", 2, 1 },
                    { 313, "Tomate Seco", 2, 1 },
                    { 314, "Tomate Verde", 2, 1 },
                    { 315, "Tomates", 2, 1 },
                    { 316, "Tomates enlatados", 2, 1 },
                    { 317, "Tomates Secos en Aceite", 2, 1 },
                    { 318, "Tomillo", 13, 7 },
                    { 319, "Tortellini", 6, 2 },
                    { 320, "Trigo Bulgur", 6, 2 },
                    { 321, "Trucha", 4, 2 },
                    { 322, "Té Chai", 48, 7 },
                    { 323, "Té de Hibisco", 48, 7 },
                    { 324, "Té de Hierbabuena", 48, 7 },
                    { 325, "Té Negro", 48, 7 },
                    { 326, "Té Verde", 48, 7 },
                    { 327, "Uva", 31, 1 },
                    { 328, "Vainilla en Rama", 13, 2 },
                    { 329, "Vinagre", 14, 4 },
                    { 330, "Vinagre Balsámico", 14, 4 },
                    { 331, "Vinagre de Manzana", 14, 4 },
                    { 332, "Vinagre de Vino Tinto", 14, 4 },
                    { 333, "Vino Blanco", 16, 5 },
                    { 334, "Vino Rosado", 16, 5 },
                    { 335, "Vino Tinto", 16, 5 },
                    { 336, "Yogur", 8, 4 },
                    { 337, "Yogur Griego Natural", 8, 4 },
                    { 338, "Zanahorias", 23, 6 },
                    { 339, "Zanahorias Baby", 23, 6 },
                    { 340, "Zanahorias Moradas", 23, 6 },
                    { 341, "Zapallo", 29, 2 },
                    { 342, "Zapallito", 29, 2 },
                    { 343, "Chinchulines", 3, 2 },
                    { 344, "Mollejas", 3, 2 },
                    { 345, "Riñones", 3, 2 },
                    { 346, "Hígado", 3, 2 },
                    { 347, "Corazón", 3, 2 },
                    { 348, "Morcilla", 3, 2 },
                    { 349, "Tripas", 3, 2 },
                    { 350, "Sesos", 3, 2 },
                    { 351, "Ubres", 3, 2 },
                    { 352, "Criadillas", 3, 2 },
                    { 353, "Asado", 3, 2 },
                    { 354, "Tira de asado", 3, 2 },
                    { 355, "Vacío", 3, 2 },
                    { 356, "Matambre", 3, 2 },
                    { 357, "Cuadril", 3, 2 },
                    { 358, "Entraña", 3, 2 },
                    { 359, "Bife de chorizo", 3, 2 },
                    { 360, "Ojo de bife", 3, 2 },
                    { 361, "Lomo", 3, 2 },
                    { 362, "Colita de cuadril", 3, 2 },
                    { 363, "Picaña", 3, 2 },
                    { 364, "Bife ancho", 3, 2 },
                    { 365, "Costillar", 3, 2 },
                    { 366, "Falda", 3, 2 },
                    { 367, "Osobuco", 3, 2 },
                    { 368, "Bondiola", 3, 2 },
                    { 369, "Lomo de cerdo", 3, 2 },
                    { 370, "Matambre de cerdo", 3, 2 },
                    { 371, "Costillar de cerdo", 3, 2 },
                    { 372, "Chuletas de cerdo", 3, 2 },
                    { 373, "Panceta", 3, 2 },
                    { 374, "Morcilla", 3, 2 },
                    { 375, "Chorizo", 3, 2 },
                    { 376, "Salchicha parrillera", 3, 2 },
                    { 377, "Pechito de cerdo", 3, 2 },
                    { 378, "Harina de Maíz", 10, 3 },
                    { 379, "Harina de Arroz", 10, 3 },
                    { 380, "Harina de Avena", 10, 3 },
                    { 381, "Harina de Centeno", 10, 3 },
                    { 382, "Harina de Espelta", 10, 3 },
                    { 383, "Harina de Almendra", 10, 3 },
                    { 384, "Harina de Avena", 10, 3 },
                    { 385, "Harina de Garbanzo", 10, 3 },
                    { 386, "Harina de Quinoa", 10, 3 },
                    { 387, "Harina de Mijo", 10, 3 },
                    { 388, "Harina de Sorgo", 10, 3 },
                    { 389, "Harina de Trigo Sarraceno", 10, 3 },
                    { 390, "Harina de Teff", 10, 3 },
                    { 391, "Harina de Kamut", 10, 3 },
                    { 392, "Harina de Amaranto", 10, 3 },
                    { 393, "Harina de Nuez", 10, 3 },
                    { 394, "Harina de Maíz Morado", 10, 3 },
                    { 395, "Harina de Lentejas", 10, 3 },
                    { 396, "Harina de Soja", 10, 3 },
                    { 397, "Harina de Garbanzo", 10, 3 },
                    { 398, "Harina de Patata", 10, 3 },
                    { 399, "Harina de Yuca", 10, 3 },
                    { 400, "Queso Brie", 8, 2 },
                    { 401, "Queso Camembert", 8, 2 },
                    { 402, "Queso Havarti", 8, 2 },
                    { 403, "Queso Gorgonzola", 8, 2 },
                    { 404, "Queso Manchego", 8, 2 },
                    { 405, "Queso Mozzarella", 8, 2 },
                    { 406, "Queso Provolone", 8, 2 },
                    { 407, "Queso Swiss", 8, 2 },
                    { 408, "Queso Gouda de Cabra", 8, 2 },
                    { 409, "Queso Emmental", 8, 2 },
                    { 410, "Queso Fontina", 8, 2 },
                    { 411, "Queso Havarti", 8, 2 },
                    { 412, "Queso Jarlsberg", 8, 2 },
                    { 413, "Queso Mascarpone", 8, 2 },
                    { 414, "Queso Monterey Jack", 8, 2 },
                    { 415, "Queso Pecorino", 8, 2 },
                    { 416, "Queso Saint-Nectaire", 8, 2 },
                    { 417, "Queso Taleggio", 8, 2 },
                    { 418, "Queso Tomme", 8, 2 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Ingredientes_TipoIngredienteID",
                table: "Ingredientes",
                column: "TipoIngredienteID");

            migrationBuilder.CreateIndex(
                name: "IX_Ingredientes_TipoMedidaID",
                table: "Ingredientes",
                column: "TipoMedidaID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ingredientes");

            migrationBuilder.DropTable(
                name: "TiposIngrediente");

            migrationBuilder.DropTable(
                name: "TiposMedida");
        }
    }
}
