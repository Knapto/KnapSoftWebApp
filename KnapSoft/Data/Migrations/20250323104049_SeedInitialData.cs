using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace KnapSoft.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedInitialData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "Přihlášení, registrace, správa účtů", "Identity", 2000m },
                    { 2, "ORM a datová vrstva", "Entity Framework", 1500m },
                    { 3, "Online platby + předplatné", "Stripe integrace", 2500m },
                    { 4, "Webová administrace obsahu", "Admin panel", 2000m },
                    { 5, "Email/SMS/push oznámení", "Notifikace", 1800m },
                    { 6, "Kalendář, rezervace", "Rezervační systém", 4000m },
                    { 7, "Vystavování faktur, exporty, DPH", "Fakturační systém", 3500m },
                    { 8, "Backend API pro mobilní nebo externí appky", "REST API", 2000m },
                    { 9, "Oddělení více klientů v jedné aplikaci", "Multitenancy", 5000m },
                    { 10, "Vlastní server včetně nastavení a zabezpečení", "Hosting (VPS)", 5000m },
                    { 11, "Nasazení na Azure (App Service + SQL + SMTP)", "Hosting (Azure)", 3500m },
                    { 12, "Offline režim, Add to Home screen, service worker", "PWA podpora", 2000m },
                    { 13, "SMTP, SendGrid integrace", "Email systém", 1000m },
                    { 14, "Základní SEO, OpenGraph, sitemap", "SEO optimalizace", 1500m },
                    { 15, "2 hodiny měsíčně, běžná priorita", "Základní technická podpora", 1200m },
                    { 16, "Reakce do 24h, až 5 hodin měsíčně", "Prioritní podpora", 2500m },
                    { 17, "Podpora více platebních metod", "Integrace platební brány", 3000m },
                    { 18, "Manuály a návody pro klienta", "Uživatelská dokumentace", 2000m },
                    { 19, "1-2 hod videohovor/online školení", "Školení na míru", 2500m },
                    { 20, "CSV, Excel, PDF import/export", "Export/Import dat", 2200m },
                    { 21, "Role a oprávnění", "Správa uživatelských rolí", 2500m }
                });

            migrationBuilder.InsertData(
                table: "Solutions",
                columns: new[] { "Id", "Description", "MonthlyPrice", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "Firemní prezentace", 1200m, "Jednoduchý web", 8000m },
                    { 2, "Offline-ready mobilní web", 1500m, "PWA aplikace", 12000m },
                    { 3, "Malý eshop s online platbami", 1800m, "Eshop Basic", 18000m },
                    { 4, "Eshop s fakturací a exporty", 2200m, "Eshop Plus", 25000m },
                    { 5, "Rozvoz jídel s objednávkami", 2500m, "Rozvozový systém", 29000m },
                    { 6, "Objednávky, reporty, pokladna", 2800m, "Systém pro fastfoody", 32000m },
                    { 7, "Rezervace, správa menu", 2500m, "Systém pro kavárny", 28000m },
                    { 8, "REST API a přístup k datům", 1900m, "Portál pro klienty", 22000m },
                    { 9, "Více klientů, jedna aplikace", 3200m, "Multitenant SaaS", 38000m },
                    { 10, "Azure hosting, podpora, dokumentace", 3500m, "Full Azure PWA", 45000m }
                });

            migrationBuilder.InsertData(
                table: "SolutionProducts",
                columns: new[] { "ProductId", "SolutionId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 1 },
                    { 4, 1 },
                    { 10, 1 },
                    { 14, 1 },
                    { 1, 2 },
                    { 2, 2 },
                    { 4, 2 },
                    { 5, 2 },
                    { 11, 2 },
                    { 12, 2 },
                    { 1, 3 },
                    { 2, 3 },
                    { 3, 3 },
                    { 4, 3 },
                    { 7, 3 },
                    { 10, 3 },
                    { 1, 4 },
                    { 2, 4 },
                    { 3, 4 },
                    { 4, 4 },
                    { 5, 4 },
                    { 7, 4 },
                    { 10, 4 },
                    { 20, 4 },
                    { 21, 4 },
                    { 1, 5 },
                    { 2, 5 },
                    { 3, 5 },
                    { 4, 5 },
                    { 5, 5 },
                    { 7, 5 },
                    { 10, 5 },
                    { 17, 5 },
                    { 20, 5 },
                    { 1, 6 },
                    { 2, 6 },
                    { 3, 6 },
                    { 4, 6 },
                    { 7, 6 },
                    { 10, 6 },
                    { 20, 6 },
                    { 21, 6 },
                    { 1, 7 },
                    { 2, 7 },
                    { 4, 7 },
                    { 5, 7 },
                    { 6, 7 },
                    { 7, 7 },
                    { 10, 7 },
                    { 20, 7 },
                    { 21, 7 },
                    { 1, 8 },
                    { 2, 8 },
                    { 4, 8 },
                    { 5, 8 },
                    { 7, 8 },
                    { 8, 8 },
                    { 10, 8 },
                    { 1, 9 },
                    { 2, 9 },
                    { 4, 9 },
                    { 5, 9 },
                    { 7, 9 },
                    { 8, 9 },
                    { 9, 9 },
                    { 10, 9 },
                    { 1, 10 },
                    { 2, 10 },
                    { 4, 10 },
                    { 5, 10 },
                    { 7, 10 },
                    { 11, 10 },
                    { 12, 10 },
                    { 13, 10 },
                    { 15, 10 },
                    { 18, 10 },
                    { 19, 10 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "SolutionProducts",
                keyColumns: new[] { "ProductId", "SolutionId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "SolutionProducts",
                keyColumns: new[] { "ProductId", "SolutionId" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "SolutionProducts",
                keyColumns: new[] { "ProductId", "SolutionId" },
                keyValues: new object[] { 4, 1 });

            migrationBuilder.DeleteData(
                table: "SolutionProducts",
                keyColumns: new[] { "ProductId", "SolutionId" },
                keyValues: new object[] { 10, 1 });

            migrationBuilder.DeleteData(
                table: "SolutionProducts",
                keyColumns: new[] { "ProductId", "SolutionId" },
                keyValues: new object[] { 14, 1 });

            migrationBuilder.DeleteData(
                table: "SolutionProducts",
                keyColumns: new[] { "ProductId", "SolutionId" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "SolutionProducts",
                keyColumns: new[] { "ProductId", "SolutionId" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "SolutionProducts",
                keyColumns: new[] { "ProductId", "SolutionId" },
                keyValues: new object[] { 4, 2 });

            migrationBuilder.DeleteData(
                table: "SolutionProducts",
                keyColumns: new[] { "ProductId", "SolutionId" },
                keyValues: new object[] { 5, 2 });

            migrationBuilder.DeleteData(
                table: "SolutionProducts",
                keyColumns: new[] { "ProductId", "SolutionId" },
                keyValues: new object[] { 11, 2 });

            migrationBuilder.DeleteData(
                table: "SolutionProducts",
                keyColumns: new[] { "ProductId", "SolutionId" },
                keyValues: new object[] { 12, 2 });

            migrationBuilder.DeleteData(
                table: "SolutionProducts",
                keyColumns: new[] { "ProductId", "SolutionId" },
                keyValues: new object[] { 1, 3 });

            migrationBuilder.DeleteData(
                table: "SolutionProducts",
                keyColumns: new[] { "ProductId", "SolutionId" },
                keyValues: new object[] { 2, 3 });

            migrationBuilder.DeleteData(
                table: "SolutionProducts",
                keyColumns: new[] { "ProductId", "SolutionId" },
                keyValues: new object[] { 3, 3 });

            migrationBuilder.DeleteData(
                table: "SolutionProducts",
                keyColumns: new[] { "ProductId", "SolutionId" },
                keyValues: new object[] { 4, 3 });

            migrationBuilder.DeleteData(
                table: "SolutionProducts",
                keyColumns: new[] { "ProductId", "SolutionId" },
                keyValues: new object[] { 7, 3 });

            migrationBuilder.DeleteData(
                table: "SolutionProducts",
                keyColumns: new[] { "ProductId", "SolutionId" },
                keyValues: new object[] { 10, 3 });

            migrationBuilder.DeleteData(
                table: "SolutionProducts",
                keyColumns: new[] { "ProductId", "SolutionId" },
                keyValues: new object[] { 1, 4 });

            migrationBuilder.DeleteData(
                table: "SolutionProducts",
                keyColumns: new[] { "ProductId", "SolutionId" },
                keyValues: new object[] { 2, 4 });

            migrationBuilder.DeleteData(
                table: "SolutionProducts",
                keyColumns: new[] { "ProductId", "SolutionId" },
                keyValues: new object[] { 3, 4 });

            migrationBuilder.DeleteData(
                table: "SolutionProducts",
                keyColumns: new[] { "ProductId", "SolutionId" },
                keyValues: new object[] { 4, 4 });

            migrationBuilder.DeleteData(
                table: "SolutionProducts",
                keyColumns: new[] { "ProductId", "SolutionId" },
                keyValues: new object[] { 5, 4 });

            migrationBuilder.DeleteData(
                table: "SolutionProducts",
                keyColumns: new[] { "ProductId", "SolutionId" },
                keyValues: new object[] { 7, 4 });

            migrationBuilder.DeleteData(
                table: "SolutionProducts",
                keyColumns: new[] { "ProductId", "SolutionId" },
                keyValues: new object[] { 10, 4 });

            migrationBuilder.DeleteData(
                table: "SolutionProducts",
                keyColumns: new[] { "ProductId", "SolutionId" },
                keyValues: new object[] { 20, 4 });

            migrationBuilder.DeleteData(
                table: "SolutionProducts",
                keyColumns: new[] { "ProductId", "SolutionId" },
                keyValues: new object[] { 21, 4 });

            migrationBuilder.DeleteData(
                table: "SolutionProducts",
                keyColumns: new[] { "ProductId", "SolutionId" },
                keyValues: new object[] { 1, 5 });

            migrationBuilder.DeleteData(
                table: "SolutionProducts",
                keyColumns: new[] { "ProductId", "SolutionId" },
                keyValues: new object[] { 2, 5 });

            migrationBuilder.DeleteData(
                table: "SolutionProducts",
                keyColumns: new[] { "ProductId", "SolutionId" },
                keyValues: new object[] { 3, 5 });

            migrationBuilder.DeleteData(
                table: "SolutionProducts",
                keyColumns: new[] { "ProductId", "SolutionId" },
                keyValues: new object[] { 4, 5 });

            migrationBuilder.DeleteData(
                table: "SolutionProducts",
                keyColumns: new[] { "ProductId", "SolutionId" },
                keyValues: new object[] { 5, 5 });

            migrationBuilder.DeleteData(
                table: "SolutionProducts",
                keyColumns: new[] { "ProductId", "SolutionId" },
                keyValues: new object[] { 7, 5 });

            migrationBuilder.DeleteData(
                table: "SolutionProducts",
                keyColumns: new[] { "ProductId", "SolutionId" },
                keyValues: new object[] { 10, 5 });

            migrationBuilder.DeleteData(
                table: "SolutionProducts",
                keyColumns: new[] { "ProductId", "SolutionId" },
                keyValues: new object[] { 17, 5 });

            migrationBuilder.DeleteData(
                table: "SolutionProducts",
                keyColumns: new[] { "ProductId", "SolutionId" },
                keyValues: new object[] { 20, 5 });

            migrationBuilder.DeleteData(
                table: "SolutionProducts",
                keyColumns: new[] { "ProductId", "SolutionId" },
                keyValues: new object[] { 1, 6 });

            migrationBuilder.DeleteData(
                table: "SolutionProducts",
                keyColumns: new[] { "ProductId", "SolutionId" },
                keyValues: new object[] { 2, 6 });

            migrationBuilder.DeleteData(
                table: "SolutionProducts",
                keyColumns: new[] { "ProductId", "SolutionId" },
                keyValues: new object[] { 3, 6 });

            migrationBuilder.DeleteData(
                table: "SolutionProducts",
                keyColumns: new[] { "ProductId", "SolutionId" },
                keyValues: new object[] { 4, 6 });

            migrationBuilder.DeleteData(
                table: "SolutionProducts",
                keyColumns: new[] { "ProductId", "SolutionId" },
                keyValues: new object[] { 7, 6 });

            migrationBuilder.DeleteData(
                table: "SolutionProducts",
                keyColumns: new[] { "ProductId", "SolutionId" },
                keyValues: new object[] { 10, 6 });

            migrationBuilder.DeleteData(
                table: "SolutionProducts",
                keyColumns: new[] { "ProductId", "SolutionId" },
                keyValues: new object[] { 20, 6 });

            migrationBuilder.DeleteData(
                table: "SolutionProducts",
                keyColumns: new[] { "ProductId", "SolutionId" },
                keyValues: new object[] { 21, 6 });

            migrationBuilder.DeleteData(
                table: "SolutionProducts",
                keyColumns: new[] { "ProductId", "SolutionId" },
                keyValues: new object[] { 1, 7 });

            migrationBuilder.DeleteData(
                table: "SolutionProducts",
                keyColumns: new[] { "ProductId", "SolutionId" },
                keyValues: new object[] { 2, 7 });

            migrationBuilder.DeleteData(
                table: "SolutionProducts",
                keyColumns: new[] { "ProductId", "SolutionId" },
                keyValues: new object[] { 4, 7 });

            migrationBuilder.DeleteData(
                table: "SolutionProducts",
                keyColumns: new[] { "ProductId", "SolutionId" },
                keyValues: new object[] { 5, 7 });

            migrationBuilder.DeleteData(
                table: "SolutionProducts",
                keyColumns: new[] { "ProductId", "SolutionId" },
                keyValues: new object[] { 6, 7 });

            migrationBuilder.DeleteData(
                table: "SolutionProducts",
                keyColumns: new[] { "ProductId", "SolutionId" },
                keyValues: new object[] { 7, 7 });

            migrationBuilder.DeleteData(
                table: "SolutionProducts",
                keyColumns: new[] { "ProductId", "SolutionId" },
                keyValues: new object[] { 10, 7 });

            migrationBuilder.DeleteData(
                table: "SolutionProducts",
                keyColumns: new[] { "ProductId", "SolutionId" },
                keyValues: new object[] { 20, 7 });

            migrationBuilder.DeleteData(
                table: "SolutionProducts",
                keyColumns: new[] { "ProductId", "SolutionId" },
                keyValues: new object[] { 21, 7 });

            migrationBuilder.DeleteData(
                table: "SolutionProducts",
                keyColumns: new[] { "ProductId", "SolutionId" },
                keyValues: new object[] { 1, 8 });

            migrationBuilder.DeleteData(
                table: "SolutionProducts",
                keyColumns: new[] { "ProductId", "SolutionId" },
                keyValues: new object[] { 2, 8 });

            migrationBuilder.DeleteData(
                table: "SolutionProducts",
                keyColumns: new[] { "ProductId", "SolutionId" },
                keyValues: new object[] { 4, 8 });

            migrationBuilder.DeleteData(
                table: "SolutionProducts",
                keyColumns: new[] { "ProductId", "SolutionId" },
                keyValues: new object[] { 5, 8 });

            migrationBuilder.DeleteData(
                table: "SolutionProducts",
                keyColumns: new[] { "ProductId", "SolutionId" },
                keyValues: new object[] { 7, 8 });

            migrationBuilder.DeleteData(
                table: "SolutionProducts",
                keyColumns: new[] { "ProductId", "SolutionId" },
                keyValues: new object[] { 8, 8 });

            migrationBuilder.DeleteData(
                table: "SolutionProducts",
                keyColumns: new[] { "ProductId", "SolutionId" },
                keyValues: new object[] { 10, 8 });

            migrationBuilder.DeleteData(
                table: "SolutionProducts",
                keyColumns: new[] { "ProductId", "SolutionId" },
                keyValues: new object[] { 1, 9 });

            migrationBuilder.DeleteData(
                table: "SolutionProducts",
                keyColumns: new[] { "ProductId", "SolutionId" },
                keyValues: new object[] { 2, 9 });

            migrationBuilder.DeleteData(
                table: "SolutionProducts",
                keyColumns: new[] { "ProductId", "SolutionId" },
                keyValues: new object[] { 4, 9 });

            migrationBuilder.DeleteData(
                table: "SolutionProducts",
                keyColumns: new[] { "ProductId", "SolutionId" },
                keyValues: new object[] { 5, 9 });

            migrationBuilder.DeleteData(
                table: "SolutionProducts",
                keyColumns: new[] { "ProductId", "SolutionId" },
                keyValues: new object[] { 7, 9 });

            migrationBuilder.DeleteData(
                table: "SolutionProducts",
                keyColumns: new[] { "ProductId", "SolutionId" },
                keyValues: new object[] { 8, 9 });

            migrationBuilder.DeleteData(
                table: "SolutionProducts",
                keyColumns: new[] { "ProductId", "SolutionId" },
                keyValues: new object[] { 9, 9 });

            migrationBuilder.DeleteData(
                table: "SolutionProducts",
                keyColumns: new[] { "ProductId", "SolutionId" },
                keyValues: new object[] { 10, 9 });

            migrationBuilder.DeleteData(
                table: "SolutionProducts",
                keyColumns: new[] { "ProductId", "SolutionId" },
                keyValues: new object[] { 1, 10 });

            migrationBuilder.DeleteData(
                table: "SolutionProducts",
                keyColumns: new[] { "ProductId", "SolutionId" },
                keyValues: new object[] { 2, 10 });

            migrationBuilder.DeleteData(
                table: "SolutionProducts",
                keyColumns: new[] { "ProductId", "SolutionId" },
                keyValues: new object[] { 4, 10 });

            migrationBuilder.DeleteData(
                table: "SolutionProducts",
                keyColumns: new[] { "ProductId", "SolutionId" },
                keyValues: new object[] { 5, 10 });

            migrationBuilder.DeleteData(
                table: "SolutionProducts",
                keyColumns: new[] { "ProductId", "SolutionId" },
                keyValues: new object[] { 7, 10 });

            migrationBuilder.DeleteData(
                table: "SolutionProducts",
                keyColumns: new[] { "ProductId", "SolutionId" },
                keyValues: new object[] { 11, 10 });

            migrationBuilder.DeleteData(
                table: "SolutionProducts",
                keyColumns: new[] { "ProductId", "SolutionId" },
                keyValues: new object[] { 12, 10 });

            migrationBuilder.DeleteData(
                table: "SolutionProducts",
                keyColumns: new[] { "ProductId", "SolutionId" },
                keyValues: new object[] { 13, 10 });

            migrationBuilder.DeleteData(
                table: "SolutionProducts",
                keyColumns: new[] { "ProductId", "SolutionId" },
                keyValues: new object[] { 15, 10 });

            migrationBuilder.DeleteData(
                table: "SolutionProducts",
                keyColumns: new[] { "ProductId", "SolutionId" },
                keyValues: new object[] { 18, 10 });

            migrationBuilder.DeleteData(
                table: "SolutionProducts",
                keyColumns: new[] { "ProductId", "SolutionId" },
                keyValues: new object[] { 19, 10 });

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Solutions",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Solutions",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Solutions",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Solutions",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Solutions",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Solutions",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Solutions",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Solutions",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Solutions",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Solutions",
                keyColumn: "Id",
                keyValue: 10);
        }
    }
}
