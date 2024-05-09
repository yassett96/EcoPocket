using EcoPocket.Data;
using Microsoft.EntityFrameworkCore;

namespace EcoPocket
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();                        
            InitializeDatabase();
            MainPage = new MainPage();
        }

        /// <summary>
        /// Init data base
        /// </summary>
        /// <returns>Instance EcoPocketDbContextBase</returns>
        private void InitializeDatabase()
        {
            using (var db = new EcoPocketDbContextBase())
            {
                // DISABLE LATER, ONLY WHEN NEED RE CREATE DATA BASE AND VALORS INICIALS
                //EliminateDataBaseOnlyIsNecessary(db);

                // Ensure the database is created
                db.Database.EnsureCreated();

                //if (!db.IncomeCategory.Any())
                //{
                //    //db.Database.Migrate();
                //    InitializeMockInsertInitialRegisters(db);
                //}                    
            }
        }

        /// <summary>
        /// WARNING !!!!, use only if is necessary
        /// </summary>
        /// <param name="vpDataBasePath"></param>
        /// <param name="vpEcoPocketDbContext"></param>
        private void EliminateDataBaseOnlyIsNecessary(EcoPocketDbContextBase vpEcoPocketDbContext)
        {
            string vlDataBasePath = EcoPocket.Utility.DbConnection.GetRoute("EcoPocketDB.db");

            if (File.Exists(vlDataBasePath))
            {
                File.Delete(vlDataBasePath);
            }
        }

        /// <summary>
        /// To create firsts registers in data base. (USE ONLY ONCE)
        /// </summary>
        private void InitializeMockInsertInitialRegisters(EcoPocketDbContextBase vpEcoPocketDbContextBase)
        {
            // Inserting initial data

            // IncomeCategory
            var vlCategory1 = new Models.IncomeCategory
            {
                Icon = [],
                Name = "Primer_Icono_Prueba"
            };
            vpEcoPocketDbContextBase.IncomeCategory.Add(vlCategory1);

            var vlCategory2 = new Models.IncomeCategory
            {
                Icon = [],
                Name = "segundo_Icono_Prueba"
            };
            vpEcoPocketDbContextBase.IncomeCategory.Add(vlCategory2);

            // Account
            var vlAccount1 = new Models.Account
            {
                Description = "Banco"
            };
            vpEcoPocketDbContextBase.Account.Add(vlAccount1);

            var vlAccount2 = new Models.Account
            {
                Description = "Billetera"
            };
            vpEcoPocketDbContextBase.Account.Add(vlAccount2);

            vpEcoPocketDbContextBase.SaveChanges();

            // Income
            vpEcoPocketDbContextBase.Income.Add(new Models.Income
            {
                Amount = 3500.00m,
                Date = DateTime.Now,
                Description = "Negocio propio",
                ID_Income_Category = vlCategory1.ID_Income_Category,
                ID_Account = vlAccount1.ID_Account,

                // May be changed or removed the use the complete object, depends if the load of application is slow
                Account = vlAccount1,
                IncomeCategory = vlCategory1
                /////////////////////////////////////
            });

            vpEcoPocketDbContextBase.SaveChanges();

            // ExpenseCategory
            var vlExpenseCategory1 = new Models.ExpenseCategory
            {
                Icon = [],
                Name = "Alimento"
            };
            vpEcoPocketDbContextBase.ExpenseCategory.Add(vlExpenseCategory1);

            var vlExpenseCategory2 = new Models.ExpenseCategory
            {
                Icon = [],
                Name = "Regalo"
            };
            vpEcoPocketDbContextBase.ExpenseCategory.Add(vlExpenseCategory2);

            vpEcoPocketDbContextBase.SaveChanges();

            // PaymentMethod
            var vlPaymentMethod1 = new Models.PaymentMethod
            {
                Description = "Tarjeta crédito",
                Icon = []
            };
            vpEcoPocketDbContextBase.PaymentMethod.Add(vlPaymentMethod1);

            var vlPaymentMethod2 = new Models.PaymentMethod
            {
                Description = "Tarjeta débito",
                Icon = []
            };
            vpEcoPocketDbContextBase.PaymentMethod.Add(vlPaymentMethod2);

            // Expense
            vpEcoPocketDbContextBase.Expense.Add(new Models.Expense {
                Amount = 1200.00m,
                Date = DateTime.Now,
                Description = "Pago de la comida",
                ID_Expense_Category = vlExpenseCategory1.ID_Expense_Category,
                ID_Payment_Method = vlPaymentMethod1.ID_Payment_Method,

                // May be changed or removed the use the complete object, depends if the load of application is slow
                ExpenseCategory = vlExpenseCategory1,
                PaymentMethod = vlPaymentMethod1
                /////////////////////////////////////
            });

            vpEcoPocketDbContextBase.SaveChanges();

        }
    }
}
