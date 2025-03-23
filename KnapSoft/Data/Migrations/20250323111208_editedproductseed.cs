using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KnapSoft.Data.Migrations
{
    /// <inheritdoc />
    public partial class editedproductseed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "Description",
                value: "Umožňuje přihlášení uživatelů do systému pomocí e-mailu a hesla. Vaši klienti nebo zaměstnanci se mohou bezpečně registrovat, přihlašovat a spravovat své účty.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "Description",
                value: "Moderní způsob práce s databází, který zajišťuje, že všechna data uložená ve vaší aplikaci jsou bezpečná, přehledná a snadno spravovatelná. Vy o tom nemusíte vědět nic – všechno běží na pozadí.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "Description",
                value: "Vaši zákazníci mohou jednoduše zaplatit kartou nebo si nastavit předplatné. Rychlé a bezpečné platby přímo na vašem webu.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "Description",
                value: "Snadné ovládání celého systému přes přehledné administrační rozhraní – správa obsahu, uživatelů nebo objednávek na pár kliknutí.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "Description",
                value: "Odesílání automatických e-mailů, SMS nebo upozornění na mobil. Například potvrzení objednávky, připomenutí schůzky nebo změna stavu.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "Description",
                value: "Zákazníci si sami online vyberou volný termín – ideální pro kadeřnictví, ordinace, poradenství nebo služby s objednávkami.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "Description",
                value: "Automaticky generuje faktury, které si můžete stáhnout v PDF. Přehled o platbách, daňových dokladech a export pro účetní.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "Description",
                value: "Technické rozhraní, které umožňuje propojit váš systém s jinými aplikacemi nebo mobilními zařízeními. Vhodné pro pokročilejší použití.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                column: "Description",
                value: "Jedna aplikace může sloužit více firmám nebo pobočkám – každá má své vlastní prostředí, ale vše běží v jednom systému.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                column: "Description",
                value: "Vaše aplikace bude běžet na výkonném serveru, který máme plně pod kontrolou. Vhodné pro náročnější projekty a firmy.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                column: "Description",
                value: "Moderní cloudový hosting od Microsoftu. Škálovatelné, bezpečné a spolehlivé řešení s automatickými aktualizacemi a zálohami.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                column: "Description",
                value: "Vaše webová aplikace bude fungovat i bez připojení k internetu a může být nainstalována jako „mobilní aplikace“ na domovskou obrazovku telefonu.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                column: "Description",
                value: "Spolehlivé odesílání e-mailů z vašeho systému (potvrzení, oznámení, upozornění). Funguje přes zabezpečené servery.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                column: "Description",
                value: "Vaše stránky budou přátelské pro vyhledávače (Google atd.), takže vás zákazníci snáze najdou online.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                column: "Description",
                value: "2 hodiny konzultací nebo pomoci měsíčně – e-mail, úpravy, otázky. Vhodné pro běžný provoz.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                column: "Description",
                value: "Reakce do 24 hodin, až 5 hodin měsíčně. Ideální pro firmy, kde je klíčová rychlost reakce a podpora při problémech.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                column: "Description",
                value: "Napojíme váš systém na české i mezinárodní platební brány – GoPay, ComGate, Stripe, GPWebPay a další.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                column: "Description",
                value: "Přehledný manuál, který krok za krokem vysvětluje, jak systém ovládat – ideální při předání aplikace klientovi.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                column: "Description",
                value: "Individuální online školení nebo konzultace přes videohovor. Přizpůsobíme se vašemu tempu i konkrétním potřebám.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                column: "Description",
                value: "Možnost nahrát nebo stáhnout data ve formátech CSV, Excel nebo PDF. Hodí se pro evidenci, účetnictví nebo zálohování.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                column: "Description",
                value: "Různé úrovně přístupů – například admin, manažer nebo běžný uživatel. Každý uvidí jen to, co potřebuje.");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "Description",
                value: "Přihlášení, registrace, správa účtů");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "Description",
                value: "ORM a datová vrstva");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "Description",
                value: "Online platby + předplatné");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "Description",
                value: "Webová administrace obsahu");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "Description",
                value: "Email/SMS/push oznámení");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "Description",
                value: "Kalendář, rezervace");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "Description",
                value: "Vystavování faktur, exporty, DPH");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "Description",
                value: "Backend API pro mobilní nebo externí appky");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                column: "Description",
                value: "Oddělení více klientů v jedné aplikaci");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                column: "Description",
                value: "Vlastní server včetně nastavení a zabezpečení");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                column: "Description",
                value: "Nasazení na Azure (App Service + SQL + SMTP)");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                column: "Description",
                value: "Offline režim, Add to Home screen, service worker");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                column: "Description",
                value: "SMTP, SendGrid integrace");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                column: "Description",
                value: "Základní SEO, OpenGraph, sitemap");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                column: "Description",
                value: "2 hodiny měsíčně, běžná priorita");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                column: "Description",
                value: "Reakce do 24h, až 5 hodin měsíčně");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                column: "Description",
                value: "Podpora více platebních metod");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                column: "Description",
                value: "Manuály a návody pro klienta");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                column: "Description",
                value: "1-2 hod videohovor/online školení");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                column: "Description",
                value: "CSV, Excel, PDF import/export");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                column: "Description",
                value: "Role a oprávnění");
        }
    }
}
