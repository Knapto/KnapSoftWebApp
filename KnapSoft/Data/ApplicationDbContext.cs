using KnapSoft.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace KnapSoft.Data;

public class ApplicationDbContext : IdentityDbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }
    public DbSet<Product> Products { get; set; }
    public DbSet<KnapSoft.Models.Solution> Solutions { get; set; }
    public DbSet<SolutionProduct> SolutionProducts { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.Entity<SolutionProduct>()
            .HasKey(sp => new { sp.SolutionId, sp.ProductId });

        builder.Entity<SolutionProduct>()
            .HasOne(sp => sp.Solution)
            .WithMany(s => s.SolutionProducts)
            .HasForeignKey(sp => sp.SolutionId);

        builder.Entity<SolutionProduct>()
            .HasOne(sp => sp.Product)
            .WithMany(p => p.SolutionProducts)
            .HasForeignKey(sp => sp.ProductId);

        // === PRODUCTS ===
        builder.Entity<Product>().HasData(
            new Product { Id = 1, Name = "Identity", Description = "Umožňuje přihlášení uživatelů do systému pomocí e-mailu a hesla. Vaši klienti nebo zaměstnanci se mohou bezpečně registrovat, přihlašovat a spravovat své účty.", Price = 2000 },
            new Product { Id = 2, Name = "Entity Framework", Description = "Moderní způsob práce s databází, který zajišťuje, že všechna data uložená ve vaší aplikaci jsou bezpečná, přehledná a snadno spravovatelná. Vy o tom nemusíte vědět nic – všechno běží na pozadí.", Price = 1500 },
            new Product { Id = 3, Name = "Stripe integrace", Description = "Vaši zákazníci mohou jednoduše zaplatit kartou nebo si nastavit předplatné. Rychlé a bezpečné platby přímo na vašem webu.", Price = 2500 },
            new Product { Id = 4, Name = "Admin panel", Description = "Snadné ovládání celého systému přes přehledné administrační rozhraní – správa obsahu, uživatelů nebo objednávek na pár kliknutí.", Price = 2000 },
            new Product { Id = 5, Name = "Notifikace", Description = "Odesílání automatických e-mailů, SMS nebo upozornění na mobil. Například potvrzení objednávky, připomenutí schůzky nebo změna stavu.", Price = 1800 },
            new Product { Id = 6, Name = "Rezervační systém", Description = "Zákazníci si sami online vyberou volný termín – ideální pro kadeřnictví, ordinace, poradenství nebo služby s objednávkami.", Price = 4000 },
            new Product { Id = 7, Name = "Fakturační systém", Description = "Automaticky generuje faktury, které si můžete stáhnout v PDF. Přehled o platbách, daňových dokladech a export pro účetní.", Price = 3500 },
            new Product { Id = 8, Name = "REST API", Description = "Technické rozhraní, které umožňuje propojit váš systém s jinými aplikacemi nebo mobilními zařízeními. Vhodné pro pokročilejší použití.", Price = 2000 },
            new Product { Id = 9, Name = "Multitenancy", Description = "Jedna aplikace může sloužit více firmám nebo pobočkám – každá má své vlastní prostředí, ale vše běží v jednom systému.", Price = 5000 },
            new Product { Id = 10, Name = "Hosting (VPS)", Description = "Vaše aplikace bude běžet na výkonném serveru, který máme plně pod kontrolou. Vhodné pro náročnější projekty a firmy.", Price = 5000 },
            new Product { Id = 11, Name = "Hosting (Azure)", Description = "Moderní cloudový hosting od Microsoftu. Škálovatelné, bezpečné a spolehlivé řešení s automatickými aktualizacemi a zálohami.", Price = 3500 },
            new Product { Id = 12, Name = "PWA podpora", Description = "Vaše webová aplikace bude fungovat i bez připojení k internetu a může být nainstalována jako „mobilní aplikace“ na domovskou obrazovku telefonu.", Price = 2000 },
            new Product { Id = 13, Name = "Email systém", Description = "Spolehlivé odesílání e-mailů z vašeho systému (potvrzení, oznámení, upozornění). Funguje přes zabezpečené servery.", Price = 1000 },
            new Product { Id = 14, Name = "SEO optimalizace", Description = "Vaše stránky budou přátelské pro vyhledávače (Google atd.), takže vás zákazníci snáze najdou online.", Price = 1500 },
            new Product { Id = 15, Name = "Základní technická podpora", Description = "2 hodiny konzultací nebo pomoci měsíčně – e-mail, úpravy, otázky. Vhodné pro běžný provoz.", Price = 1200 },
            new Product { Id = 16, Name = "Prioritní podpora", Description = "Reakce do 24 hodin, až 5 hodin měsíčně. Ideální pro firmy, kde je klíčová rychlost reakce a podpora při problémech.", Price = 2500 },
            new Product { Id = 17, Name = "Integrace platební brány", Description = "Napojíme váš systém na české i mezinárodní platební brány – GoPay, ComGate, Stripe, GPWebPay a další.", Price = 3000 },
            new Product { Id = 18, Name = "Uživatelská dokumentace", Description = "Přehledný manuál, který krok za krokem vysvětluje, jak systém ovládat – ideální při předání aplikace klientovi.", Price = 2000 },
            new Product { Id = 19, Name = "Školení na míru", Description = "Individuální online školení nebo konzultace přes videohovor. Přizpůsobíme se vašemu tempu i konkrétním potřebám.", Price = 2500 },
            new Product { Id = 20, Name = "Export/Import dat", Description = "Možnost nahrát nebo stáhnout data ve formátech CSV, Excel nebo PDF. Hodí se pro evidenci, účetnictví nebo zálohování.", Price = 2200 },
            new Product { Id = 21, Name = "Správa uživatelských rolí", Description = "Různé úrovně přístupů – například admin, manažer nebo běžný uživatel. Každý uvidí jen to, co potřebuje.", Price = 2500 }
        );

        // === SOLUTIONS ===
        builder.Entity<Solution>().HasData(
    new Solution
    {
        Id = 1,
        Name = "Jednoduchý web",
        Description = "Ideální pro malé firmy a živnostníky. Jednoduchá prezentace služeb, kontaktní formulář a vlastní správa obsahu bez složitého ovládání.",
        Price = 8000,
        MonthlyPrice = 1200
    },
    new Solution
    {
        Id = 2,
        Name = "PWA aplikace",
        Description = "Moderní mobilní web, který funguje i offline. Vaši zákazníci si jej mohou přidat na plochu jako aplikaci. Skvělé pro rychlé objednávky, rezervace nebo interní systémy.",
        Price = 12000,
        MonthlyPrice = 1500
    },
    new Solution
    {
        Id = 3,
        Name = "Eshop Basic",
        Description = "Základní e-shop pro menší prodej. Zahrnuje správu produktů, košík, online platby a přehledné objednávky. Vhodné pro začínající prodejce.",
        Price = 18000,
        MonthlyPrice = 1800
    },
    new Solution
    {
        Id = 4,
        Name = "Eshop Plus",
        Description = "Rozšířený e-shop pro rostoucí podnikání. Navíc nabízí fakturaci, přehledy pro účetní, exporty a více uživatelských práv. Vhodné pro firmy, které chtějí růst.",
        Price = 25000,
        MonthlyPrice = 2200
    },
    new Solution
    {
        Id = 5,
        Name = "Rozvozový systém",
        Description = "Kompletní řešení pro rozvoz jídel nebo zboží. Zákazníci objednají online, vy dostanete přehled o objednávkách a trasách. Včetně notifikací a plateb.",
        Price = 29000,
        MonthlyPrice = 2500
    },
    new Solution
    {
        Id = 6,
        Name = "Systém pro fastfoody",
        Description = "Vše, co potřebujete pro rychlý provoz: přehled objednávek, pokladní režim, reporty a možnost tisku účtenek. Ideální pro bistra a fastfoody.",
        Price = 32000,
        MonthlyPrice = 2800
    },
    new Solution
    {
        Id = 7,
        Name = "Systém pro kavárny",
        Description = "Správa menu, rezervace stolů a denní reporty. Jednoduché ovládání pro personál a přehledné rozhraní pro zákazníky. Připraveno pro provoz s obsluhou.",
        Price = 28000,
        MonthlyPrice = 2500
    },
    new Solution
    {
        Id = 8,
        Name = "Portál pro klienty",
        Description = "Umožněte svým zákazníkům přihlásit se, sledovat objednávky, stahovat faktury nebo komunikovat. Vhodné i pro správu dokumentů a firemních služeb.",
        Price = 22000,
        MonthlyPrice = 1900
    },
    new Solution
    {
        Id = 9,
        Name = "Multitenant SaaS",
        Description = "Profesionální systém pro provoz více firem nebo poboček pod jednou aplikací. Každý klient má své vlastní prostředí. Ideální pro B2B platformy nebo franšízy.",
        Price = 38000,
        MonthlyPrice = 3200
    },
    new Solution
    {
        Id = 10,
        Name = "Full Azure PWA",
        Description = "Prémiové řešení s cloudovým hostingem na Azure, offline režimem, zákaznickou dokumentací a prioritní technickou podporou. Vhodné pro náročné projekty a firmy s růstem.",
        Price = 45000,
        MonthlyPrice = 3500
    }
);

        // === SOLUTIONPRODUCT (many-to-many) ===
        builder.Entity<SolutionProduct>().HasData(
            // Jednoduchý web
            new SolutionProduct { SolutionId = 1, ProductId = 1 },
            new SolutionProduct { SolutionId = 1, ProductId = 2 },
            new SolutionProduct { SolutionId = 1, ProductId = 4 },
            new SolutionProduct { SolutionId = 1, ProductId = 14 },
            new SolutionProduct { SolutionId = 1, ProductId = 10 },

            // PWA
            new SolutionProduct { SolutionId = 2, ProductId = 1 },
            new SolutionProduct { SolutionId = 2, ProductId = 2 },
            new SolutionProduct { SolutionId = 2, ProductId = 4 },
            new SolutionProduct { SolutionId = 2, ProductId = 5 },
            new SolutionProduct { SolutionId = 2, ProductId = 12 },
            new SolutionProduct { SolutionId = 2, ProductId = 11 },

            // Eshop Basic
            new SolutionProduct { SolutionId = 3, ProductId = 1 },
            new SolutionProduct { SolutionId = 3, ProductId = 2 },
            new SolutionProduct { SolutionId = 3, ProductId = 3 },
            new SolutionProduct { SolutionId = 3, ProductId = 4 },
            new SolutionProduct { SolutionId = 3, ProductId = 7 },
            new SolutionProduct { SolutionId = 3, ProductId = 10 },

            // Eshop Plus
            new SolutionProduct { SolutionId = 4, ProductId = 1 },
            new SolutionProduct { SolutionId = 4, ProductId = 2 },
            new SolutionProduct { SolutionId = 4, ProductId = 3 },
            new SolutionProduct { SolutionId = 4, ProductId = 4 },
            new SolutionProduct { SolutionId = 4, ProductId = 5 },
            new SolutionProduct { SolutionId = 4, ProductId = 7 },
            new SolutionProduct { SolutionId = 4, ProductId = 20 },
            new SolutionProduct { SolutionId = 4, ProductId = 21 },
            new SolutionProduct { SolutionId = 4, ProductId = 10 },

            // Rozvoz
            new SolutionProduct { SolutionId = 5, ProductId = 1 },
            new SolutionProduct { SolutionId = 5, ProductId = 2 },
            new SolutionProduct { SolutionId = 5, ProductId = 3 },
            new SolutionProduct { SolutionId = 5, ProductId = 4 },
            new SolutionProduct { SolutionId = 5, ProductId = 5 },
            new SolutionProduct { SolutionId = 5, ProductId = 7 },
            new SolutionProduct { SolutionId = 5, ProductId = 17 },
            new SolutionProduct { SolutionId = 5, ProductId = 20 },
            new SolutionProduct { SolutionId = 5, ProductId = 10 },

            // Fastfoody
            new SolutionProduct { SolutionId = 6, ProductId = 1 },
            new SolutionProduct { SolutionId = 6, ProductId = 2 },
            new SolutionProduct { SolutionId = 6, ProductId = 3 },
            new SolutionProduct { SolutionId = 6, ProductId = 4 },
            new SolutionProduct { SolutionId = 6, ProductId = 7 },
            new SolutionProduct { SolutionId = 6, ProductId = 20 },
            new SolutionProduct { SolutionId = 6, ProductId = 21 },
            new SolutionProduct { SolutionId = 6, ProductId = 10 },

            // Kavárny
            new SolutionProduct { SolutionId = 7, ProductId = 1 },
            new SolutionProduct { SolutionId = 7, ProductId = 2 },
            new SolutionProduct { SolutionId = 7, ProductId = 4 },
            new SolutionProduct { SolutionId = 7, ProductId = 5 },
            new SolutionProduct { SolutionId = 7, ProductId = 6 },
            new SolutionProduct { SolutionId = 7, ProductId = 7 },
            new SolutionProduct { SolutionId = 7, ProductId = 20 },
            new SolutionProduct { SolutionId = 7, ProductId = 21 },
            new SolutionProduct { SolutionId = 7, ProductId = 10 },

            // Portál pro klienty
            new SolutionProduct { SolutionId = 8, ProductId = 1 },
            new SolutionProduct { SolutionId = 8, ProductId = 2 },
            new SolutionProduct { SolutionId = 8, ProductId = 4 },
            new SolutionProduct { SolutionId = 8, ProductId = 5 },
            new SolutionProduct { SolutionId = 8, ProductId = 7 },
            new SolutionProduct { SolutionId = 8, ProductId = 8 },
            new SolutionProduct { SolutionId = 8, ProductId = 10 },

            // Multitenant SaaS
            new SolutionProduct { SolutionId = 9, ProductId = 1 },
            new SolutionProduct { SolutionId = 9, ProductId = 2 },
            new SolutionProduct { SolutionId = 9, ProductId = 4 },
            new SolutionProduct { SolutionId = 9, ProductId = 5 },
            new SolutionProduct { SolutionId = 9, ProductId = 7 },
            new SolutionProduct { SolutionId = 9, ProductId = 8 },
            new SolutionProduct { SolutionId = 9, ProductId = 9 },
            new SolutionProduct { SolutionId = 9, ProductId = 10 },

            // Full Azure PWA
            new SolutionProduct { SolutionId = 10, ProductId = 1 },
            new SolutionProduct { SolutionId = 10, ProductId = 2 },
            new SolutionProduct { SolutionId = 10, ProductId = 4 },
            new SolutionProduct { SolutionId = 10, ProductId = 5 },
            new SolutionProduct { SolutionId = 10, ProductId = 7 },
            new SolutionProduct { SolutionId = 10, ProductId = 12 },
            new SolutionProduct { SolutionId = 10, ProductId = 11 },
            new SolutionProduct { SolutionId = 10, ProductId = 13 },
            new SolutionProduct { SolutionId = 10, ProductId = 18 },
            new SolutionProduct { SolutionId = 10, ProductId = 19 },
            new SolutionProduct { SolutionId = 10, ProductId = 15 }
        );
    }
}
