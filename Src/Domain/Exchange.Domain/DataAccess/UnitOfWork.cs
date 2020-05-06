using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Exchange.Domain.Entities;
using Exchange.Domain.Services;

namespace Exchange.Domain.DataAccess
{
    public class UnitOfWork : IDisposable
    {
        private readonly ExchangeDbContext _db = new ExchangeDbContext();
        private GenericRepository<AccountCapital> _accountCapital;
        private GenericRepository<BankAccount> _bankAccount;
        private GenericRepository<BaseInfoDetails> _baseInfoDetailsRepository;
        private GenericRepository<BaseInfoGroup> _baseInfoGroupRepository;
        private GenericRepository<CashDesk> _cashDesk;
        private GenericRepository<Coins> _coin;
        private GenericRepository<Cost> _cost;
        private GenericRepository<Country> _countryRepository;
        private GenericRepository<Currency> _currency;
        private GenericRepository<Employee> _employee;
        private GenericRepository<Estate> _estate;
        private GenericRepository<Income> _income;
        private GenericRepository<People> _people;
        private GenericRepository<PerlerDocuments> _perleRepository;
        private GenericRepository<ReceivingDocuments> _recevingRepository;
        private GenericRepository<SystemParts> _systemParts;
        private GenericRepository<Users> _user;
        private GenericRepository<UserAccess> _userAccess;
        private GenericRepository<VoucherHeader> _voucherHeader;
        private GenericRepository<IEnumerable<VoucherLine>> _voucherLine;
        private GenericRepository<VoucherLine> _voucherLineFilter;

        public GenericRepository<Country> CountryRepository =>
            _countryRepository ?? (_countryRepository = new GenericRepository<Country>(_db));

        public GenericRepository<BaseInfoGroup> BaseInfoGroupRepository =>
            _baseInfoGroupRepository ?? (_baseInfoGroupRepository = new GenericRepository<BaseInfoGroup>(_db));

        public GenericRepository<BaseInfoDetails> BaseInfoDetailsRepository =>
            _baseInfoDetailsRepository ?? (_baseInfoDetailsRepository = new GenericRepository<BaseInfoDetails>(_db));

        public GenericRepository<Currency> CurrencyRepository =>
            _currency ?? (_currency = new GenericRepository<Currency>(_db));

        public GenericRepository<Users> UserRepository =>
            _user ?? (_user = new GenericRepository<Users>(_db));

        public GenericRepository<People> PeopleRepository =>
            _people ?? (_people = new GenericRepository<People>(_db));

        public GenericRepository<BankAccount> BankAccountRepository =>
            _bankAccount ?? (_bankAccount = new GenericRepository<BankAccount>(_db));

        public GenericRepository<CashDesk> CashDeskRepository =>
            _cashDesk ?? (_cashDesk = new GenericRepository<CashDesk>(_db));

        public GenericRepository<Cost> CostRepository =>
            _cost ?? (_cost = new GenericRepository<Cost>(_db));

        public GenericRepository<Income> IncomeRepository =>
            _income ?? (_income = new GenericRepository<Income>(_db));

        public GenericRepository<Coins> CoinsRepository =>
            _coin ?? (_coin = new GenericRepository<Coins>(_db));

        public GenericRepository<AccountCapital> AccountCapitalRepository =>
            _accountCapital ?? (_accountCapital = new GenericRepository<AccountCapital>(_db));

        public GenericRepository<VoucherHeader> VoucherHeaderRepository =>
            _voucherHeader ?? (_voucherHeader = new GenericRepository<VoucherHeader>(_db));

        public GenericRepository<IEnumerable<VoucherLine>> VoucherLineRepository =>
            _voucherLine ?? (_voucherLine = new GenericRepository<IEnumerable<VoucherLine>>(_db));

        public GenericRepository<VoucherLine> VoucherLineRepositoryFilter =>
            _voucherLineFilter ?? (_voucherLineFilter = new GenericRepository<VoucherLine>(_db));

        public GenericRepository<UserAccess> UserAccessRepository =>
            _userAccess ?? (_userAccess = new GenericRepository<UserAccess>(_db));

        public GenericRepository<SystemParts> SystemPartsRepository =>
            _systemParts ?? (_systemParts = new GenericRepository<SystemParts>(_db));

        public GenericRepository<Employee> EmployeeRepository =>
            _employee ?? (_employee = new GenericRepository<Employee>(_db));

        public GenericRepository<Estate> EstateRepository =>
            _estate ?? (_estate = new GenericRepository<Estate>(_db));

        public GenericRepository<PerlerDocuments> PerlerDocumentsRepository =>
            _perleRepository ?? (_perleRepository = new GenericRepository<PerlerDocuments>(_db));

        public GenericRepository<ReceivingDocuments> ReceivingDocumentsRepository =>
            _recevingRepository ?? (_recevingRepository = new GenericRepository<ReceivingDocuments>(_db));

        public void Dispose()
        {
            _db.Dispose();
        }

        public void Seed()
        {
            if (!_db.People.Any())
                _db.Database.ExecuteSqlCommand("DBCC CHECKIDENT ('People', RESEED, 10000)");

            if (!_db.CashDesks.Any())
                _db.Database.ExecuteSqlCommand("DBCC CHECKIDENT ('CashDesks', RESEED, 20000)");

            if (!_db.BankAccounts.Any())
                _db.Database.ExecuteSqlCommand("DBCC CHECKIDENT ('BankAccounts', RESEED, 30000)");


            if (!_db.AccountCapitals.Any())
                _db.Database.ExecuteSqlCommand("DBCC CHECKIDENT ('AccountCapitals', RESEED, 40000)");


            if (!_db.Coins.Any())
                _db.Database.ExecuteSqlCommand("DBCC CHECKIDENT ('Coins', RESEED, 50000)");


            if (!_db.Costs.Any())
                _db.Database.ExecuteSqlCommand("DBCC CHECKIDENT ('Costs', RESEED, 60000)");


            if (!_db.Incomes.Any())
                _db.Database.ExecuteSqlCommand("DBCC CHECKIDENT ('Incomes', RESEED, 70000)");

            if (!_db.Employees.Any())
                _db.Database.ExecuteSqlCommand("DBCC CHECKIDENT ('Employees', RESEED, 80000)");

            if (!_db.Estates.Any())
                _db.Database.ExecuteSqlCommand("DBCC CHECKIDENT ('Estates', RESEED, 90000)");

            if (!_db.PerlerDocuments.Any())
                _db.Database.ExecuteSqlCommand("DBCC CHECKIDENT ('PerlerDocuments', RESEED, 100000)");

            if (!_db.ReceivingDocuments.Any())
                _db.Database.ExecuteSqlCommand("DBCC CHECKIDENT ('ReceivingDocuments', RESEED, 110000)");

            _db.SaveChanges();
        }

        public void Save()
        {
            try
            {
                _db.SaveChanges();
            }
            catch (Exception exception)
            {
                MessageBox.Show("کاربر گرامی امکان حذف این رکورد وجود ندارد");
            }
        }
    }
}