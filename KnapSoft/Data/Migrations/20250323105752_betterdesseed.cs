using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KnapSoft.Data.Migrations
{
    /// <inheritdoc />
    public partial class betterdesseed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Solutions",
                keyColumn: "Id",
                keyValue: 1,
                column: "Description",
                value: "Ideální pro malé firmy a živnostníky. Jednoduchá prezentace služeb, kontaktní formulář a vlastní správa obsahu bez složitého ovládání.");

            migrationBuilder.UpdateData(
                table: "Solutions",
                keyColumn: "Id",
                keyValue: 2,
                column: "Description",
                value: "Moderní mobilní web, který funguje i offline. Vaši zákazníci si jej mohou přidat na plochu jako aplikaci. Skvělé pro rychlé objednávky, rezervace nebo interní systémy.");

            migrationBuilder.UpdateData(
                table: "Solutions",
                keyColumn: "Id",
                keyValue: 3,
                column: "Description",
                value: "Základní e-shop pro menší prodej. Zahrnuje správu produktů, košík, online platby a přehledné objednávky. Vhodné pro začínající prodejce.");

            migrationBuilder.UpdateData(
                table: "Solutions",
                keyColumn: "Id",
                keyValue: 4,
                column: "Description",
                value: "Rozšířený e-shop pro rostoucí podnikání. Navíc nabízí fakturaci, přehledy pro účetní, exporty a více uživatelských práv. Vhodné pro firmy, které chtějí růst.");

            migrationBuilder.UpdateData(
                table: "Solutions",
                keyColumn: "Id",
                keyValue: 5,
                column: "Description",
                value: "Kompletní řešení pro rozvoz jídel nebo zboží. Zákazníci objednají online, vy dostanete přehled o objednávkách a trasách. Včetně notifikací a plateb.");

            migrationBuilder.UpdateData(
                table: "Solutions",
                keyColumn: "Id",
                keyValue: 6,
                column: "Description",
                value: "Vše, co potřebujete pro rychlý provoz: přehled objednávek, pokladní režim, reporty a možnost tisku účtenek. Ideální pro bistra a fastfoody.");

            migrationBuilder.UpdateData(
                table: "Solutions",
                keyColumn: "Id",
                keyValue: 7,
                column: "Description",
                value: "Správa menu, rezervace stolů a denní reporty. Jednoduché ovládání pro personál a přehledné rozhraní pro zákazníky. Připraveno pro provoz s obsluhou.");

            migrationBuilder.UpdateData(
                table: "Solutions",
                keyColumn: "Id",
                keyValue: 8,
                column: "Description",
                value: "Umožněte svým zákazníkům přihlásit se, sledovat objednávky, stahovat faktury nebo komunikovat. Vhodné i pro správu dokumentů a firemních služeb.");

            migrationBuilder.UpdateData(
                table: "Solutions",
                keyColumn: "Id",
                keyValue: 9,
                column: "Description",
                value: "Profesionální systém pro provoz více firem nebo poboček pod jednou aplikací. Každý klient má své vlastní prostředí. Ideální pro B2B platformy nebo franšízy.");

            migrationBuilder.UpdateData(
                table: "Solutions",
                keyColumn: "Id",
                keyValue: 10,
                column: "Description",
                value: "Prémiové řešení s cloudovým hostingem na Azure, offline režimem, zákaznickou dokumentací a prioritní technickou podporou. Vhodné pro náročné projekty a firmy s růstem.");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Solutions",
                keyColumn: "Id",
                keyValue: 1,
                column: "Description",
                value: "Firemní prezentace");

            migrationBuilder.UpdateData(
                table: "Solutions",
                keyColumn: "Id",
                keyValue: 2,
                column: "Description",
                value: "Offline-ready mobilní web");

            migrationBuilder.UpdateData(
                table: "Solutions",
                keyColumn: "Id",
                keyValue: 3,
                column: "Description",
                value: "Malý eshop s online platbami");

            migrationBuilder.UpdateData(
                table: "Solutions",
                keyColumn: "Id",
                keyValue: 4,
                column: "Description",
                value: "Eshop s fakturací a exporty");

            migrationBuilder.UpdateData(
                table: "Solutions",
                keyColumn: "Id",
                keyValue: 5,
                column: "Description",
                value: "Rozvoz jídel s objednávkami");

            migrationBuilder.UpdateData(
                table: "Solutions",
                keyColumn: "Id",
                keyValue: 6,
                column: "Description",
                value: "Objednávky, reporty, pokladna");

            migrationBuilder.UpdateData(
                table: "Solutions",
                keyColumn: "Id",
                keyValue: 7,
                column: "Description",
                value: "Rezervace, správa menu");

            migrationBuilder.UpdateData(
                table: "Solutions",
                keyColumn: "Id",
                keyValue: 8,
                column: "Description",
                value: "REST API a přístup k datům");

            migrationBuilder.UpdateData(
                table: "Solutions",
                keyColumn: "Id",
                keyValue: 9,
                column: "Description",
                value: "Více klientů, jedna aplikace");

            migrationBuilder.UpdateData(
                table: "Solutions",
                keyColumn: "Id",
                keyValue: 10,
                column: "Description",
                value: "Azure hosting, podpora, dokumentace");
        }
    }
}
