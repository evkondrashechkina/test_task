using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Currencies",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Code = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Currencies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ExchangeRates",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    UnitsNumber = table.Column<int>(nullable: false),
                    Rate = table.Column<float>(nullable: false),
                    Date = table.Column<DateTime>(nullable: false),
                    CurrencyId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExchangeRates", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ExchangeRates_Currencies_CurrencyId",
                        column: x => x.CurrencyId,
                        principalTable: "Currencies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Currencies",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[] { new Guid("11bbbf0e-148a-45ca-b329-6c95864f1945"), "USD", "Доллар США" });

            migrationBuilder.InsertData(
                table: "Currencies",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[] { new Guid("2ca026ca-1fb4-42d1-81f1-d9b1f28fa5a7"), "CHF", "Швейцарский франк" });

            migrationBuilder.InsertData(
                table: "Currencies",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[] { new Guid("9993e5ac-983c-41ce-9f1b-256146728aee"), "SEK", "Шведская крона" });

            migrationBuilder.InsertData(
                table: "Currencies",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[] { new Guid("9a0fcaf6-fd89-45c5-80c7-69667ecfc072"), "CZK", "Чешская крона" });

            migrationBuilder.InsertData(
                table: "Currencies",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[] { new Guid("f0812695-d5a8-4bfb-91bf-85516f1c8812"), "GBP", "Фунт стерлингов Соединенного королевства" });

            migrationBuilder.InsertData(
                table: "Currencies",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[] { new Guid("7df2afa7-c1c9-48d4-8e3c-dfbc7e7352ad"), "UAH", "Украинская гривна" });

            migrationBuilder.InsertData(
                table: "Currencies",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[] { new Guid("53371f01-e292-4357-99b5-a67d6736aac5"), "UZS", "Узбекский сум" });

            migrationBuilder.InsertData(
                table: "Currencies",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[] { new Guid("3c3aabcf-f99d-4c5b-83a5-26ab411aec8e"), "TRY", "Турецкая лира" });

            migrationBuilder.InsertData(
                table: "Currencies",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[] { new Guid("0d0c13aa-21df-46a5-bf47-a1851c7f5edf"), "TJS", "Таджикский сомони" });

            migrationBuilder.InsertData(
                table: "Currencies",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[] { new Guid("821abd50-4fe7-489b-88ac-798db01056a4"), "SGD", "Сингапурский доллар" });

            migrationBuilder.InsertData(
                table: "Currencies",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[] { new Guid("ad43ed5e-95cb-4a02-9dfb-0023042a0fa3"), "PLN", "Польский злотый" });

            migrationBuilder.InsertData(
                table: "Currencies",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[] { new Guid("24ad525f-049c-4f4d-981e-d35bc1a34ad5"), "NOK", "Норвежская крона" });

            migrationBuilder.InsertData(
                table: "Currencies",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[] { new Guid("f5340578-affe-460e-a59a-cfbd87898a8e"), "TMT", "Новый туркменский манат" });

            migrationBuilder.InsertData(
                table: "Currencies",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[] { new Guid("ba68a7cb-b46f-44a5-9048-de67b458c783"), "RON", "Новый румынский лей" });

            migrationBuilder.InsertData(
                table: "Currencies",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[] { new Guid("81b49f97-1846-4b89-a0af-1b9174f9c6ff"), "MDL", "Молдавский лей" });

            migrationBuilder.InsertData(
                table: "Currencies",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[] { new Guid("9bd76064-5329-4e9f-9099-539771740eff"), "ZAR", "Южноафриканский рэнд" });

            migrationBuilder.InsertData(
                table: "Currencies",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[] { new Guid("3b4eaabf-996d-4e3d-b3dc-3c47dab4601c"), "CNY", "Китайский юань" });

            migrationBuilder.InsertData(
                table: "Currencies",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[] { new Guid("8082345e-6d29-4f64-8137-e0e3e3338f6e"), "CAD", "Канадский доллар" });

            migrationBuilder.InsertData(
                table: "Currencies",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[] { new Guid("75796b33-0cb2-465f-a2f9-b6b3174fdd6c"), "KZT", "Казахсканский тенге" });

            migrationBuilder.InsertData(
                table: "Currencies",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[] { new Guid("966fa871-b850-48d0-b35a-01ac50ab133d"), "INR", "Индийская рупия" });

            migrationBuilder.InsertData(
                table: "Currencies",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[] { new Guid("ead32013-ea79-4f7d-904f-74fe92e6a06d"), "DKK", "Датская крона" });

            migrationBuilder.InsertData(
                table: "Currencies",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[] { new Guid("77018082-91cf-4237-a9f1-b8ea8e12d005"), "HKD", "Гонконгский доллар" });

            migrationBuilder.InsertData(
                table: "Currencies",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[] { new Guid("0d02d2f7-9d33-4170-affc-e4f109ba77d3"), "KRW", "Вона Республики Корея" });

            migrationBuilder.InsertData(
                table: "Currencies",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[] { new Guid("565429b9-b082-43ae-a19f-962e9983a93d"), "HUF", "Венгерский форинт" });

            migrationBuilder.InsertData(
                table: "Currencies",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[] { new Guid("2401357a-e357-4d9b-8f58-6f0ef018df23"), "BRL", "Бразильский реал" });

            migrationBuilder.InsertData(
                table: "Currencies",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[] { new Guid("91dac2a6-21be-49cf-a420-6e9d34e0c283"), "BGN", "Болгарский лев" });

            migrationBuilder.InsertData(
                table: "Currencies",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[] { new Guid("f1b53bf2-c36b-403a-b96e-3f70b90a6dbd"), "BYN", "Белорусский рубль" });

            migrationBuilder.InsertData(
                table: "Currencies",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[] { new Guid("f0756449-1c50-40cc-ab55-b031e3ce9258"), "AMD", "Армянский драм" });

            migrationBuilder.InsertData(
                table: "Currencies",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[] { new Guid("119c0396-3fd0-418b-8ba0-2dda0cd98891"), "AZN", "Азебайджанский манат" });

            migrationBuilder.InsertData(
                table: "Currencies",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[] { new Guid("a5d82e53-8aad-4978-a487-99f9368008c7"), "AUD", "Австралийский доллар" });

            migrationBuilder.InsertData(
                table: "Currencies",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[] { new Guid("bf9242d7-1f47-462b-8609-02588ec24072"), "EUR", "Евро" });

            migrationBuilder.InsertData(
                table: "Currencies",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[] { new Guid("cb62c5e7-7d50-4095-989d-ec7bbddb103d"), "KGS", "Киргизский сом" });

            migrationBuilder.InsertData(
                table: "Currencies",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[] { new Guid("9e0e348d-167d-4a5d-b110-182f96ddc6f6"), "JPY", "Японская иена" });

            migrationBuilder.InsertData(
                table: "ExchangeRates",
                columns: new[] { "Id", "CurrencyId", "Date", "Rate", "UnitsNumber" },
                values: new object[] { new Guid("13e06473-0e00-48d9-b151-6de470646edd"), new Guid("11bbbf0e-148a-45ca-b329-6c95864f1945"), new DateTime(2020, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 77.0284f, 1 });

            migrationBuilder.InsertData(
                table: "ExchangeRates",
                columns: new[] { "Id", "CurrencyId", "Date", "Rate", "UnitsNumber" },
                values: new object[] { new Guid("575a52d3-1ca7-4338-8e1e-8d58ca9b4a8e"), new Guid("ad43ed5e-95cb-4a02-9dfb-0023042a0fa3"), new DateTime(2020, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 20.3134f, 1 });

            migrationBuilder.InsertData(
                table: "ExchangeRates",
                columns: new[] { "Id", "CurrencyId", "Date", "Rate", "UnitsNumber" },
                values: new object[] { new Guid("f7fe1fb5-6b91-4dcc-a5c5-199ce46eb4ac"), new Guid("ad43ed5e-95cb-4a02-9dfb-0023042a0fa3"), new DateTime(2020, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 20.3342f, 1 });

            migrationBuilder.InsertData(
                table: "ExchangeRates",
                columns: new[] { "Id", "CurrencyId", "Date", "Rate", "UnitsNumber" },
                values: new object[] { new Guid("ab96d22e-4761-4330-a823-289b64d3ebbb"), new Guid("ad43ed5e-95cb-4a02-9dfb-0023042a0fa3"), new DateTime(2020, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 20.3581f, 1 });

            migrationBuilder.InsertData(
                table: "ExchangeRates",
                columns: new[] { "Id", "CurrencyId", "Date", "Rate", "UnitsNumber" },
                values: new object[] { new Guid("8760d9ea-c157-47f2-a82a-ab7da6e601f2"), new Guid("ad43ed5e-95cb-4a02-9dfb-0023042a0fa3"), new DateTime(2020, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 20.2039f, 1 });

            migrationBuilder.InsertData(
                table: "ExchangeRates",
                columns: new[] { "Id", "CurrencyId", "Date", "Rate", "UnitsNumber" },
                values: new object[] { new Guid("0036cda9-6b2f-4782-b5c0-3881b2997ea8"), new Guid("ad43ed5e-95cb-4a02-9dfb-0023042a0fa3"), new DateTime(2020, 10, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 20.0778f, 1 });

            migrationBuilder.InsertData(
                table: "ExchangeRates",
                columns: new[] { "Id", "CurrencyId", "Date", "Rate", "UnitsNumber" },
                values: new object[] { new Guid("e012751f-4d80-4774-8d44-4ade94f33229"), new Guid("ad43ed5e-95cb-4a02-9dfb-0023042a0fa3"), new DateTime(2020, 10, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 20.0345f, 1 });

            migrationBuilder.InsertData(
                table: "ExchangeRates",
                columns: new[] { "Id", "CurrencyId", "Date", "Rate", "UnitsNumber" },
                values: new object[] { new Guid("cf83c9ab-8ecc-42d5-ba0c-404c7683c496"), new Guid("821abd50-4fe7-489b-88ac-798db01056a4"), new DateTime(2020, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 56.7972f, 1 });

            migrationBuilder.InsertData(
                table: "ExchangeRates",
                columns: new[] { "Id", "CurrencyId", "Date", "Rate", "UnitsNumber" },
                values: new object[] { new Guid("45282dca-4815-4a7a-b0da-bf2c5988b738"), new Guid("821abd50-4fe7-489b-88ac-798db01056a4"), new DateTime(2020, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 56.84f, 1 });

            migrationBuilder.InsertData(
                table: "ExchangeRates",
                columns: new[] { "Id", "CurrencyId", "Date", "Rate", "UnitsNumber" },
                values: new object[] { new Guid("89a42a5f-213e-46a0-9479-46ad6129278a"), new Guid("821abd50-4fe7-489b-88ac-798db01056a4"), new DateTime(2020, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 56.8987f, 1 });

            migrationBuilder.InsertData(
                table: "ExchangeRates",
                columns: new[] { "Id", "CurrencyId", "Date", "Rate", "UnitsNumber" },
                values: new object[] { new Guid("9819678c-f949-435d-b8f0-a9863563e354"), new Guid("24ad525f-049c-4f4d-981e-d35bc1a34ad5"), new DateTime(2020, 10, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 83.2846f, 10 });

            migrationBuilder.InsertData(
                table: "ExchangeRates",
                columns: new[] { "Id", "CurrencyId", "Date", "Rate", "UnitsNumber" },
                values: new object[] { new Guid("9dbc3f41-82fb-4699-8260-4492b52a6cac"), new Guid("821abd50-4fe7-489b-88ac-798db01056a4"), new DateTime(2020, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 56.9f, 1 });

            migrationBuilder.InsertData(
                table: "ExchangeRates",
                columns: new[] { "Id", "CurrencyId", "Date", "Rate", "UnitsNumber" },
                values: new object[] { new Guid("c8b0b3ef-ab16-4851-b99e-cec43d2460b3"), new Guid("821abd50-4fe7-489b-88ac-798db01056a4"), new DateTime(2020, 10, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 57.3943f, 1 });

            migrationBuilder.InsertData(
                table: "ExchangeRates",
                columns: new[] { "Id", "CurrencyId", "Date", "Rate", "UnitsNumber" },
                values: new object[] { new Guid("db4f6135-51f0-4597-aafe-2ece654104d2"), new Guid("0d0c13aa-21df-46a5-bf47-a1851c7f5edf"), new DateTime(2020, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 74.6399f, 10 });

            migrationBuilder.InsertData(
                table: "ExchangeRates",
                columns: new[] { "Id", "CurrencyId", "Date", "Rate", "UnitsNumber" },
                values: new object[] { new Guid("09863bf5-3dd9-4e05-9707-56a50679a67c"), new Guid("0d0c13aa-21df-46a5-bf47-a1851c7f5edf"), new DateTime(2020, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 74.6356f, 10 });

            migrationBuilder.InsertData(
                table: "ExchangeRates",
                columns: new[] { "Id", "CurrencyId", "Date", "Rate", "UnitsNumber" },
                values: new object[] { new Guid("72256744-d7e8-4f66-b06e-9161802584e3"), new Guid("0d0c13aa-21df-46a5-bf47-a1851c7f5edf"), new DateTime(2020, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 74.7804f, 10 });

            migrationBuilder.InsertData(
                table: "ExchangeRates",
                columns: new[] { "Id", "CurrencyId", "Date", "Rate", "UnitsNumber" },
                values: new object[] { new Guid("1b22bc7e-13e0-471c-8d86-d3922871b634"), new Guid("0d0c13aa-21df-46a5-bf47-a1851c7f5edf"), new DateTime(2020, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 74.7711f, 10 });

            migrationBuilder.InsertData(
                table: "ExchangeRates",
                columns: new[] { "Id", "CurrencyId", "Date", "Rate", "UnitsNumber" },
                values: new object[] { new Guid("09ef7b7d-c85e-44a2-9338-60c81680207e"), new Guid("0d0c13aa-21df-46a5-bf47-a1851c7f5edf"), new DateTime(2020, 10, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 75.4195f, 10 });

            migrationBuilder.InsertData(
                table: "ExchangeRates",
                columns: new[] { "Id", "CurrencyId", "Date", "Rate", "UnitsNumber" },
                values: new object[] { new Guid("4752e94e-14f7-4603-a22c-1fc025f3b6f1"), new Guid("0d0c13aa-21df-46a5-bf47-a1851c7f5edf"), new DateTime(2020, 10, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 75.4373f, 10 });

            migrationBuilder.InsertData(
                table: "ExchangeRates",
                columns: new[] { "Id", "CurrencyId", "Date", "Rate", "UnitsNumber" },
                values: new object[] { new Guid("afcf009e-4501-45f5-8d02-bbeaf9f3ec6b"), new Guid("3c3aabcf-f99d-4c5b-83a5-26ab411aec8e"), new DateTime(2020, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 97.1171f, 10 });

            migrationBuilder.InsertData(
                table: "ExchangeRates",
                columns: new[] { "Id", "CurrencyId", "Date", "Rate", "UnitsNumber" },
                values: new object[] { new Guid("486d265c-adb0-42ce-b0ea-4ee20ee535ec"), new Guid("3c3aabcf-f99d-4c5b-83a5-26ab411aec8e"), new DateTime(2020, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 97.6073f, 10 });

            migrationBuilder.InsertData(
                table: "ExchangeRates",
                columns: new[] { "Id", "CurrencyId", "Date", "Rate", "UnitsNumber" },
                values: new object[] { new Guid("03369b70-e0a6-464c-acd3-d9e5b0d58340"), new Guid("821abd50-4fe7-489b-88ac-798db01056a4"), new DateTime(2020, 10, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 57.326f, 1 });

            migrationBuilder.InsertData(
                table: "ExchangeRates",
                columns: new[] { "Id", "CurrencyId", "Date", "Rate", "UnitsNumber" },
                values: new object[] { new Guid("491cfe8e-d7e3-4129-8de1-06345bf5abc6"), new Guid("24ad525f-049c-4f4d-981e-d35bc1a34ad5"), new DateTime(2020, 10, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 83.3666f, 10 });

            migrationBuilder.InsertData(
                table: "ExchangeRates",
                columns: new[] { "Id", "CurrencyId", "Date", "Rate", "UnitsNumber" },
                values: new object[] { new Guid("2b01eafd-5940-4bd3-8f81-1ca32a5a7746"), new Guid("24ad525f-049c-4f4d-981e-d35bc1a34ad5"), new DateTime(2020, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 83.6944f, 10 });

            migrationBuilder.InsertData(
                table: "ExchangeRates",
                columns: new[] { "Id", "CurrencyId", "Date", "Rate", "UnitsNumber" },
                values: new object[] { new Guid("79c9adf0-13c4-431a-be2d-90017db1dac1"), new Guid("24ad525f-049c-4f4d-981e-d35bc1a34ad5"), new DateTime(2020, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 84.3452f, 10 });

            migrationBuilder.InsertData(
                table: "ExchangeRates",
                columns: new[] { "Id", "CurrencyId", "Date", "Rate", "UnitsNumber" },
                values: new object[] { new Guid("a52594c9-ff85-48a8-b9a7-f2e013370bec"), new Guid("3b4eaabf-996d-4e3d-b3dc-3c47dab4601c"), new DateTime(2020, 10, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 11.6398f, 1 });

            migrationBuilder.InsertData(
                table: "ExchangeRates",
                columns: new[] { "Id", "CurrencyId", "Date", "Rate", "UnitsNumber" },
                values: new object[] { new Guid("d0b94dde-2b07-4fed-9c58-75aa13f0ab67"), new Guid("81b49f97-1846-4b89-a0af-1b9174f9c6ff"), new DateTime(2020, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 45.4915f, 10 });

            migrationBuilder.InsertData(
                table: "ExchangeRates",
                columns: new[] { "Id", "CurrencyId", "Date", "Rate", "UnitsNumber" },
                values: new object[] { new Guid("9637b852-bfbe-4cfb-be43-c06ebd4b9d5f"), new Guid("81b49f97-1846-4b89-a0af-1b9174f9c6ff"), new DateTime(2020, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 45.4687f, 10 });

            migrationBuilder.InsertData(
                table: "ExchangeRates",
                columns: new[] { "Id", "CurrencyId", "Date", "Rate", "UnitsNumber" },
                values: new object[] { new Guid("1a1bb01e-207e-45d8-9fac-d8707e11f337"), new Guid("81b49f97-1846-4b89-a0af-1b9174f9c6ff"), new DateTime(2020, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 45.5962f, 10 });

            migrationBuilder.InsertData(
                table: "ExchangeRates",
                columns: new[] { "Id", "CurrencyId", "Date", "Rate", "UnitsNumber" },
                values: new object[] { new Guid("b0b01503-e522-41d7-891f-5982a0f9ce99"), new Guid("81b49f97-1846-4b89-a0af-1b9174f9c6ff"), new DateTime(2020, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 45.6444f, 10 });

            migrationBuilder.InsertData(
                table: "ExchangeRates",
                columns: new[] { "Id", "CurrencyId", "Date", "Rate", "UnitsNumber" },
                values: new object[] { new Guid("5fd76a42-6374-4feb-a202-f9637a8d760a"), new Guid("81b49f97-1846-4b89-a0af-1b9174f9c6ff"), new DateTime(2020, 10, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 45.9859f, 10 });

            migrationBuilder.InsertData(
                table: "ExchangeRates",
                columns: new[] { "Id", "CurrencyId", "Date", "Rate", "UnitsNumber" },
                values: new object[] { new Guid("e876fe0b-6b3e-44a7-8c47-f2091e3cf5f2"), new Guid("81b49f97-1846-4b89-a0af-1b9174f9c6ff"), new DateTime(2020, 10, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 45.8749f, 10 });

            migrationBuilder.InsertData(
                table: "ExchangeRates",
                columns: new[] { "Id", "CurrencyId", "Date", "Rate", "UnitsNumber" },
                values: new object[] { new Guid("0f958a0a-0d2e-42a7-bff4-23d06a1a066f"), new Guid("ba68a7cb-b46f-44a5-9048-de67b458c783"), new DateTime(2020, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 18.6442f, 1 });

            migrationBuilder.InsertData(
                table: "ExchangeRates",
                columns: new[] { "Id", "CurrencyId", "Date", "Rate", "UnitsNumber" },
                values: new object[] { new Guid("837ad3a3-4bd2-419b-abdb-709a5eca8571"), new Guid("ba68a7cb-b46f-44a5-9048-de67b458c783"), new DateTime(2020, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 18.672f, 1 });

            migrationBuilder.InsertData(
                table: "ExchangeRates",
                columns: new[] { "Id", "CurrencyId", "Date", "Rate", "UnitsNumber" },
                values: new object[] { new Guid("e08a8c91-926c-4081-a31f-af81a1e24b9a"), new Guid("ba68a7cb-b46f-44a5-9048-de67b458c783"), new DateTime(2020, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 18.6942f, 1 });

            migrationBuilder.InsertData(
                table: "ExchangeRates",
                columns: new[] { "Id", "CurrencyId", "Date", "Rate", "UnitsNumber" },
                values: new object[] { new Guid("5d7260aa-096a-4ab6-bd88-8c9ce6706d2b"), new Guid("ba68a7cb-b46f-44a5-9048-de67b458c783"), new DateTime(2020, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 18.6153f, 1 });

            migrationBuilder.InsertData(
                table: "ExchangeRates",
                columns: new[] { "Id", "CurrencyId", "Date", "Rate", "UnitsNumber" },
                values: new object[] { new Guid("da1524ed-80b9-4e41-831a-61f9c749bda2"), new Guid("ba68a7cb-b46f-44a5-9048-de67b458c783"), new DateTime(2020, 10, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 18.7267f, 1 });

            migrationBuilder.InsertData(
                table: "ExchangeRates",
                columns: new[] { "Id", "CurrencyId", "Date", "Rate", "UnitsNumber" },
                values: new object[] { new Guid("f2b9db5d-6040-4042-b0be-253e4e13fd18"), new Guid("ba68a7cb-b46f-44a5-9048-de67b458c783"), new DateTime(2020, 10, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 18.7302f, 1 });

            migrationBuilder.InsertData(
                table: "ExchangeRates",
                columns: new[] { "Id", "CurrencyId", "Date", "Rate", "UnitsNumber" },
                values: new object[] { new Guid("c553f1e4-4efd-49e3-83f4-d73c4d0b9750"), new Guid("f5340578-affe-460e-a59a-cfbd87898a8e"), new DateTime(2020, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 22.0396f, 1 });

            migrationBuilder.InsertData(
                table: "ExchangeRates",
                columns: new[] { "Id", "CurrencyId", "Date", "Rate", "UnitsNumber" },
                values: new object[] { new Guid("fd3f1b51-bbaf-44bc-a1d3-dd0ff7afe562"), new Guid("f5340578-affe-460e-a59a-cfbd87898a8e"), new DateTime(2020, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 22.0383f, 1 });

            migrationBuilder.InsertData(
                table: "ExchangeRates",
                columns: new[] { "Id", "CurrencyId", "Date", "Rate", "UnitsNumber" },
                values: new object[] { new Guid("8ec23d92-f90e-4d4d-99ae-d783ca2faf97"), new Guid("f5340578-affe-460e-a59a-cfbd87898a8e"), new DateTime(2020, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 22.1132f, 1 });

            migrationBuilder.InsertData(
                table: "ExchangeRates",
                columns: new[] { "Id", "CurrencyId", "Date", "Rate", "UnitsNumber" },
                values: new object[] { new Guid("561af24e-e546-4650-ba72-9f64be8cce85"), new Guid("f5340578-affe-460e-a59a-cfbd87898a8e"), new DateTime(2020, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 22.1104f, 1 });

            migrationBuilder.InsertData(
                table: "ExchangeRates",
                columns: new[] { "Id", "CurrencyId", "Date", "Rate", "UnitsNumber" },
                values: new object[] { new Guid("1eae62d1-21c3-4dfb-b74f-c5dc567804af"), new Guid("f5340578-affe-460e-a59a-cfbd87898a8e"), new DateTime(2020, 10, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 22.3022f, 1 });

            migrationBuilder.InsertData(
                table: "ExchangeRates",
                columns: new[] { "Id", "CurrencyId", "Date", "Rate", "UnitsNumber" },
                values: new object[] { new Guid("776ea683-bc75-428d-8fa2-0447dfd20977"), new Guid("f5340578-affe-460e-a59a-cfbd87898a8e"), new DateTime(2020, 10, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 22.3074f, 1 });

            migrationBuilder.InsertData(
                table: "ExchangeRates",
                columns: new[] { "Id", "CurrencyId", "Date", "Rate", "UnitsNumber" },
                values: new object[] { new Guid("8b276241-cd64-4978-a2a0-ad269f8145a5"), new Guid("24ad525f-049c-4f4d-981e-d35bc1a34ad5"), new DateTime(2020, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 83.3731f, 10 });

            migrationBuilder.InsertData(
                table: "ExchangeRates",
                columns: new[] { "Id", "CurrencyId", "Date", "Rate", "UnitsNumber" },
                values: new object[] { new Guid("27d4ba7b-61b7-40fc-b315-4fba87746535"), new Guid("24ad525f-049c-4f4d-981e-d35bc1a34ad5"), new DateTime(2020, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 84.3894f, 10 });

            migrationBuilder.InsertData(
                table: "ExchangeRates",
                columns: new[] { "Id", "CurrencyId", "Date", "Rate", "UnitsNumber" },
                values: new object[] { new Guid("51a71771-fa07-4579-a9d6-4a7f585c3bed"), new Guid("3c3aabcf-f99d-4c5b-83a5-26ab411aec8e"), new DateTime(2020, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 97.7258f, 10 });

            migrationBuilder.InsertData(
                table: "ExchangeRates",
                columns: new[] { "Id", "CurrencyId", "Date", "Rate", "UnitsNumber" },
                values: new object[] { new Guid("e9ca9282-2b73-4aed-869c-b1c81fca47c4"), new Guid("3c3aabcf-f99d-4c5b-83a5-26ab411aec8e"), new DateTime(2020, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 97.2305f, 10 });

            migrationBuilder.InsertData(
                table: "ExchangeRates",
                columns: new[] { "Id", "CurrencyId", "Date", "Rate", "UnitsNumber" },
                values: new object[] { new Guid("93b232cc-fd8d-4b4f-8445-d1d330b558ea"), new Guid("3c3aabcf-f99d-4c5b-83a5-26ab411aec8e"), new DateTime(2020, 10, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 98.2122f, 10 });

            migrationBuilder.InsertData(
                table: "ExchangeRates",
                columns: new[] { "Id", "CurrencyId", "Date", "Rate", "UnitsNumber" },
                values: new object[] { new Guid("9c35f0e1-0ded-4f92-b006-ca085d91fcca"), new Guid("3c3aabcf-f99d-4c5b-83a5-26ab411aec8e"), new DateTime(2020, 10, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 98.3468f, 10 });

            migrationBuilder.InsertData(
                table: "ExchangeRates",
                columns: new[] { "Id", "CurrencyId", "Date", "Rate", "UnitsNumber" },
                values: new object[] { new Guid("f984482c-9452-4ba4-a482-7879a5f7092d"), new Guid("9993e5ac-983c-41ce-9f1b-256146728aee"), new DateTime(2020, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 87.5909f, 10 });

            migrationBuilder.InsertData(
                table: "ExchangeRates",
                columns: new[] { "Id", "CurrencyId", "Date", "Rate", "UnitsNumber" },
                values: new object[] { new Guid("647580dc-d5b9-4e8c-9f1b-9b777ae14963"), new Guid("9993e5ac-983c-41ce-9f1b-256146728aee"), new DateTime(2020, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 87.8494f, 10 });

            migrationBuilder.InsertData(
                table: "ExchangeRates",
                columns: new[] { "Id", "CurrencyId", "Date", "Rate", "UnitsNumber" },
                values: new object[] { new Guid("cbd4027d-be66-46cb-b367-875f2f38e03e"), new Guid("9993e5ac-983c-41ce-9f1b-256146728aee"), new DateTime(2020, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 87.676f, 10 });

            migrationBuilder.InsertData(
                table: "ExchangeRates",
                columns: new[] { "Id", "CurrencyId", "Date", "Rate", "UnitsNumber" },
                values: new object[] { new Guid("1898c167-6512-45bc-8e2b-5f58de3bd3c0"), new Guid("9993e5ac-983c-41ce-9f1b-256146728aee"), new DateTime(2020, 10, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 87.8009f, 10 });

            migrationBuilder.InsertData(
                table: "ExchangeRates",
                columns: new[] { "Id", "CurrencyId", "Date", "Rate", "UnitsNumber" },
                values: new object[] { new Guid("edea4897-c6e7-4a15-923e-2de2352cbf31"), new Guid("9993e5ac-983c-41ce-9f1b-256146728aee"), new DateTime(2020, 10, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 88.1541f, 10 });

            migrationBuilder.InsertData(
                table: "ExchangeRates",
                columns: new[] { "Id", "CurrencyId", "Date", "Rate", "UnitsNumber" },
                values: new object[] { new Guid("03b86232-1904-4493-9db5-a5568c1dd16a"), new Guid("2ca026ca-1fb4-42d1-81f1-d9b1f28fa5a7"), new DateTime(2020, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 84.2854f, 1 });

            migrationBuilder.InsertData(
                table: "ExchangeRates",
                columns: new[] { "Id", "CurrencyId", "Date", "Rate", "UnitsNumber" },
                values: new object[] { new Guid("5886de02-b515-48e9-b3fc-0003a278d75b"), new Guid("2ca026ca-1fb4-42d1-81f1-d9b1f28fa5a7"), new DateTime(2020, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 84.5209f, 1 });

            migrationBuilder.InsertData(
                table: "ExchangeRates",
                columns: new[] { "Id", "CurrencyId", "Date", "Rate", "UnitsNumber" },
                values: new object[] { new Guid("979c7ee2-4e29-46fd-b0f5-124019530565"), new Guid("2ca026ca-1fb4-42d1-81f1-d9b1f28fa5a7"), new DateTime(2020, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 84.9105f, 1 });

            migrationBuilder.InsertData(
                table: "ExchangeRates",
                columns: new[] { "Id", "CurrencyId", "Date", "Rate", "UnitsNumber" },
                values: new object[] { new Guid("0da42dda-ba56-4fb8-bda6-9c1124f7f37a"), new Guid("2ca026ca-1fb4-42d1-81f1-d9b1f28fa5a7"), new DateTime(2020, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 84.5654f, 1 });

            migrationBuilder.InsertData(
                table: "ExchangeRates",
                columns: new[] { "Id", "CurrencyId", "Date", "Rate", "UnitsNumber" },
                values: new object[] { new Guid("7794fa44-7853-4166-8832-31d2e179443f"), new Guid("2ca026ca-1fb4-42d1-81f1-d9b1f28fa5a7"), new DateTime(2020, 10, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 85.2429f, 1 });

            migrationBuilder.InsertData(
                table: "ExchangeRates",
                columns: new[] { "Id", "CurrencyId", "Date", "Rate", "UnitsNumber" },
                values: new object[] { new Guid("1fb9b057-2ccb-46e4-9c94-b7006816345c"), new Guid("2ca026ca-1fb4-42d1-81f1-d9b1f28fa5a7"), new DateTime(2020, 10, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 85.2163f, 1 });

            migrationBuilder.InsertData(
                table: "ExchangeRates",
                columns: new[] { "Id", "CurrencyId", "Date", "Rate", "UnitsNumber" },
                values: new object[] { new Guid("0debf68d-f9e7-4952-b04c-4d1f390283d1"), new Guid("9bd76064-5329-4e9f-9099-539771740eff"), new DateTime(2020, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 46.7726f, 10 });

            migrationBuilder.InsertData(
                table: "ExchangeRates",
                columns: new[] { "Id", "CurrencyId", "Date", "Rate", "UnitsNumber" },
                values: new object[] { new Guid("d05e54bb-c064-480a-ac16-c1d2afd74ca5"), new Guid("9bd76064-5329-4e9f-9099-539771740eff"), new DateTime(2020, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 46.6806f, 10 });

            migrationBuilder.InsertData(
                table: "ExchangeRates",
                columns: new[] { "Id", "CurrencyId", "Date", "Rate", "UnitsNumber" },
                values: new object[] { new Guid("e96f21f2-8742-4ab6-8f8f-fed3ac34bacb"), new Guid("9bd76064-5329-4e9f-9099-539771740eff"), new DateTime(2020, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 46.7889f, 10 });

            migrationBuilder.InsertData(
                table: "ExchangeRates",
                columns: new[] { "Id", "CurrencyId", "Date", "Rate", "UnitsNumber" },
                values: new object[] { new Guid("84d539f6-d1f4-4a49-9df5-6c2df22ee9b0"), new Guid("9bd76064-5329-4e9f-9099-539771740eff"), new DateTime(2020, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 46.7905f, 10 });

            migrationBuilder.InsertData(
                table: "ExchangeRates",
                columns: new[] { "Id", "CurrencyId", "Date", "Rate", "UnitsNumber" },
                values: new object[] { new Guid("e332b0a5-823b-472d-b996-25c0da34f874"), new Guid("9bd76064-5329-4e9f-9099-539771740eff"), new DateTime(2020, 10, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 46.7822f, 10 });

            migrationBuilder.InsertData(
                table: "ExchangeRates",
                columns: new[] { "Id", "CurrencyId", "Date", "Rate", "UnitsNumber" },
                values: new object[] { new Guid("f1069d09-db3d-4bbd-8d49-f7d4d44d2ce4"), new Guid("9bd76064-5329-4e9f-9099-539771740eff"), new DateTime(2020, 10, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 47.0629f, 10 });

            migrationBuilder.InsertData(
                table: "ExchangeRates",
                columns: new[] { "Id", "CurrencyId", "Date", "Rate", "UnitsNumber" },
                values: new object[] { new Guid("1a26a601-b92e-4ac4-90e9-21f6463231fe"), new Guid("9e0e348d-167d-4a5d-b110-182f96ddc6f6"), new DateTime(2020, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 72.7575f, 100 });

            migrationBuilder.InsertData(
                table: "ExchangeRates",
                columns: new[] { "Id", "CurrencyId", "Date", "Rate", "UnitsNumber" },
                values: new object[] { new Guid("116f3345-49d3-4db8-921b-315cf6aa2ad2"), new Guid("9e0e348d-167d-4a5d-b110-182f96ddc6f6"), new DateTime(2020, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 72.9497f, 100 });

            migrationBuilder.InsertData(
                table: "ExchangeRates",
                columns: new[] { "Id", "CurrencyId", "Date", "Rate", "UnitsNumber" },
                values: new object[] { new Guid("b6c34c38-d197-4373-a21b-6606c1d8621e"), new Guid("9e0e348d-167d-4a5d-b110-182f96ddc6f6"), new DateTime(2020, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 73.2703f, 100 });

            migrationBuilder.InsertData(
                table: "ExchangeRates",
                columns: new[] { "Id", "CurrencyId", "Date", "Rate", "UnitsNumber" },
                values: new object[] { new Guid("a4df6d58-799e-438a-bd03-dddbbfd2e7f6"), new Guid("9e0e348d-167d-4a5d-b110-182f96ddc6f6"), new DateTime(2020, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 73.3133f, 100 });

            migrationBuilder.InsertData(
                table: "ExchangeRates",
                columns: new[] { "Id", "CurrencyId", "Date", "Rate", "UnitsNumber" },
                values: new object[] { new Guid("d84e2082-0ce4-4945-a8f0-0e4678028da2"), new Guid("9993e5ac-983c-41ce-9f1b-256146728aee"), new DateTime(2020, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 87.0338f, 10 });

            migrationBuilder.InsertData(
                table: "ExchangeRates",
                columns: new[] { "Id", "CurrencyId", "Date", "Rate", "UnitsNumber" },
                values: new object[] { new Guid("e7decbd5-d23f-4ff7-beac-47effd870ca3"), new Guid("3b4eaabf-996d-4e3d-b3dc-3c47dab4601c"), new DateTime(2020, 10, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 11.5803f, 1 });

            migrationBuilder.InsertData(
                table: "ExchangeRates",
                columns: new[] { "Id", "CurrencyId", "Date", "Rate", "UnitsNumber" },
                values: new object[] { new Guid("2dd7c62a-2d5b-46b4-8970-55255992adf7"), new Guid("9a0fcaf6-fd89-45c5-80c7-69667ecfc072"), new DateTime(2020, 10, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 33.4324f, 10 });

            migrationBuilder.InsertData(
                table: "ExchangeRates",
                columns: new[] { "Id", "CurrencyId", "Date", "Rate", "UnitsNumber" },
                values: new object[] { new Guid("659bbacb-75f9-43f5-a868-bfee5d87d34d"), new Guid("9a0fcaf6-fd89-45c5-80c7-69667ecfc072"), new DateTime(2020, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 33.1116f, 10 });

            migrationBuilder.InsertData(
                table: "ExchangeRates",
                columns: new[] { "Id", "CurrencyId", "Date", "Rate", "UnitsNumber" },
                values: new object[] { new Guid("47d98a8c-b789-47b6-ac22-21892dd6b0ae"), new Guid("53371f01-e292-4357-99b5-a67d6736aac5"), new DateTime(2020, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 74.4164f, 10000 });

            migrationBuilder.InsertData(
                table: "ExchangeRates",
                columns: new[] { "Id", "CurrencyId", "Date", "Rate", "UnitsNumber" },
                values: new object[] { new Guid("95d12f46-56cc-4fb3-afd3-fe7f80e1791c"), new Guid("53371f01-e292-4357-99b5-a67d6736aac5"), new DateTime(2020, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 74.412f, 10000 });

            migrationBuilder.InsertData(
                table: "ExchangeRates",
                columns: new[] { "Id", "CurrencyId", "Date", "Rate", "UnitsNumber" },
                values: new object[] { new Guid("691c467b-3851-4124-8c5f-5d0433c95f79"), new Guid("53371f01-e292-4357-99b5-a67d6736aac5"), new DateTime(2020, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 74.6648f, 10000 });

            migrationBuilder.InsertData(
                table: "ExchangeRates",
                columns: new[] { "Id", "CurrencyId", "Date", "Rate", "UnitsNumber" },
                values: new object[] { new Guid("efcb649c-80d8-48a1-b3dc-0c6d6ab205c6"), new Guid("53371f01-e292-4357-99b5-a67d6736aac5"), new DateTime(2020, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 74.6555f, 10000 });

            migrationBuilder.InsertData(
                table: "ExchangeRates",
                columns: new[] { "Id", "CurrencyId", "Date", "Rate", "UnitsNumber" },
                values: new object[] { new Guid("04d001b2-6f54-4207-80cf-4458b5469005"), new Guid("53371f01-e292-4357-99b5-a67d6736aac5"), new DateTime(2020, 10, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 75.303f, 10000 });

            migrationBuilder.InsertData(
                table: "ExchangeRates",
                columns: new[] { "Id", "CurrencyId", "Date", "Rate", "UnitsNumber" },
                values: new object[] { new Guid("7581c5e4-f3e7-4648-ba51-80ccd2461135"), new Guid("53371f01-e292-4357-99b5-a67d6736aac5"), new DateTime(2020, 10, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 75.3206f, 10000 });

            migrationBuilder.InsertData(
                table: "ExchangeRates",
                columns: new[] { "Id", "CurrencyId", "Date", "Rate", "UnitsNumber" },
                values: new object[] { new Guid("b23c5225-fde6-4a37-ad48-0dd8b3a6c239"), new Guid("7df2afa7-c1c9-48d4-8e3c-dfbc7e7352ad"), new DateTime(2020, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 27.3005f, 10 });

            migrationBuilder.InsertData(
                table: "ExchangeRates",
                columns: new[] { "Id", "CurrencyId", "Date", "Rate", "UnitsNumber" },
                values: new object[] { new Guid("e24bc51e-71c5-4769-81bc-d1cfdca62757"), new Guid("7df2afa7-c1c9-48d4-8e3c-dfbc7e7352ad"), new DateTime(2020, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 27.2741f, 10 });

            migrationBuilder.InsertData(
                table: "ExchangeRates",
                columns: new[] { "Id", "CurrencyId", "Date", "Rate", "UnitsNumber" },
                values: new object[] { new Guid("fd123d62-6bea-404b-aa62-2f6e6af865da"), new Guid("7df2afa7-c1c9-48d4-8e3c-dfbc7e7352ad"), new DateTime(2020, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 27.2902f, 10 });

            migrationBuilder.InsertData(
                table: "ExchangeRates",
                columns: new[] { "Id", "CurrencyId", "Date", "Rate", "UnitsNumber" },
                values: new object[] { new Guid("7a4672ea-553b-4983-916f-36c89c63c911"), new Guid("7df2afa7-c1c9-48d4-8e3c-dfbc7e7352ad"), new DateTime(2020, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 27.2674f, 10 });

            migrationBuilder.InsertData(
                table: "ExchangeRates",
                columns: new[] { "Id", "CurrencyId", "Date", "Rate", "UnitsNumber" },
                values: new object[] { new Guid("1871816c-86d7-4747-aa62-918630278c69"), new Guid("7df2afa7-c1c9-48d4-8e3c-dfbc7e7352ad"), new DateTime(2020, 10, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 27.5049f, 10 });

            migrationBuilder.InsertData(
                table: "ExchangeRates",
                columns: new[] { "Id", "CurrencyId", "Date", "Rate", "UnitsNumber" },
                values: new object[] { new Guid("b1914048-47df-423c-99b3-9f129075e5f2"), new Guid("7df2afa7-c1c9-48d4-8e3c-dfbc7e7352ad"), new DateTime(2020, 10, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 27.4958f, 10 });

            migrationBuilder.InsertData(
                table: "ExchangeRates",
                columns: new[] { "Id", "CurrencyId", "Date", "Rate", "UnitsNumber" },
                values: new object[] { new Guid("da825a90-42d6-434b-8bc3-eb61e4c03c82"), new Guid("f0812695-d5a8-4bfb-91bf-85516f1c8812"), new DateTime(2020, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 99.7056f, 1 });

            migrationBuilder.InsertData(
                table: "ExchangeRates",
                columns: new[] { "Id", "CurrencyId", "Date", "Rate", "UnitsNumber" },
                values: new object[] { new Guid("3cc6cd61-8bbb-4acd-a412-95a475ec99d5"), new Guid("f0812695-d5a8-4bfb-91bf-85516f1c8812"), new DateTime(2020, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 100.3621f, 1 });

            migrationBuilder.InsertData(
                table: "ExchangeRates",
                columns: new[] { "Id", "CurrencyId", "Date", "Rate", "UnitsNumber" },
                values: new object[] { new Guid("2fc662b9-1a2b-48cd-a491-d1a39a456527"), new Guid("f0812695-d5a8-4bfb-91bf-85516f1c8812"), new DateTime(2020, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 100.7416f, 1 });

            migrationBuilder.InsertData(
                table: "ExchangeRates",
                columns: new[] { "Id", "CurrencyId", "Date", "Rate", "UnitsNumber" },
                values: new object[] { new Guid("0b684191-0f82-4d76-be90-d5e671089410"), new Guid("f0812695-d5a8-4bfb-91bf-85516f1c8812"), new DateTime(2020, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 99.6859f, 1 });

            migrationBuilder.InsertData(
                table: "ExchangeRates",
                columns: new[] { "Id", "CurrencyId", "Date", "Rate", "UnitsNumber" },
                values: new object[] { new Guid("3c102c70-beea-474e-8d20-1363d6cf97ef"), new Guid("f0812695-d5a8-4bfb-91bf-85516f1c8812"), new DateTime(2020, 10, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 101.1584f, 1 });

            migrationBuilder.InsertData(
                table: "ExchangeRates",
                columns: new[] { "Id", "CurrencyId", "Date", "Rate", "UnitsNumber" },
                values: new object[] { new Guid("1967f7c1-9655-4bd0-a366-2e1742506d79"), new Guid("f0812695-d5a8-4bfb-91bf-85516f1c8812"), new DateTime(2020, 10, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 100.8625f, 1 });

            migrationBuilder.InsertData(
                table: "ExchangeRates",
                columns: new[] { "Id", "CurrencyId", "Date", "Rate", "UnitsNumber" },
                values: new object[] { new Guid("c70d4c1a-a435-49e3-ba89-dfbf511e8e6a"), new Guid("9a0fcaf6-fd89-45c5-80c7-69667ecfc072"), new DateTime(2020, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 33.4593f, 10 });

            migrationBuilder.InsertData(
                table: "ExchangeRates",
                columns: new[] { "Id", "CurrencyId", "Date", "Rate", "UnitsNumber" },
                values: new object[] { new Guid("a703cc8c-61bb-463e-adc3-8d45ea059af1"), new Guid("9a0fcaf6-fd89-45c5-80c7-69667ecfc072"), new DateTime(2020, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 33.588f, 10 });

            migrationBuilder.InsertData(
                table: "ExchangeRates",
                columns: new[] { "Id", "CurrencyId", "Date", "Rate", "UnitsNumber" },
                values: new object[] { new Guid("a976034b-f261-4c42-b87f-5babb91a7c23"), new Guid("9a0fcaf6-fd89-45c5-80c7-69667ecfc072"), new DateTime(2020, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 33.3185f, 10 });

            migrationBuilder.InsertData(
                table: "ExchangeRates",
                columns: new[] { "Id", "CurrencyId", "Date", "Rate", "UnitsNumber" },
                values: new object[] { new Guid("a6eaf0fe-0bab-4139-a953-25bbced8a783"), new Guid("9a0fcaf6-fd89-45c5-80c7-69667ecfc072"), new DateTime(2020, 10, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 33.4676f, 10 });

            migrationBuilder.InsertData(
                table: "ExchangeRates",
                columns: new[] { "Id", "CurrencyId", "Date", "Rate", "UnitsNumber" },
                values: new object[] { new Guid("8192bf2e-0e08-4540-a000-8a4a7b2e9612"), new Guid("3b4eaabf-996d-4e3d-b3dc-3c47dab4601c"), new DateTime(2020, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 11.4675f, 1 });

            migrationBuilder.InsertData(
                table: "ExchangeRates",
                columns: new[] { "Id", "CurrencyId", "Date", "Rate", "UnitsNumber" },
                values: new object[] { new Guid("a68b79ca-b15c-42ad-b692-d4c3b297e1ab"), new Guid("3b4eaabf-996d-4e3d-b3dc-3c47dab4601c"), new DateTime(2020, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 11.4672f, 1 });

            migrationBuilder.InsertData(
                table: "ExchangeRates",
                columns: new[] { "Id", "CurrencyId", "Date", "Rate", "UnitsNumber" },
                values: new object[] { new Guid("3941602c-ba00-4618-a27f-8eedc95f5997"), new Guid("3b4eaabf-996d-4e3d-b3dc-3c47dab4601c"), new DateTime(2020, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 11.4304f, 1 });

            migrationBuilder.InsertData(
                table: "ExchangeRates",
                columns: new[] { "Id", "CurrencyId", "Date", "Rate", "UnitsNumber" },
                values: new object[] { new Guid("d3417442-b152-47b0-95b7-ec434a0804e2"), new Guid("f0756449-1c50-40cc-ab55-b031e3ce9258"), new DateTime(2020, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 15.7597f, 100 });

            migrationBuilder.InsertData(
                table: "ExchangeRates",
                columns: new[] { "Id", "CurrencyId", "Date", "Rate", "UnitsNumber" },
                values: new object[] { new Guid("60a76d9e-5794-4e3a-837e-c23ce063585f"), new Guid("f0756449-1c50-40cc-ab55-b031e3ce9258"), new DateTime(2020, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 15.7545f, 100 });

            migrationBuilder.InsertData(
                table: "ExchangeRates",
                columns: new[] { "Id", "CurrencyId", "Date", "Rate", "UnitsNumber" },
                values: new object[] { new Guid("b7916e04-4742-43d8-bd00-b889ebedfc64"), new Guid("f0756449-1c50-40cc-ab55-b031e3ce9258"), new DateTime(2020, 10, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 15.864f, 100 });

            migrationBuilder.InsertData(
                table: "ExchangeRates",
                columns: new[] { "Id", "CurrencyId", "Date", "Rate", "UnitsNumber" },
                values: new object[] { new Guid("8032d901-bd3a-4378-ac82-58e99350a9f8"), new Guid("f0756449-1c50-40cc-ab55-b031e3ce9258"), new DateTime(2020, 10, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 15.8567f, 100 });

            migrationBuilder.InsertData(
                table: "ExchangeRates",
                columns: new[] { "Id", "CurrencyId", "Date", "Rate", "UnitsNumber" },
                values: new object[] { new Guid("a08f20b0-488f-4bcc-a320-da4c42dddaf4"), new Guid("f1b53bf2-c36b-403a-b96e-3f70b90a6dbd"), new DateTime(2020, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 29.6491f, 1 });

            migrationBuilder.InsertData(
                table: "ExchangeRates",
                columns: new[] { "Id", "CurrencyId", "Date", "Rate", "UnitsNumber" },
                values: new object[] { new Guid("0e9abf1a-51c2-41e5-964e-51fbd7ac9f10"), new Guid("f1b53bf2-c36b-403a-b96e-3f70b90a6dbd"), new DateTime(2020, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 29.9961f, 1 });

            migrationBuilder.InsertData(
                table: "ExchangeRates",
                columns: new[] { "Id", "CurrencyId", "Date", "Rate", "UnitsNumber" },
                values: new object[] { new Guid("e3203f08-1a6c-4acb-91af-4658271ec930"), new Guid("f1b53bf2-c36b-403a-b96e-3f70b90a6dbd"), new DateTime(2020, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 30.0815f, 1 });

            migrationBuilder.InsertData(
                table: "ExchangeRates",
                columns: new[] { "Id", "CurrencyId", "Date", "Rate", "UnitsNumber" },
                values: new object[] { new Guid("76b903a6-fcc6-46ed-80df-c10708d0fed9"), new Guid("f1b53bf2-c36b-403a-b96e-3f70b90a6dbd"), new DateTime(2020, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 30.0439f, 1 });

            migrationBuilder.InsertData(
                table: "ExchangeRates",
                columns: new[] { "Id", "CurrencyId", "Date", "Rate", "UnitsNumber" },
                values: new object[] { new Guid("18cd19b7-f456-4f05-af3c-a6014d3e31e8"), new Guid("f1b53bf2-c36b-403a-b96e-3f70b90a6dbd"), new DateTime(2020, 10, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 30.2833f, 1 });

            migrationBuilder.InsertData(
                table: "ExchangeRates",
                columns: new[] { "Id", "CurrencyId", "Date", "Rate", "UnitsNumber" },
                values: new object[] { new Guid("4e8370e5-6d94-4c36-b1e2-1d03c6f4ed40"), new Guid("f1b53bf2-c36b-403a-b96e-3f70b90a6dbd"), new DateTime(2020, 10, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 30.3234f, 1 });

            migrationBuilder.InsertData(
                table: "ExchangeRates",
                columns: new[] { "Id", "CurrencyId", "Date", "Rate", "UnitsNumber" },
                values: new object[] { new Guid("9c90432d-9f04-40ff-a1b3-96d0df8823fa"), new Guid("91dac2a6-21be-49cf-a420-6e9d34e0c283"), new DateTime(2020, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 46.4418f, 1 });

            migrationBuilder.InsertData(
                table: "ExchangeRates",
                columns: new[] { "Id", "CurrencyId", "Date", "Rate", "UnitsNumber" },
                values: new object[] { new Guid("f654eef8-f3ee-4ac1-a24d-e7d0d4731d70"), new Guid("91dac2a6-21be-49cf-a420-6e9d34e0c283"), new DateTime(2020, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 46.5148f, 1 });

            migrationBuilder.InsertData(
                table: "ExchangeRates",
                columns: new[] { "Id", "CurrencyId", "Date", "Rate", "UnitsNumber" },
                values: new object[] { new Guid("3fd59dba-20e7-4251-83ec-9c3390fbc91b"), new Guid("91dac2a6-21be-49cf-a420-6e9d34e0c283"), new DateTime(2020, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 46.5856f, 1 });

            migrationBuilder.InsertData(
                table: "ExchangeRates",
                columns: new[] { "Id", "CurrencyId", "Date", "Rate", "UnitsNumber" },
                values: new object[] { new Guid("62c49935-cde6-4cd4-9b4a-dd26a450c302"), new Guid("91dac2a6-21be-49cf-a420-6e9d34e0c283"), new DateTime(2020, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 46.4036f, 1 });

            migrationBuilder.InsertData(
                table: "ExchangeRates",
                columns: new[] { "Id", "CurrencyId", "Date", "Rate", "UnitsNumber" },
                values: new object[] { new Guid("cd9db85f-de41-4f90-8c18-3f682abd44e2"), new Guid("91dac2a6-21be-49cf-a420-6e9d34e0c283"), new DateTime(2020, 10, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 46.6939f, 1 });

            migrationBuilder.InsertData(
                table: "ExchangeRates",
                columns: new[] { "Id", "CurrencyId", "Date", "Rate", "UnitsNumber" },
                values: new object[] { new Guid("2f485e6e-6c4d-4e6f-8977-1699409f46fb"), new Guid("91dac2a6-21be-49cf-a420-6e9d34e0c283"), new DateTime(2020, 10, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 46.6965f, 1 });

            migrationBuilder.InsertData(
                table: "ExchangeRates",
                columns: new[] { "Id", "CurrencyId", "Date", "Rate", "UnitsNumber" },
                values: new object[] { new Guid("1bcb88a5-dcaf-477f-9ecf-d5db7339a6ce"), new Guid("2401357a-e357-4d9b-8f58-6f0ef018df23"), new DateTime(2020, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 13.7551f, 1 });

            migrationBuilder.InsertData(
                table: "ExchangeRates",
                columns: new[] { "Id", "CurrencyId", "Date", "Rate", "UnitsNumber" },
                values: new object[] { new Guid("e2c31f4a-6723-4e9c-8fd3-32f6b41cd500"), new Guid("2401357a-e357-4d9b-8f58-6f0ef018df23"), new DateTime(2020, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 13.9241f, 1 });

            migrationBuilder.InsertData(
                table: "ExchangeRates",
                columns: new[] { "Id", "CurrencyId", "Date", "Rate", "UnitsNumber" },
                values: new object[] { new Guid("b604cca6-28f9-401d-a608-6aa775ffb56c"), new Guid("2401357a-e357-4d9b-8f58-6f0ef018df23"), new DateTime(2020, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 13.9714f, 1 });

            migrationBuilder.InsertData(
                table: "ExchangeRates",
                columns: new[] { "Id", "CurrencyId", "Date", "Rate", "UnitsNumber" },
                values: new object[] { new Guid("755eeef9-db72-43af-9057-25a337c2b071"), new Guid("2401357a-e357-4d9b-8f58-6f0ef018df23"), new DateTime(2020, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 13.8733f, 1 });

            migrationBuilder.InsertData(
                table: "ExchangeRates",
                columns: new[] { "Id", "CurrencyId", "Date", "Rate", "UnitsNumber" },
                values: new object[] { new Guid("b55cfe42-2881-4c9f-b540-eab27bca5d81"), new Guid("2401357a-e357-4d9b-8f58-6f0ef018df23"), new DateTime(2020, 10, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 13.9384f, 1 });

            migrationBuilder.InsertData(
                table: "ExchangeRates",
                columns: new[] { "Id", "CurrencyId", "Date", "Rate", "UnitsNumber" },
                values: new object[] { new Guid("b256afd7-831e-48df-93a6-a149962a663c"), new Guid("f0756449-1c50-40cc-ab55-b031e3ce9258"), new DateTime(2020, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 15.6887f, 100 });

            migrationBuilder.InsertData(
                table: "ExchangeRates",
                columns: new[] { "Id", "CurrencyId", "Date", "Rate", "UnitsNumber" },
                values: new object[] { new Guid("5516ddf0-9e4f-4178-ab3c-6d1929245a72"), new Guid("2401357a-e357-4d9b-8f58-6f0ef018df23"), new DateTime(2020, 10, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 13.8912f, 1 });

            migrationBuilder.InsertData(
                table: "ExchangeRates",
                columns: new[] { "Id", "CurrencyId", "Date", "Rate", "UnitsNumber" },
                values: new object[] { new Guid("02823689-fab9-4f08-a984-48d7daa72e6e"), new Guid("f0756449-1c50-40cc-ab55-b031e3ce9258"), new DateTime(2020, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 15.7073f, 100 });

            migrationBuilder.InsertData(
                table: "ExchangeRates",
                columns: new[] { "Id", "CurrencyId", "Date", "Rate", "UnitsNumber" },
                values: new object[] { new Guid("e88a43ec-ceb6-48c8-972f-5cea4972d521"), new Guid("119c0396-3fd0-418b-8ba0-2dda0cd98891"), new DateTime(2020, 10, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 45.8776f, 1 });

            migrationBuilder.InsertData(
                table: "ExchangeRates",
                columns: new[] { "Id", "CurrencyId", "Date", "Rate", "UnitsNumber" },
                values: new object[] { new Guid("c1ec5e43-008c-4242-a09a-becd23ea7945"), new Guid("11bbbf0e-148a-45ca-b329-6c95864f1945"), new DateTime(2020, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 77.0239f, 1 });

            migrationBuilder.InsertData(
                table: "ExchangeRates",
                columns: new[] { "Id", "CurrencyId", "Date", "Rate", "UnitsNumber" },
                values: new object[] { new Guid("82ffdf35-1d07-4d78-9402-283151ad6731"), new Guid("11bbbf0e-148a-45ca-b329-6c95864f1945"), new DateTime(2020, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 77.2855f, 1 });

            migrationBuilder.InsertData(
                table: "ExchangeRates",
                columns: new[] { "Id", "CurrencyId", "Date", "Rate", "UnitsNumber" },
                values: new object[] { new Guid("17bd5f15-d1c4-4e7e-bc3a-16722345fbc6"), new Guid("11bbbf0e-148a-45ca-b329-6c95864f1945"), new DateTime(2020, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 77.2759f, 1 });

            migrationBuilder.InsertData(
                table: "ExchangeRates",
                columns: new[] { "Id", "CurrencyId", "Date", "Rate", "UnitsNumber" },
                values: new object[] { new Guid("67e68f32-84c8-49c4-8faa-648ec30027e6"), new Guid("11bbbf0e-148a-45ca-b329-6c95864f1945"), new DateTime(2020, 10, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 77.9461f, 1 });

            migrationBuilder.InsertData(
                table: "ExchangeRates",
                columns: new[] { "Id", "CurrencyId", "Date", "Rate", "UnitsNumber" },
                values: new object[] { new Guid("66bba7da-df30-438c-b0e9-db961de29f8a"), new Guid("11bbbf0e-148a-45ca-b329-6c95864f1945"), new DateTime(2020, 10, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 77.9644f, 1 });

            migrationBuilder.InsertData(
                table: "ExchangeRates",
                columns: new[] { "Id", "CurrencyId", "Date", "Rate", "UnitsNumber" },
                values: new object[] { new Guid("869a7fc3-23a9-42a4-b989-37233340667c"), new Guid("bf9242d7-1f47-462b-8609-02588ec24072"), new DateTime(2020, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 90.7163f, 1 });

            migrationBuilder.InsertData(
                table: "ExchangeRates",
                columns: new[] { "Id", "CurrencyId", "Date", "Rate", "UnitsNumber" },
                values: new object[] { new Guid("f68ffa63-6fdb-4152-8aef-29334e84d1d1"), new Guid("bf9242d7-1f47-462b-8609-02588ec24072"), new DateTime(2020, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 91.0037f, 1 });

            migrationBuilder.InsertData(
                table: "ExchangeRates",
                columns: new[] { "Id", "CurrencyId", "Date", "Rate", "UnitsNumber" },
                values: new object[] { new Guid("f4bb4e0d-24e7-4633-bf96-08683d7cf93a"), new Guid("bf9242d7-1f47-462b-8609-02588ec24072"), new DateTime(2020, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 91.0732f, 1 });

            migrationBuilder.InsertData(
                table: "ExchangeRates",
                columns: new[] { "Id", "CurrencyId", "Date", "Rate", "UnitsNumber" },
                values: new object[] { new Guid("d06af19d-414a-47e9-9c99-96a6b2ca082c"), new Guid("bf9242d7-1f47-462b-8609-02588ec24072"), new DateTime(2020, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 90.7065f, 1 });

            migrationBuilder.InsertData(
                table: "ExchangeRates",
                columns: new[] { "Id", "CurrencyId", "Date", "Rate", "UnitsNumber" },
                values: new object[] { new Guid("aac865f1-0f01-4281-a309-6a686d5864fd"), new Guid("bf9242d7-1f47-462b-8609-02588ec24072"), new DateTime(2020, 10, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 91.4542f, 1 });

            migrationBuilder.InsertData(
                table: "ExchangeRates",
                columns: new[] { "Id", "CurrencyId", "Date", "Rate", "UnitsNumber" },
                values: new object[] { new Guid("192f34f9-969e-4fd9-bdd5-3f992d144341"), new Guid("bf9242d7-1f47-462b-8609-02588ec24072"), new DateTime(2020, 10, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 91.3041f, 1 });

            migrationBuilder.InsertData(
                table: "ExchangeRates",
                columns: new[] { "Id", "CurrencyId", "Date", "Rate", "UnitsNumber" },
                values: new object[] { new Guid("0243770c-8057-4530-9f2a-e2d0439ee012"), new Guid("a5d82e53-8aad-4978-a487-99f9368008c7"), new DateTime(2020, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 55.3603f, 1 });

            migrationBuilder.InsertData(
                table: "ExchangeRates",
                columns: new[] { "Id", "CurrencyId", "Date", "Rate", "UnitsNumber" },
                values: new object[] { new Guid("f222ef39-fcaa-4d91-96b5-e2346bfab610"), new Guid("a5d82e53-8aad-4978-a487-99f9368008c7"), new DateTime(2020, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 55.6806f, 1 });

            migrationBuilder.InsertData(
                table: "ExchangeRates",
                columns: new[] { "Id", "CurrencyId", "Date", "Rate", "UnitsNumber" },
                values: new object[] { new Guid("b82e96b3-7ce6-477c-8b4a-f1797688a5ec"), new Guid("a5d82e53-8aad-4978-a487-99f9368008c7"), new DateTime(2020, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 55.5837f, 1 });

            migrationBuilder.InsertData(
                table: "ExchangeRates",
                columns: new[] { "Id", "CurrencyId", "Date", "Rate", "UnitsNumber" },
                values: new object[] { new Guid("c8a64de0-c959-4910-9904-66d0515427d9"), new Guid("a5d82e53-8aad-4978-a487-99f9368008c7"), new DateTime(2020, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 55.4609f, 1 });

            migrationBuilder.InsertData(
                table: "ExchangeRates",
                columns: new[] { "Id", "CurrencyId", "Date", "Rate", "UnitsNumber" },
                values: new object[] { new Guid("36cc37cd-f425-43b4-bb92-2982c1e5c84a"), new Guid("a5d82e53-8aad-4978-a487-99f9368008c7"), new DateTime(2020, 10, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 55.2248f, 1 });

            migrationBuilder.InsertData(
                table: "ExchangeRates",
                columns: new[] { "Id", "CurrencyId", "Date", "Rate", "UnitsNumber" },
                values: new object[] { new Guid("369eff7a-dd2f-4698-9f67-3e98342e930a"), new Guid("a5d82e53-8aad-4978-a487-99f9368008c7"), new DateTime(2020, 10, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 55.2534f, 1 });

            migrationBuilder.InsertData(
                table: "ExchangeRates",
                columns: new[] { "Id", "CurrencyId", "Date", "Rate", "UnitsNumber" },
                values: new object[] { new Guid("03692b9b-1675-4cc6-b87a-0c4856dfcb90"), new Guid("119c0396-3fd0-418b-8ba0-2dda0cd98891"), new DateTime(2020, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 45.3375f, 1 });

            migrationBuilder.InsertData(
                table: "ExchangeRates",
                columns: new[] { "Id", "CurrencyId", "Date", "Rate", "UnitsNumber" },
                values: new object[] { new Guid("94870102-05f0-4b44-8c6a-0f24450c462f"), new Guid("119c0396-3fd0-418b-8ba0-2dda0cd98891"), new DateTime(2020, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 45.3348f, 1 });

            migrationBuilder.InsertData(
                table: "ExchangeRates",
                columns: new[] { "Id", "CurrencyId", "Date", "Rate", "UnitsNumber" },
                values: new object[] { new Guid("05930cf4-2847-41aa-bd3d-711463ef0573"), new Guid("119c0396-3fd0-418b-8ba0-2dda0cd98891"), new DateTime(2020, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 45.4888f, 1 });

            migrationBuilder.InsertData(
                table: "ExchangeRates",
                columns: new[] { "Id", "CurrencyId", "Date", "Rate", "UnitsNumber" },
                values: new object[] { new Guid("144731c5-25cb-4cfb-bde3-e4ce9428f8db"), new Guid("119c0396-3fd0-418b-8ba0-2dda0cd98891"), new DateTime(2020, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 45.4832f, 1 });

            migrationBuilder.InsertData(
                table: "ExchangeRates",
                columns: new[] { "Id", "CurrencyId", "Date", "Rate", "UnitsNumber" },
                values: new object[] { new Guid("4fa58cb4-0771-4ba7-8e28-7bcff1bf34ab"), new Guid("119c0396-3fd0-418b-8ba0-2dda0cd98891"), new DateTime(2020, 10, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 45.8884f, 1 });

            migrationBuilder.InsertData(
                table: "ExchangeRates",
                columns: new[] { "Id", "CurrencyId", "Date", "Rate", "UnitsNumber" },
                values: new object[] { new Guid("0051e5b9-e39f-44e4-838e-fccdde4a15e2"), new Guid("9e0e348d-167d-4a5d-b110-182f96ddc6f6"), new DateTime(2020, 10, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 74.0616f, 100 });

            migrationBuilder.InsertData(
                table: "ExchangeRates",
                columns: new[] { "Id", "CurrencyId", "Date", "Rate", "UnitsNumber" },
                values: new object[] { new Guid("f1b301e8-a812-4870-b667-130569d4a2a0"), new Guid("565429b9-b082-43ae-a19f-962e9983a93d"), new DateTime(2020, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 25.4656f, 100 });

            migrationBuilder.InsertData(
                table: "ExchangeRates",
                columns: new[] { "Id", "CurrencyId", "Date", "Rate", "UnitsNumber" },
                values: new object[] { new Guid("395a8788-ff8a-4a23-a274-38d4f5b02964"), new Guid("565429b9-b082-43ae-a19f-962e9983a93d"), new DateTime(2020, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 25.3945f, 100 });

            migrationBuilder.InsertData(
                table: "ExchangeRates",
                columns: new[] { "Id", "CurrencyId", "Date", "Rate", "UnitsNumber" },
                values: new object[] { new Guid("15f95a1b-dd55-466f-9445-c83626346651"), new Guid("966fa871-b850-48d0-b35a-01ac50ab133d"), new DateTime(2020, 10, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 10.6223f, 10 });

            migrationBuilder.InsertData(
                table: "ExchangeRates",
                columns: new[] { "Id", "CurrencyId", "Date", "Rate", "UnitsNumber" },
                values: new object[] { new Guid("3e0615aa-6d37-41c4-b950-858031a878ef"), new Guid("966fa871-b850-48d0-b35a-01ac50ab133d"), new DateTime(2020, 10, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 10.6291f, 10 });

            migrationBuilder.InsertData(
                table: "ExchangeRates",
                columns: new[] { "Id", "CurrencyId", "Date", "Rate", "UnitsNumber" },
                values: new object[] { new Guid("67564b10-07c5-44b3-8a6c-e1d1970059db"), new Guid("75796b33-0cb2-465f-a2f9-b6b3174fdd6c"), new DateTime(2020, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 18.0209f, 100 });

            migrationBuilder.InsertData(
                table: "ExchangeRates",
                columns: new[] { "Id", "CurrencyId", "Date", "Rate", "UnitsNumber" },
                values: new object[] { new Guid("ef688641-bacb-4341-baa4-ab3a3f102715"), new Guid("75796b33-0cb2-465f-a2f9-b6b3174fdd6c"), new DateTime(2020, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 17.9946f, 100 });

            migrationBuilder.InsertData(
                table: "ExchangeRates",
                columns: new[] { "Id", "CurrencyId", "Date", "Rate", "UnitsNumber" },
                values: new object[] { new Guid("f74780eb-5004-4846-abe4-2f9c01cf3703"), new Guid("75796b33-0cb2-465f-a2f9-b6b3174fdd6c"), new DateTime(2020, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 18.0052f, 100 });

            migrationBuilder.InsertData(
                table: "ExchangeRates",
                columns: new[] { "Id", "CurrencyId", "Date", "Rate", "UnitsNumber" },
                values: new object[] { new Guid("d3019cc7-c382-4562-948f-c24ad20ce2a3"), new Guid("75796b33-0cb2-465f-a2f9-b6b3174fdd6c"), new DateTime(2020, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 17.9988f, 100 });

            migrationBuilder.InsertData(
                table: "ExchangeRates",
                columns: new[] { "Id", "CurrencyId", "Date", "Rate", "UnitsNumber" },
                values: new object[] { new Guid("5ccbd855-ce37-4432-a1e9-84e7cac59c68"), new Guid("75796b33-0cb2-465f-a2f9-b6b3174fdd6c"), new DateTime(2020, 10, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 18.1824f, 100 });

            migrationBuilder.InsertData(
                table: "ExchangeRates",
                columns: new[] { "Id", "CurrencyId", "Date", "Rate", "UnitsNumber" },
                values: new object[] { new Guid("ee8b73bf-02a1-4180-8c49-c5181d4fa79d"), new Guid("75796b33-0cb2-465f-a2f9-b6b3174fdd6c"), new DateTime(2020, 10, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 18.1697f, 100 });

            migrationBuilder.InsertData(
                table: "ExchangeRates",
                columns: new[] { "Id", "CurrencyId", "Date", "Rate", "UnitsNumber" },
                values: new object[] { new Guid("38fc40ce-f76e-4d7e-b5a7-8ef47af70b65"), new Guid("8082345e-6d29-4f64-8137-e0e3e3338f6e"), new DateTime(2020, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 58.4967f, 1 });

            migrationBuilder.InsertData(
                table: "ExchangeRates",
                columns: new[] { "Id", "CurrencyId", "Date", "Rate", "UnitsNumber" },
                values: new object[] { new Guid("2e509334-fa7d-4893-b509-ce1f1191bc0e"), new Guid("8082345e-6d29-4f64-8137-e0e3e3338f6e"), new DateTime(2020, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 58.6759f, 1 });

            migrationBuilder.InsertData(
                table: "ExchangeRates",
                columns: new[] { "Id", "CurrencyId", "Date", "Rate", "UnitsNumber" },
                values: new object[] { new Guid("045a182f-1b11-4889-9c1a-6de60a36d88e"), new Guid("8082345e-6d29-4f64-8137-e0e3e3338f6e"), new DateTime(2020, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 58.9156f, 1 });

            migrationBuilder.InsertData(
                table: "ExchangeRates",
                columns: new[] { "Id", "CurrencyId", "Date", "Rate", "UnitsNumber" },
                values: new object[] { new Guid("e4ec08d9-2ecb-423f-b787-9548925a0bc1"), new Guid("8082345e-6d29-4f64-8137-e0e3e3338f6e"), new DateTime(2020, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 58.8679f, 1 });

            migrationBuilder.InsertData(
                table: "ExchangeRates",
                columns: new[] { "Id", "CurrencyId", "Date", "Rate", "UnitsNumber" },
                values: new object[] { new Guid("829d02a5-ddc5-4cd0-934e-d2ede400b5e3"), new Guid("8082345e-6d29-4f64-8137-e0e3e3338f6e"), new DateTime(2020, 10, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 59.1576f, 1 });

            migrationBuilder.InsertData(
                table: "ExchangeRates",
                columns: new[] { "Id", "CurrencyId", "Date", "Rate", "UnitsNumber" },
                values: new object[] { new Guid("0c304841-1ad4-4986-af94-280254710feb"), new Guid("8082345e-6d29-4f64-8137-e0e3e3338f6e"), new DateTime(2020, 10, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 59.0237f, 1 });

            migrationBuilder.InsertData(
                table: "ExchangeRates",
                columns: new[] { "Id", "CurrencyId", "Date", "Rate", "UnitsNumber" },
                values: new object[] { new Guid("4c965d9a-4df7-4082-b151-42d4a52841f2"), new Guid("cb62c5e7-7d50-4095-989d-ec7bbddb103d"), new DateTime(2020, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 96.716f, 100 });

            migrationBuilder.InsertData(
                table: "ExchangeRates",
                columns: new[] { "Id", "CurrencyId", "Date", "Rate", "UnitsNumber" },
                values: new object[] { new Guid("ce2cb3df-bb32-477b-9b79-b42379784d71"), new Guid("cb62c5e7-7d50-4095-989d-ec7bbddb103d"), new DateTime(2020, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 96.7104f, 100 });

            migrationBuilder.InsertData(
                table: "ExchangeRates",
                columns: new[] { "Id", "CurrencyId", "Date", "Rate", "UnitsNumber" },
                values: new object[] { new Guid("c76bf645-219e-4092-8d81-2ce8d8890851"), new Guid("cb62c5e7-7d50-4095-989d-ec7bbddb103d"), new DateTime(2020, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 97.0388f, 100 });

            migrationBuilder.InsertData(
                table: "ExchangeRates",
                columns: new[] { "Id", "CurrencyId", "Date", "Rate", "UnitsNumber" },
                values: new object[] { new Guid("b95c0267-4401-4d74-9438-1e7e5937f634"), new Guid("cb62c5e7-7d50-4095-989d-ec7bbddb103d"), new DateTime(2020, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 96.9766f, 100 });

            migrationBuilder.InsertData(
                table: "ExchangeRates",
                columns: new[] { "Id", "CurrencyId", "Date", "Rate", "UnitsNumber" },
                values: new object[] { new Guid("139e3230-f20b-43ee-8579-96c863bd2216"), new Guid("cb62c5e7-7d50-4095-989d-ec7bbddb103d"), new DateTime(2020, 10, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 97.7889f, 100 });

            migrationBuilder.InsertData(
                table: "ExchangeRates",
                columns: new[] { "Id", "CurrencyId", "Date", "Rate", "UnitsNumber" },
                values: new object[] { new Guid("a77fe535-ed35-466a-9ce2-1d899cf5bd2b"), new Guid("cb62c5e7-7d50-4095-989d-ec7bbddb103d"), new DateTime(2020, 10, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 97.4555f, 100 });

            migrationBuilder.InsertData(
                table: "ExchangeRates",
                columns: new[] { "Id", "CurrencyId", "Date", "Rate", "UnitsNumber" },
                values: new object[] { new Guid("10262a80-d1ef-4b31-bd7a-9473f49ecf39"), new Guid("3b4eaabf-996d-4e3d-b3dc-3c47dab4601c"), new DateTime(2020, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 11.4728f, 1 });

            migrationBuilder.InsertData(
                table: "ExchangeRates",
                columns: new[] { "Id", "CurrencyId", "Date", "Rate", "UnitsNumber" },
                values: new object[] { new Guid("f8fe49c4-ae2e-4217-bc8b-798e6eef4759"), new Guid("966fa871-b850-48d0-b35a-01ac50ab133d"), new DateTime(2020, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 10.5462f, 10 });

            migrationBuilder.InsertData(
                table: "ExchangeRates",
                columns: new[] { "Id", "CurrencyId", "Date", "Rate", "UnitsNumber" },
                values: new object[] { new Guid("7a51fbe8-7915-46a2-a487-5d472b7392e1"), new Guid("565429b9-b082-43ae-a19f-962e9983a93d"), new DateTime(2020, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 25.5477f, 100 });

            migrationBuilder.InsertData(
                table: "ExchangeRates",
                columns: new[] { "Id", "CurrencyId", "Date", "Rate", "UnitsNumber" },
                values: new object[] { new Guid("bc766e29-974b-4500-aea5-87f05e521ae5"), new Guid("966fa871-b850-48d0-b35a-01ac50ab133d"), new DateTime(2020, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 10.5398f, 10 });

            migrationBuilder.InsertData(
                table: "ExchangeRates",
                columns: new[] { "Id", "CurrencyId", "Date", "Rate", "UnitsNumber" },
                values: new object[] { new Guid("cbdcc8a3-0eba-4a89-997a-a4e84e2bc6c1"), new Guid("966fa871-b850-48d0-b35a-01ac50ab133d"), new DateTime(2020, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 10.5332f, 10 });

            migrationBuilder.InsertData(
                table: "ExchangeRates",
                columns: new[] { "Id", "CurrencyId", "Date", "Rate", "UnitsNumber" },
                values: new object[] { new Guid("6bb52956-afbb-4495-9f76-67aaca79f50b"), new Guid("565429b9-b082-43ae-a19f-962e9983a93d"), new DateTime(2020, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 24.9293f, 100 });

            migrationBuilder.InsertData(
                table: "ExchangeRates",
                columns: new[] { "Id", "CurrencyId", "Date", "Rate", "UnitsNumber" },
                values: new object[] { new Guid("1980512b-eeaa-4000-8898-0760eac5536a"), new Guid("565429b9-b082-43ae-a19f-962e9983a93d"), new DateTime(2020, 10, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 24.9992f, 100 });

            migrationBuilder.InsertData(
                table: "ExchangeRates",
                columns: new[] { "Id", "CurrencyId", "Date", "Rate", "UnitsNumber" },
                values: new object[] { new Guid("359f7d86-567e-4dc9-94e5-391ee5606724"), new Guid("565429b9-b082-43ae-a19f-962e9983a93d"), new DateTime(2020, 10, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 25.0295f, 100 });

            migrationBuilder.InsertData(
                table: "ExchangeRates",
                columns: new[] { "Id", "CurrencyId", "Date", "Rate", "UnitsNumber" },
                values: new object[] { new Guid("ce9d5173-bcd8-43f1-8b75-4ceca01c45b4"), new Guid("0d02d2f7-9d33-4170-affc-e4f109ba77d3"), new DateTime(2020, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 67.2485f, 1000 });

            migrationBuilder.InsertData(
                table: "ExchangeRates",
                columns: new[] { "Id", "CurrencyId", "Date", "Rate", "UnitsNumber" },
                values: new object[] { new Guid("43a71601-9d4c-4f68-96df-7c8417a02465"), new Guid("0d02d2f7-9d33-4170-affc-e4f109ba77d3"), new DateTime(2020, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 67.0697f, 1000 });

            migrationBuilder.InsertData(
                table: "ExchangeRates",
                columns: new[] { "Id", "CurrencyId", "Date", "Rate", "UnitsNumber" },
                values: new object[] { new Guid("19c77875-9f28-4208-bf4a-57498eaafba0"), new Guid("0d02d2f7-9d33-4170-affc-e4f109ba77d3"), new DateTime(2020, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 67.4173f, 1000 });

            migrationBuilder.InsertData(
                table: "ExchangeRates",
                columns: new[] { "Id", "CurrencyId", "Date", "Rate", "UnitsNumber" },
                values: new object[] { new Guid("6a91a2b0-6e81-4891-96bd-d678676d055b"), new Guid("0d02d2f7-9d33-4170-affc-e4f109ba77d3"), new DateTime(2020, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 67.4934f, 1000 });

            migrationBuilder.InsertData(
                table: "ExchangeRates",
                columns: new[] { "Id", "CurrencyId", "Date", "Rate", "UnitsNumber" },
                values: new object[] { new Guid("bbcd1ea9-0820-498f-a16b-f964669542a4"), new Guid("0d02d2f7-9d33-4170-affc-e4f109ba77d3"), new DateTime(2020, 10, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 68.0033f, 1000 });

            migrationBuilder.InsertData(
                table: "ExchangeRates",
                columns: new[] { "Id", "CurrencyId", "Date", "Rate", "UnitsNumber" },
                values: new object[] { new Guid("2a15d933-6ca0-48c6-913d-e9504d3dab74"), new Guid("0d02d2f7-9d33-4170-affc-e4f109ba77d3"), new DateTime(2020, 10, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 68.0903f, 1000 });

            migrationBuilder.InsertData(
                table: "ExchangeRates",
                columns: new[] { "Id", "CurrencyId", "Date", "Rate", "UnitsNumber" },
                values: new object[] { new Guid("f5647889-8366-44cd-bb7e-e6606b546687"), new Guid("77018082-91cf-4237-a9f1-b8ea8e12d005"), new DateTime(2020, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 99.3902f, 10 });

            migrationBuilder.InsertData(
                table: "ExchangeRates",
                columns: new[] { "Id", "CurrencyId", "Date", "Rate", "UnitsNumber" },
                values: new object[] { new Guid("4783fc42-6e1b-4104-a282-0bf14fff5cd8"), new Guid("77018082-91cf-4237-a9f1-b8ea8e12d005"), new DateTime(2020, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 99.3844f, 10 });

            migrationBuilder.InsertData(
                table: "ExchangeRates",
                columns: new[] { "Id", "CurrencyId", "Date", "Rate", "UnitsNumber" },
                values: new object[] { new Guid("125907e0-2103-42e5-a2ae-920728f033ee"), new Guid("77018082-91cf-4237-a9f1-b8ea8e12d005"), new DateTime(2020, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 99.7219f, 10 });

            migrationBuilder.InsertData(
                table: "ExchangeRates",
                columns: new[] { "Id", "CurrencyId", "Date", "Rate", "UnitsNumber" },
                values: new object[] { new Guid("72b7cc2e-3786-4851-bbf8-9bbaa2cc29b9"), new Guid("77018082-91cf-4237-a9f1-b8ea8e12d005"), new DateTime(2020, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 99.7096f, 10 });

            migrationBuilder.InsertData(
                table: "ExchangeRates",
                columns: new[] { "Id", "CurrencyId", "Date", "Rate", "UnitsNumber" },
                values: new object[] { new Guid("68101c69-c4ec-4a19-94c2-0c2dfc196d29"), new Guid("77018082-91cf-4237-a9f1-b8ea8e12d005"), new DateTime(2020, 10, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 10.0574f, 10 });

            migrationBuilder.InsertData(
                table: "ExchangeRates",
                columns: new[] { "Id", "CurrencyId", "Date", "Rate", "UnitsNumber" },
                values: new object[] { new Guid("bf34ce28-7a04-495b-bd68-66946d79a4b0"), new Guid("77018082-91cf-4237-a9f1-b8ea8e12d005"), new DateTime(2020, 10, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 10.0598f, 10 });

            migrationBuilder.InsertData(
                table: "ExchangeRates",
                columns: new[] { "Id", "CurrencyId", "Date", "Rate", "UnitsNumber" },
                values: new object[] { new Guid("e2670483-a017-496f-b5b4-83c5766f863e"), new Guid("ead32013-ea79-4f7d-904f-74fe92e6a06d"), new DateTime(2020, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 12.2048f, 1 });

            migrationBuilder.InsertData(
                table: "ExchangeRates",
                columns: new[] { "Id", "CurrencyId", "Date", "Rate", "UnitsNumber" },
                values: new object[] { new Guid("a25a776d-4402-4638-a5e0-68b99886b70a"), new Guid("ead32013-ea79-4f7d-904f-74fe92e6a06d"), new DateTime(2020, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 12.2237f, 1 });

            migrationBuilder.InsertData(
                table: "ExchangeRates",
                columns: new[] { "Id", "CurrencyId", "Date", "Rate", "UnitsNumber" },
                values: new object[] { new Guid("64d6a1c8-b695-4f6c-a61d-418484b99edc"), new Guid("ead32013-ea79-4f7d-904f-74fe92e6a06d"), new DateTime(2020, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 12.2434f, 1 });

            migrationBuilder.InsertData(
                table: "ExchangeRates",
                columns: new[] { "Id", "CurrencyId", "Date", "Rate", "UnitsNumber" },
                values: new object[] { new Guid("93d5e7f6-dbba-47c4-b98f-8279b2489491"), new Guid("ead32013-ea79-4f7d-904f-74fe92e6a06d"), new DateTime(2020, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 12.1946f, 1 });

            migrationBuilder.InsertData(
                table: "ExchangeRates",
                columns: new[] { "Id", "CurrencyId", "Date", "Rate", "UnitsNumber" },
                values: new object[] { new Guid("520c2259-2527-4bb2-86fc-0786960660d4"), new Guid("ead32013-ea79-4f7d-904f-74fe92e6a06d"), new DateTime(2020, 10, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 12.2698f, 1 });

            migrationBuilder.InsertData(
                table: "ExchangeRates",
                columns: new[] { "Id", "CurrencyId", "Date", "Rate", "UnitsNumber" },
                values: new object[] { new Guid("b85e572d-296b-4f70-ba3f-717e36052b85"), new Guid("ead32013-ea79-4f7d-904f-74fe92e6a06d"), new DateTime(2020, 10, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 12.2707f, 1 });

            migrationBuilder.InsertData(
                table: "ExchangeRates",
                columns: new[] { "Id", "CurrencyId", "Date", "Rate", "UnitsNumber" },
                values: new object[] { new Guid("556f2cab-7f40-4f86-9fba-0b70d42e4ebf"), new Guid("966fa871-b850-48d0-b35a-01ac50ab133d"), new DateTime(2020, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 10.5151f, 10 });

            migrationBuilder.InsertData(
                table: "ExchangeRates",
                columns: new[] { "Id", "CurrencyId", "Date", "Rate", "UnitsNumber" },
                values: new object[] { new Guid("876532f8-88a7-4cbb-875c-8d552090bc56"), new Guid("9e0e348d-167d-4a5d-b110-182f96ddc6f6"), new DateTime(2020, 10, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 74.0895f, 100 });

            migrationBuilder.CreateIndex(
                name: "IX_Currencies_Code",
                table: "Currencies",
                column: "Code",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ExchangeRates_CurrencyId",
                table: "ExchangeRates",
                column: "CurrencyId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ExchangeRates");

            migrationBuilder.DropTable(
                name: "Currencies");
        }
    }
}
