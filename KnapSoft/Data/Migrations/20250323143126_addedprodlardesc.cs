using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace KnapSoft.Data.Migrations
{
    /// <inheritdoc />
    public partial class addedprodlardesc : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<string>(
                name: "LargeDescription",
                table: "Products",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LargeDescription",
                table: "Products");

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "Umožňuje přihlášení uživatelů do systému pomocí e-mailu a hesla. Vaši klienti nebo zaměstnanci se mohou bezpečně registrovat, přihlašovat a spravovat své účty.", "Identity", 2000m },
                    { 2, "Moderní způsob práce s databází, který zajišťuje, že všechna data uložená ve vaší aplikaci jsou bezpečná, přehledná a snadno spravovatelná. Vy o tom nemusíte vědět nic – všechno běží na pozadí.", "Entity Framework", 1500m },
                    { 3, "Vaši zákazníci mohou jednoduše zaplatit kartou nebo si nastavit předplatné. Rychlé a bezpečné platby přímo na vašem webu.", "Stripe integrace", 2500m },
                    { 4, "Snadné ovládání celého systému přes přehledné administrační rozhraní – správa obsahu, uživatelů nebo objednávek na pár kliknutí.", "Admin panel", 2000m },
                    { 5, "Odesílání automatických e-mailů, SMS nebo upozornění na mobil. Například potvrzení objednávky, připomenutí schůzky nebo změna stavu.", "Notifikace", 1800m },
                    { 6, "Zákazníci si sami online vyberou volný termín – ideální pro kadeřnictví, ordinace, poradenství nebo služby s objednávkami.", "Rezervační systém", 4000m },
                    { 7, "Automaticky generuje faktury, které si můžete stáhnout v PDF. Přehled o platbách, daňových dokladech a export pro účetní.", "Fakturační systém", 3500m },
                    { 8, "Technické rozhraní, které umožňuje propojit váš systém s jinými aplikacemi nebo mobilními zařízeními. Vhodné pro pokročilejší použití.", "REST API", 2000m },
                    { 9, "Jedna aplikace může sloužit více firmám nebo pobočkám – každá má své vlastní prostředí, ale vše běží v jednom systému.", "Multitenancy", 5000m },
                    { 10, "Vaše aplikace bude běžet na výkonném serveru, který máme plně pod kontrolou. Vhodné pro náročnější projekty a firmy.", "Hosting (VPS)", 5000m },
                    { 11, "Moderní cloudový hosting od Microsoftu. Škálovatelné, bezpečné a spolehlivé řešení s automatickými aktualizacemi a zálohami.", "Hosting (Azure)", 3500m },
                    { 12, "Vaše webová aplikace bude fungovat i bez připojení k internetu a může být nainstalována jako „mobilní aplikace“ na domovskou obrazovku telefonu.", "PWA podpora", 2000m },
                    { 13, "Spolehlivé odesílání e-mailů z vašeho systému (potvrzení, oznámení, upozornění). Funguje přes zabezpečené servery.", "Email systém", 1000m },
                    { 14, "Vaše stránky budou přátelské pro vyhledávače (Google atd.), takže vás zákazníci snáze najdou online.", "SEO optimalizace", 1500m },
                    { 15, "2 hodiny konzultací nebo pomoci měsíčně – e-mail, úpravy, otázky. Vhodné pro běžný provoz.", "Základní technická podpora", 1200m },
                    { 16, "Reakce do 24 hodin, až 5 hodin měsíčně. Ideální pro firmy, kde je klíčová rychlost reakce a podpora při problémech.", "Prioritní podpora", 2500m },
                    { 17, "Napojíme váš systém na české i mezinárodní platební brány – GoPay, ComGate, Stripe, GPWebPay a další.", "Integrace platební brány", 3000m },
                    { 18, "Přehledný manuál, který krok za krokem vysvětluje, jak systém ovládat – ideální při předání aplikace klientovi.", "Uživatelská dokumentace", 2000m },
                    { 19, "Individuální online školení nebo konzultace přes videohovor. Přizpůsobíme se vašemu tempu i konkrétním potřebám.", "Školení na míru", 2500m },
                    { 20, "Možnost nahrát nebo stáhnout data ve formátech CSV, Excel nebo PDF. Hodí se pro evidenci, účetnictví nebo zálohování.", "Export/Import dat", 2200m },
                    { 21, "Různé úrovně přístupů – například admin, manažer nebo běžný uživatel. Každý uvidí jen to, co potřebuje.", "Správa uživatelských rolí", 2500m }
                });

            migrationBuilder.InsertData(
                table: "Solutions",
                columns: new[] { "Id", "Description", "LargeDescription", "MonthlyPrice", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "Ideální pro malé firmy a živnostníky. Jednoduchá prezentace služeb, kontaktní formulář a vlastní správa obsahu bez složitého ovládání.", "", 1200m, "Jednoduchý web", 8000m },
                    { 2, "Moderní mobilní web, který funguje i offline. Vaši zákazníci si jej mohou přidat na plochu jako aplikaci. Skvělé pro rychlé objednávky, rezervace nebo interní systémy.", "", 1500m, "PWA aplikace", 12000m },
                    { 3, "Základní e-shop pro menší prodej. Zahrnuje správu produktů, košík, online platby a přehledné objednávky. Vhodné pro začínající prodejce.", "", 1800m, "Eshop Basic", 18000m },
                    { 4, "Rozšířený e-shop pro rostoucí podnikání. Navíc nabízí fakturaci, přehledy pro účetní, exporty a více uživatelských práv. Vhodné pro firmy, které chtějí růst.", "", 2200m, "Eshop Plus", 25000m },
                    { 5, "Kompletní řešení pro rozvoz jídel nebo zboží. Zákazníci objednají online, vy dostanete přehled o objednávkách a trasách. Včetně notifikací a plateb.", "", 2500m, "Rozvozový systém", 29000m },
                    { 6, "Vše, co potřebujete pro rychlý provoz: přehled objednávek, pokladní režim, reporty a možnost tisku účtenek. Ideální pro bistra a fastfoody.", "", 2800m, "Systém pro fastfoody", 32000m },
                    { 7, "Správa menu, rezervace stolů a denní reporty. Jednoduché ovládání pro personál a přehledné rozhraní pro zákazníky. Připraveno pro provoz s obsluhou.", "", 2500m, "Systém pro kavárny", 28000m },
                    { 8, "Umožněte svým zákazníkům přihlásit se, sledovat objednávky, stahovat faktury nebo komunikovat. Vhodné i pro správu dokumentů a firemních služeb.", "", 1900m, "Portál pro klienty", 22000m },
                    { 9, "Profesionální systém pro provoz více firem nebo poboček pod jednou aplikací. Každý klient má své vlastní prostředí. Ideální pro B2B platformy nebo franšízy.", "", 3200m, "Multitenant SaaS", 38000m },
                    { 10, "Prémiové řešení s cloudovým hostingem na Azure, offline režimem, zákaznickou dokumentací a prioritní technickou podporou. Vhodné pro náročné projekty a firmy s růstem.", "", 3500m, "Full Azure PWA", 45000m }
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
    }
}
