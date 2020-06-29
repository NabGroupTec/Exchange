using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Data.Entity.Migrations.Infrastructure;
using System.Linq;
using Exchange.Domain.Entities;
using Exchange.Domain.Infrastructure;

namespace Exchange.Domain.DataAccess.Migrations
{
    public sealed class Configuration : DbMigrationsConfiguration<ExchangeDbContext>
    {
        private UnitOfWork _context = new UnitOfWork();

        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            ContextKey = "Exchange.Domain.DataAccess.ExchangeDbContext";
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(ExchangeDbContext context)
        {
            SeedUser(context);
            SeedBaseInfoGroup(context);
            SeedBaseInfoDetails(context);
            SeedCountry(context);
            SeedCurrency(context);
            SeedSystemPart(context);
            SeedUserAccess(context);
            SeedBank(context);
        }

        private void SeedBank(ExchangeDbContext context)
        {
            //if (!context.UserAccess.Any())
            //{
            //    BankAccount bank = new BankAccount()
            //        { Comment = "", LogRecord = DateTime.Now, UserId = 1,};
            //    context.UserAccess.Add(bank);
            //    context.SaveChanges();
            //}
        }

        private void SeedUserAccess(ExchangeDbContext context)
        {
            if (!context.UserAccess.Any())
            {
                var userAccess = new UserAccess
                    {Comment = "", LogRecord = DateTime.Now, UsersId = 1, SystemPartsId = 1, UserId = 1};
                context.UserAccess.Add(userAccess);
                context.SaveChanges();
            }
        }

        private void SeedSystemPart(ExchangeDbContext context)
        {
            if (!context.SystemParts.Any())
            {
                IList<SystemParts> systemParts = new List<SystemParts>();
                systemParts.Add(new SystemParts
                {
                    Comment = "", LogRecord = DateTime.Now, Name = "SystemPart", Text = "اجزای سیستم", Level = 0,
                    Priority = 1, Status = 1, UserId = 1
                }); //1

                //Header Defines
                systemParts.Add(new SystemParts
                {
                    Comment = "", LogRecord = DateTime.Now, Name = "Defines", Text = "اطلاعات پایه", Level = 1,
                    Priority = 1, Status = 1, UserId = 1
                }); //2
                //Header Operations
                systemParts.Add(new SystemParts
                {
                    Comment = "", LogRecord = DateTime.Now, Name = "Operations", Text = "عملیات", Level = 1,
                    Priority = 1, Status = 1, UserId = 1
                }); //3
                //Header Reports
                systemParts.Add(new SystemParts
                {
                    Comment = "", LogRecord = DateTime.Now, Name = "Reports", Text = "گزارشات", Level = 1, Priority = 1,
                    Status = 1, UserId = 1
                }); //4
                //Header Setting
                systemParts.Add(new SystemParts
                {
                    Comment = "", LogRecord = DateTime.Now, Name = "Setting", Text = "تنظیمات", Level = 1, Priority = 1,
                    Status = 1, UserId = 1
                }); //5

                #region Defines

                //Customers
                systemParts.Add(new SystemParts
                {
                    Comment = "", LogRecord = DateTime.Now, Name = "Customers", Text = "مشتریان", Level = 2,
                    Priority = 1, Status = 1, UserId = 1
                }); //6
                systemParts.Add(new SystemParts
                {
                    Comment = "", LogRecord = DateTime.Now, Name = "AddCustomer", Text = "اضافه کردن مشتری", Level = 6,
                    Priority = 1, Status = 1, UserId = 1
                }); //7
                systemParts.Add(new SystemParts
                {
                    Comment = "", LogRecord = DateTime.Now, Name = "EditCustomer", Text = "ویرایش مشتری", Level = 6,
                    Priority = 1, Status = 1, UserId = 1
                }); //8
                systemParts.Add(new SystemParts
                {
                    Comment = "", LogRecord = DateTime.Now, Name = "DeleteCustomer", Text = "حذف مشتری", Level = 6,
                    Priority = 1, Status = 1, UserId = 1
                }); //9
                systemParts.Add(new SystemParts
                {
                    Comment = "", LogRecord = DateTime.Now, Name = "ListCustomer", Text = "لیست مشتریان", Level = 6,
                    Priority = 1, Status = 1, UserId = 1
                }); //10

                //Currency
                systemParts.Add(new SystemParts
                {
                    Comment = "", LogRecord = DateTime.Now, Name = "Curresies", Text = "مدیریت ارز", Level = 2,
                    Priority = 1, Status = 1, UserId = 1
                }); //11
                systemParts.Add(new SystemParts
                {
                    Comment = "", LogRecord = DateTime.Now, Name = "AddCurrency", Text = "اضافه کردن ارز", Level = 11,
                    Priority = 1, Status = 1, UserId = 1
                }); //12
                systemParts.Add(new SystemParts
                {
                    Comment = "", LogRecord = DateTime.Now, Name = "EditCurrency", Text = "ویرایش ارز", Level = 11,
                    Priority = 1, Status = 1, UserId = 1
                }); //13
                systemParts.Add(new SystemParts
                {
                    Comment = "", LogRecord = DateTime.Now, Name = "DeleteCurrency", Text = "حذف ارز", Level = 11,
                    Priority = 1, Status = 1, UserId = 1
                }); //14
                systemParts.Add(new SystemParts
                {
                    Comment = "", LogRecord = DateTime.Now, Name = "listCurrency", Text = "لیست ارزها", Level = 11,
                    Priority = 1, Status = 1, UserId = 1
                }); //15

                //Bank
                systemParts.Add(new SystemParts
                {
                    Comment = "", LogRecord = DateTime.Now, Name = "Banks", Text = "مدیریت بانک", Level = 2,
                    Priority = 1, Status = 1, UserId = 1
                }); //16
                systemParts.Add(new SystemParts
                {
                    Comment = "", LogRecord = DateTime.Now, Name = "AddBank", Text = "اضافه کردن بانک", Level = 16,
                    Priority = 1, Status = 1, UserId = 1
                }); //17
                systemParts.Add(new SystemParts
                {
                    Comment = "", LogRecord = DateTime.Now, Name = "EditBank", Text = "ویرایش بانک", Level = 16,
                    Priority = 1, Status = 1, UserId = 1
                }); //18
                systemParts.Add(new SystemParts
                {
                    Comment = "", LogRecord = DateTime.Now, Name = "DeleteBank", Text = "حذف بانک", Level = 16,
                    Priority = 1, Status = 1, UserId = 1
                }); //19
                systemParts.Add(new SystemParts
                {
                    Comment = "", LogRecord = DateTime.Now, Name = "ListBank", Text = "لیست بانکها", Level = 16,
                    Priority = 1, Status = 1, UserId = 1
                }); //20

                //Coins
                systemParts.Add(new SystemParts
                {
                    Comment = "", LogRecord = DateTime.Now, Name = "Coins", Text = "مدیریت مسکوکات", Level = 2,
                    Priority = 1, Status = 1, UserId = 1
                }); //21
                systemParts.Add(new SystemParts
                {
                    Comment = "", LogRecord = DateTime.Now, Name = "AddCoin", Text = "اضافه کردن مسکوکات", Level = 21,
                    Priority = 1, Status = 1, UserId = 1
                }); //22
                systemParts.Add(new SystemParts
                {
                    Comment = "", LogRecord = DateTime.Now, Name = "EditCoin", Text = "ویرایش مسکوکات", Level = 21,
                    Priority = 1, Status = 1, UserId = 1
                }); //23
                systemParts.Add(new SystemParts
                {
                    Comment = "", LogRecord = DateTime.Now, Name = "DeleteCoin", Text = "حذف مسکوکات", Level = 21,
                    Priority = 1, Status = 1, UserId = 1
                }); //24
                systemParts.Add(new SystemParts
                {
                    Comment = "", LogRecord = DateTime.Now, Name = "ListCoin", Text = "لیست مسکوکات", Level = 21,
                    Priority = 1, Status = 1, UserId = 1
                }); //25

                //CashDesks
                systemParts.Add(new SystemParts
                {
                    Comment = "", LogRecord = DateTime.Now, Name = "CashDesks", Text = "مدیریت صندوق", Level = 2,
                    Priority = 1, Status = 1, UserId = 1
                }); //26
                systemParts.Add(new SystemParts
                {
                    Comment = "", LogRecord = DateTime.Now, Name = "AddCashDesk", Text = "اضافه کردن صندوق", Level = 26,
                    Priority = 1, Status = 1, UserId = 1
                }); //27
                systemParts.Add(new SystemParts
                {
                    Comment = "", LogRecord = DateTime.Now, Name = "EditCashDesk", Text = "ویرایش صندوق", Level = 26,
                    Priority = 1, Status = 1, UserId = 1
                }); //28
                systemParts.Add(new SystemParts
                {
                    Comment = "", LogRecord = DateTime.Now, Name = "DeleteCashDesk", Text = "حذف صندوق", Level = 26,
                    Priority = 1, Status = 1, UserId = 1
                }); //29
                systemParts.Add(new SystemParts
                {
                    Comment = "", LogRecord = DateTime.Now, Name = "ListCashDesk", Text = "لیست صندوق ها", Level = 26,
                    Priority = 1, Status = 1, UserId = 1
                }); //30

                //Costs
                systemParts.Add(new SystemParts
                {
                    Comment = "", LogRecord = DateTime.Now, Name = "Costs", Text = "مدیریت هزینه", Level = 2,
                    Priority = 1, Status = 1, UserId = 1
                }); //31
                systemParts.Add(new SystemParts
                {
                    Comment = "", LogRecord = DateTime.Now, Name = "AddCost", Text = "اضافه کردن هزینه", Level = 31,
                    Priority = 1, Status = 1, UserId = 1
                }); //32
                systemParts.Add(new SystemParts
                {
                    Comment = "", LogRecord = DateTime.Now, Name = "EditCost", Text = "ویرایش هزینه", Level = 31,
                    Priority = 1, Status = 1, UserId = 1
                }); //33
                systemParts.Add(new SystemParts
                {
                    Comment = "", LogRecord = DateTime.Now, Name = "DeleteCost", Text = "حذف هزینه", Level = 31,
                    Priority = 1, Status = 1, UserId = 1
                }); //34
                systemParts.Add(new SystemParts
                {
                    Comment = "", LogRecord = DateTime.Now, Name = "ListCost", Text = "لیست هزینه ها", Level = 31,
                    Priority = 1, Status = 1, UserId = 1
                }); //35

                //InCome
                systemParts.Add(new SystemParts
                {
                    Comment = "", LogRecord = DateTime.Now, Name = "Incomes", Text = "مدیریت درآمد", Level = 2,
                    Priority = 1, Status = 1, UserId = 1
                }); //36
                systemParts.Add(new SystemParts
                {
                    Comment = "", LogRecord = DateTime.Now, Name = "AddIncome", Text = "اضافه کردن درآمد", Level = 36,
                    Priority = 1, Status = 1, UserId = 1
                }); //37
                systemParts.Add(new SystemParts
                {
                    Comment = "", LogRecord = DateTime.Now, Name = "EditIncome", Text = "ویرایش درآمد", Level = 36,
                    Priority = 1, Status = 1, UserId = 1
                }); //38
                systemParts.Add(new SystemParts
                {
                    Comment = "", LogRecord = DateTime.Now, Name = "DeleteIncome", Text = "حذف درآمد", Level = 36,
                    Priority = 1, Status = 1, UserId = 1
                }); //39
                systemParts.Add(new SystemParts
                {
                    Comment = "", LogRecord = DateTime.Now, Name = "ListIncome", Text = "لیست درآمد ها", Level = 36,
                    Priority = 1, Status = 1, UserId = 1
                }); //40

                //Capital
                systemParts.Add(new SystemParts
                {
                    Comment = "", LogRecord = DateTime.Now, Name = "Capitals", Text = "مدیریت حساب های سرمایه ای",
                    Level = 2, Priority = 1, Status = 1, UserId = 1
                }); //41
                systemParts.Add(new SystemParts
                {
                    Comment = "", LogRecord = DateTime.Now, Name = "AddCapital", Text = "اضافه کردن حساب سرمایه ای",
                    Level = 41, Priority = 1, Status = 1, UserId = 1
                }); //42
                systemParts.Add(new SystemParts
                {
                    Comment = "", LogRecord = DateTime.Now, Name = "EditCapital", Text = "ویرایش حساب سرمایه ای",
                    Level = 41, Priority = 1, Status = 1, UserId = 1
                }); //43
                systemParts.Add(new SystemParts
                {
                    Comment = "", LogRecord = DateTime.Now, Name = "DeleteCapital", Text = "حذف حساب سرمایه ای",
                    Level = 41, Priority = 1, Status = 1, UserId = 1
                }); //44
                systemParts.Add(new SystemParts
                {
                    Comment = "", LogRecord = DateTime.Now, Name = "ListCapital", Text = "لیست حساب های سرمایه ای",
                    Level = 41, Priority = 1, Status = 1, UserId = 1
                }); //45

                //Users
                systemParts.Add(new SystemParts
                {
                    Comment = "", LogRecord = DateTime.Now, Name = "Users", Text = "مدیریت کاربران", Level = 2,
                    Priority = 2, Status = 1, UserId = 1
                }); //46
                systemParts.Add(new SystemParts
                {
                    Comment = "", LogRecord = DateTime.Now, Name = "AddUser", Text = "اضافه کردن کاربر", Level = 46,
                    Priority = 43, Status = 1, UserId = 1
                }); //47
                systemParts.Add(new SystemParts
                {
                    Comment = "", LogRecord = DateTime.Now, Name = "EditUser", Text = "ویرایش کاربر", Level = 46,
                    Priority = 43, Status = 1, UserId = 1
                }); //48
                systemParts.Add(new SystemParts
                {
                    Comment = "", LogRecord = DateTime.Now, Name = "DeleteUser", Text = "حذف کاربر", Level = 46,
                    Priority = 43, Status = 1, UserId = 1
                }); //49
                systemParts.Add(new SystemParts
                {
                    Comment = "", LogRecord = DateTime.Now, Name = "ListUser", Text = "لیست کاربران", Level = 46,
                    Priority = 43, Status = 1, UserId = 1
                }); //50

                //Estates
                systemParts.Add(new SystemParts
                {
                    Comment = "", LogRecord = DateTime.Now, Name = "Estates", Text = "مدیریت اموال", Level = 2,
                    Priority = 2, Status = 1, UserId = 1
                }); //51
                systemParts.Add(new SystemParts
                {
                    Comment = "", LogRecord = DateTime.Now, Name = "AddEstate", Text = "اضافه کردن اموال", Level = 51,
                    Priority = 43, Status = 1, UserId = 1
                }); //52
                systemParts.Add(new SystemParts
                {
                    Comment = "", LogRecord = DateTime.Now, Name = "EditEstate", Text = "ویرایش اموال", Level = 51,
                    Priority = 43, Status = 1, UserId = 1
                }); //53
                systemParts.Add(new SystemParts
                {
                    Comment = "", LogRecord = DateTime.Now, Name = "DeleteEstate", Text = "حذف اموال", Level = 51,
                    Priority = 43, Status = 1, UserId = 1
                }); //54
                systemParts.Add(new SystemParts
                {
                    Comment = "", LogRecord = DateTime.Now, Name = "ListEstate", Text = "لیست اموالها", Level = 51,
                    Priority = 43, Status = 1, UserId = 1
                }); //55

                //Employees
                systemParts.Add(new SystemParts
                {
                    Comment = "", LogRecord = DateTime.Now, Name = "Employees", Text = "مدیریت کارمندان", Level = 2,
                    Priority = 2, Status = 1, UserId = 1
                }); //56
                systemParts.Add(new SystemParts
                {
                    Comment = "", LogRecord = DateTime.Now, Name = "AddEmployee", Text = "اضافه کردن کارمند",
                    Level = 56, Priority = 43, Status = 1, UserId = 1
                }); //57
                systemParts.Add(new SystemParts
                {
                    Comment = "", LogRecord = DateTime.Now, Name = "EditEmployee", Text = "ویرایش کارمند", Level = 56,
                    Priority = 43, Status = 1, UserId = 1
                }); //58
                systemParts.Add(new SystemParts
                {
                    Comment = "", LogRecord = DateTime.Now, Name = "DeleteEmployee", Text = "حذف کارمند", Level = 56,
                    Priority = 43, Status = 1, UserId = 1
                }); //59
                systemParts.Add(new SystemParts
                {
                    Comment = "", LogRecord = DateTime.Now, Name = "ListEmployee", Text = "لیست کارمندان", Level = 56,
                    Priority = 43, Status = 1, UserId = 1
                }); //60

                //Supervisor
                systemParts.Add(new SystemParts
                {
                    Comment = "", LogRecord = DateTime.Now, Name = "Supervisor", Text = "دسترسی تخصصی", Level = 2,
                    Priority = 2, Status = 1, UserId = 1
                }); //61
                systemParts.Add(new SystemParts
                {
                    Comment = "", LogRecord = DateTime.Now, Name = "BaseInfoGroup", Text = "گروه اطلاعات پایه",
                    Level = 61, Priority = 43, Status = 1, UserId = 1
                }); //62
                systemParts.Add(new SystemParts
                {
                    Comment = "", LogRecord = DateTime.Now, Name = "BaseInfo", Text = "اطلاعات پایه", Level = 61,
                    Priority = 43, Status = 1, UserId = 1
                }); //63
                systemParts.Add(new SystemParts
                {
                    Comment = "", LogRecord = DateTime.Now, Name = "Locations", Text = "مناطق", Level = 61,
                    Priority = 43, Status = 1, UserId = 1
                }); //64
                systemParts.Add(new SystemParts
                {
                    Comment = "", LogRecord = DateTime.Now, Name = "SystemParts", Text = "اجزای سیستم", Level = 61,
                    Priority = 43, Status = 1, UserId = 1
                }); //65

                #endregion

                #region Operations

                //Operation
                systemParts.Add(new SystemParts
                {
                    Comment = "", LogRecord = DateTime.Now, Name = "Documents", Text = "مدیریت اسناد", Level = 3,
                    Priority = 2, Status = 1, UserId = 1
                }); //66
                systemParts.Add(new SystemParts
                {
                    Comment = "", LogRecord = DateTime.Now, Name = "AddDocument", Text = "ثبت جدید سند", Level = 66,
                    Priority = 43, Status = 1, UserId = 1
                }); //67
                systemParts.Add(new SystemParts
                {
                    Comment = "", LogRecord = DateTime.Now, Name = "EditDocument", Text = "ویرایش اسناد", Level = 66,
                    Priority = 43, Status = 1, UserId = 1
                }); //68
                systemParts.Add(new SystemParts
                {
                    Comment = "", LogRecord = DateTime.Now, Name = "DeleteDocument", Text = "حذف اسناد", Level = 66,
                    Priority = 43, Status = 1, UserId = 1
                }); //69
                systemParts.Add(new SystemParts
                {
                    Comment = "", LogRecord = DateTime.Now, Name = "ListDocument", Text = "لیست اسناد", Level = 66,
                    Priority = 43, Status = 1, UserId = 1
                }); //70

                #endregion

                #region Reports

                //Reports
                systemParts.Add(new SystemParts
                {
                    Comment = "", LogRecord = DateTime.Now, Name = "ReportMoein", Text = "گزارش معین طرف حساب",
                    Level = 4, Priority = 2, Status = 1, UserId = 1
                }); //71
                systemParts.Add(new SystemParts
                {
                    Comment = "", LogRecord = DateTime.Now, Name = "ReportDaily", Text = "گزارش دفتر روزانه", Level = 4,
                    Priority = 43, Status = 1, UserId = 1
                }); //72
                systemParts.Add(new SystemParts
                {
                    Comment = "", LogRecord = DateTime.Now, Name = "ReportTotal", Text = "گزارش دفتر کل", Level = 4,
                    Priority = 43, Status = 1, UserId = 1
                }); //73

                #endregion

                #region Settings

                //Settings
                systemParts.Add(new SystemParts
                {
                    Comment = "", LogRecord = DateTime.Now, Name = "SystemSetting", Text = "تنظیمات سیستم", Level = 5,
                    Priority = 2, Status = 1, UserId = 1
                }); //74

                #endregion

                //PerlerDocuments
                systemParts.Add(new SystemParts
                {
                    Comment = "", LogRecord = DateTime.Now, Name = "PerlerDocuments", Text = "مدیریت اسناد پرداختنی",
                    Level = 2, Priority = 2, Status = 1, UserId = 1
                }); //75
                systemParts.Add(new SystemParts
                {
                    Comment = "", LogRecord = DateTime.Now, Name = "AddPerlerDocuments",
                    Text = "اضافه کردن اسناد پرداختنی", Level = 75, Priority = 43, Status = 1, UserId = 1
                }); //76
                systemParts.Add(new SystemParts
                {
                    Comment = "", LogRecord = DateTime.Now, Name = "EditPerlerDocuments",
                    Text = "ویرایش اسناد پرداختنی", Level = 75, Priority = 43, Status = 1, UserId = 1
                }); //77
                systemParts.Add(new SystemParts
                {
                    Comment = "", LogRecord = DateTime.Now, Name = "DeletePerlerDocuments", Text = "حذف اسناد پرداختنی",
                    Level = 75, Priority = 43, Status = 1, UserId = 1
                }); //78
                systemParts.Add(new SystemParts
                {
                    Comment = "", LogRecord = DateTime.Now, Name = "ListPerlerDocuments", Text = "لیست اسناد پرداختنی",
                    Level = 75, Priority = 43, Status = 1, UserId = 1
                }); //79

                //ReceivingDocuments
                systemParts.Add(new SystemParts
                {
                    Comment = "", LogRecord = DateTime.Now, Name = "ReceivingDocuments", Text = "مدیریت اسناد دریافتنی",
                    Level = 2, Priority = 2, Status = 1, UserId = 1
                }); //80
                systemParts.Add(new SystemParts
                {
                    Comment = "", LogRecord = DateTime.Now, Name = "AddReceivingDocuments",
                    Text = "اضافه کردن اسناد دریافتنی", Level = 80, Priority = 43, Status = 1, UserId = 1
                }); //81
                systemParts.Add(new SystemParts
                {
                    Comment = "", LogRecord = DateTime.Now, Name = "EditReceivingDocuments",
                    Text = "ویرایش اسناد دریافتنی", Level = 80, Priority = 43, Status = 1, UserId = 1
                }); //82
                systemParts.Add(new SystemParts
                {
                    Comment = "", LogRecord = DateTime.Now, Name = "DeleteReceivingDocuments",
                    Text = "حذف اسناد دریافتنی", Level = 80, Priority = 43, Status = 1, UserId = 1
                }); //83
                systemParts.Add(new SystemParts
                {
                    Comment = "", LogRecord = DateTime.Now, Name = "ListReceivingDocuments",
                    Text = "لیست اسناد دریافتنی", Level = 80, Priority = 43, Status = 1, UserId = 1
                }); //84

                context.SystemParts.AddRange(systemParts);
                context.SaveChanges();
            }
        }

        private void SeedCurrency(ExchangeDbContext context)
        {
            if (!context.Currencies.Any())
            {
                IList<Currency> currencies = new List<Currency>();
                currencies.Add(new Currency
                {
                    Country = "Afghanistan",
                    Comment = "",
                    UserId = 1,
                    Name = "Afghani",
                    LogRecord = DateTime.Now,
                    IsPrimary = false,
                    Status = 1,
                    FloatName = "Plus",
                    NumberDigit = 2,
                    PurchaseRate = 0,
                    SellingRate = 0,
                    Symbol = "",
                    SymbolFloat = "Afghani"
                });

                currencies.Add(new Currency
                {
                    Country = "Afghanistan",
                    Comment = "",
                    UserId = 1,
                    Name = "Afghani",
                    LogRecord = DateTime.Now,
                    IsPrimary = false,
                    Status = 1,
                    FloatName = "Plus",
                    NumberDigit = 2,
                    PurchaseRate = 0,
                    SellingRate = 0,
                    Symbol = "",
                    SymbolFloat = "Afghani"
                });
                currencies.Add(new Currency
                {
                    Country = "Iran",
                    Comment = "",
                    UserId = 1,
                    Name = "Rial",
                    LogRecord = DateTime.Now,
                    IsPrimary = false,
                    Status = 1,
                    FloatName = "Rial",
                    NumberDigit = 0,
                    PurchaseRate = 0,
                    SellingRate = 0,
                    Symbol = "ريال",
                    SymbolFloat = "IRR"
                });
                currencies.Add(new Currency
                {
                    Country = "Iran",
                    Comment = "",
                    UserId = 1,
                    Name = "TMN",
                    LogRecord = DateTime.Now,
                    IsPrimary = false,
                    Status = 1,
                    FloatName = "TMN",
                    NumberDigit = 2,
                    PurchaseRate = 0,
                    SellingRate = 0,
                    Symbol = "",
                    SymbolFloat = "IRR"
                });
                context.Currencies.AddRange(currencies);
                context.SaveChanges();
            }
        }

        private void SeedBaseInfoGroup(ExchangeDbContext context)
        {
            if (!context.BaseInfoGroups.Any())
            {
                IList<BaseInfoGroup> baseInfoGroups = new List<BaseInfoGroup>();
                baseInfoGroups.Add(new BaseInfoGroup
                    {Comment = "", LogRecord = DateTime.Now, Name = "RecordStatus", Text = "وضعیت سند", UserId = 1});
                baseInfoGroups.Add(new BaseInfoGroup
                    {Comment = "", LogRecord = DateTime.Now, Name = "Gender", Text = "جنسیت", UserId = 1});
                baseInfoGroups.Add(new BaseInfoGroup
                    {Comment = "", LogRecord = DateTime.Now, Name = "Language", Text = "زبان", UserId = 1});
                baseInfoGroups.Add(new BaseInfoGroup
                    {Comment = "", LogRecord = DateTime.Now, Name = "FormatDate", Text = "قالب تاریخ", UserId = 1});
                baseInfoGroups.Add(new BaseInfoGroup
                    {Comment = "", LogRecord = DateTime.Now, Name = "Nationality", Text = "ملیت", UserId = 1});
                baseInfoGroups.Add(new BaseInfoGroup
                    {Comment = "", LogRecord = DateTime.Now, Name = "Bank", Text = "بانک", UserId = 1});
                context.BaseInfoGroups.AddRange(baseInfoGroups);
                context.SaveChanges();
            }
        }

        private void SeedBaseInfoDetails(ExchangeDbContext context)
        {
            if (!context.BaseInfoDetails.Any())
            {
                var baseInfoDetails = new List<BaseInfoDetails>
                {
                    new BaseInfoDetails
                    {
                        BaseInfoGroupId = 1, Comment = "", LogRecord = DateTime.Now, Name = "Active", Text = @"فعال",
                        Status = 1, UserId = 1
                    },
                    new BaseInfoDetails
                    {
                        BaseInfoGroupId = 1, Comment = "", LogRecord = DateTime.Now, Name = "DeActive",
                        Text = @"غیرفعال", Status = 1, UserId = 1
                    },
                    new BaseInfoDetails
                    {
                        BaseInfoGroupId = 2, Comment = "", LogRecord = DateTime.Now, Name = "Male", Text = @"مرد",
                        Status = 1, UserId = 1
                    },
                    new BaseInfoDetails
                    {
                        BaseInfoGroupId = 2, Comment = "", LogRecord = DateTime.Now, Name = "FMale", Text = @"رن",
                        Status = 1, UserId = 1
                    },
                    new BaseInfoDetails
                    {
                        BaseInfoGroupId = 3, Comment = "", LogRecord = DateTime.Now, Name = "Persian", Text = @"فارسی",
                        Status = 1, UserId = 1
                    },
                    new BaseInfoDetails
                    {
                        BaseInfoGroupId = 3, Comment = "", LogRecord = DateTime.Now, Name = "Arabic", Text = @"عربی",
                        Status = 1, UserId = 1
                    },
                    new BaseInfoDetails
                    {
                        BaseInfoGroupId = 3, Comment = "", LogRecord = DateTime.Now, Name = "Kurdish", Text = @"کوردی",
                        Status = 1, UserId = 1
                    },
                    new BaseInfoDetails
                    {
                        BaseInfoGroupId = 4, Comment = "", LogRecord = DateTime.Now, Name = "Jalali", Text = @"شمسی",
                        Status = 1, UserId = 1
                    },
                    new BaseInfoDetails
                    {
                        BaseInfoGroupId = 4, Comment = "", LogRecord = DateTime.Now, Name = "Miladi", Text = @"میلادی",
                        Status = 1, UserId = 1
                    },
                    new BaseInfoDetails
                    {
                        BaseInfoGroupId = 5, Comment = "", LogRecord = DateTime.Now, Name = "Iranian", Text = @"ایرانی",
                        Status = 1, UserId = 1
                    },
                    new BaseInfoDetails
                    {
                        BaseInfoGroupId = 5, Comment = "", LogRecord = DateTime.Now, Name = "Iraqian", Text = @"عراقی",
                        Status = 1, UserId = 1
                    },
                    new BaseInfoDetails
                    {
                        BaseInfoGroupId = 6, Comment = "", LogRecord = DateTime.Now, Name = "Mellat", Text = @"ملت",
                        Status = 1, UserId = 1
                    },
                    new BaseInfoDetails
                    {
                        BaseInfoGroupId = 6, Comment = "", LogRecord = DateTime.Now, Name = "Melli", Text = @"ملی",
                        Status = 1, UserId = 1
                    }
                };
                context.BaseInfoDetails.AddRange(baseInfoDetails);
                context.SaveChanges();
            }
        }

        private void SeedCountry(ExchangeDbContext context)
        {
            if (!context.Countries.Any())
            {
                var country = new List<Country>
                {
                    new Country
                    {
                        Iso = "364", Continent = "asia", LogRecord = DateTime.Now, Name = "Iran, Islamic Republic Of",
                        Status = 1, Comment = "ایران", UserId = 1, Code = "0098"
                    },
                    new Country
                    {
                        Iso = "368", Continent = "asia", LogRecord = DateTime.Now, Name = "Iraq", Status = 1,
                        Comment = "عراق", UserId = 1, Code = ""
                    },
                    new Country
                    {
                        Iso = "784", Continent = "asia", LogRecord = DateTime.Now, Name = "United Arab Emirates",
                        Status = 1, Comment = "امارات", UserId = 1, Code = ""
                    },
                    new Country
                    {
                        Iso = "156", Continent = "asia", LogRecord = DateTime.Now, Name = "China", Status = 1,
                        Comment = "چین", UserId = 1, Code = "0098"
                    }
                };
                //var xml = XDocument.Load("C:\\Countries.xml");
                //var countries = xml.Element("countries")
                //    ?.Elements("country")
                //    .Select(x => new Country
                //    {
                //        Iso = x.Attribute("iso")?.Value,
                //        Code = x.Attribute("code")?.Value,
                //        Name = x.Value,
                //        Comment = "",
                //        Continent = x.Attribute("continent")?.Value,
                //        LogRecord = DateTime.Now,
                //        UserId = 1
                //    }).ToArray();
                context.Countries.AddRange(country);
                context.SaveChanges();
            }
        }

        private void SeedUser(ExchangeDbContext context)
        {
            if (!context.Users.Any())
            {
                IList<Users> user = new List<Users>();
                user.Add(new Users
                {
                    UserName = SecurityClass.Encrypt("admin"),
                    Password = SecurityClass.Encrypt("1"),
                    FullName = "Administrator",
                    Tell = null,
                    Mobile = null,
                    Address = null,
                    Comment = "",
                    LogRecord = DateTime.Now,
                    UserId = 1
                });
                context.Users.AddRange(user);
                context.SaveChanges();
            }
        }
    }
}