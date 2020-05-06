using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using DevComponents.DotNetBar.Metro;
using Exchange.App.Infrastracture;
using Exchange.App.Properties;
using Exchange.Domain.DataAccess;
using Exchange.Domain.Entities;
using Exchange.Domain.Services;

namespace Exchange.App.Pages.Operation
{
    public partial class DocumentOperationPage : MetroForm
    {
        public int VoucherId;

        public DocumentOperationPage()
        {
            ////var culture = Exchange.App.Properties.Settings.Default.Language;
            //Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo(culture);
            InitializeComponent();
        }

        private void DocumentOperationPage_Load(object sender, EventArgs e)
        {
            var formatDate = Settings.Default.FormatDate;
            txtDate.UsePersianFormat = formatDate == "8";
            txtDate.Value = DateTime.Now;
            if (VoucherId != 0) Edit();
        }

        private void Edit()
        {
            using (var dbContext = new UnitOfWork())
            {
                var result = dbContext.VoucherHeaderRepository.Get(p => p.Id == VoucherId);
                foreach (var header in result)
                {
                    txtDate.Text = header.ManualDate;
                    txtDisc.Text = header.Comment;
                    using (var voucher = new VoucherLineRepository())
                    {
                        IEnumerable<VoucherLine> resultLine = voucher.GetVoucherByHead(header.Id);
                        foreach (var item in resultLine)
                        {
                            dgv.Rows.Add();
                            dgv.Rows[dgv.RowCount - 1].Cells["clnId"].Value = item.Id;
                            dgv.Rows[dgv.RowCount - 1].Cells["clnBed"].Value = item.BedPrice;
                            dgv.Rows[dgv.RowCount - 1].Cells["clnBes"].Value = item.BesPrice;
                            dgv.Rows[dgv.RowCount - 1].Cells["clnIdCurrency"].Value = item.CurrencyId;
                            dgv.Rows[dgv.RowCount - 1].Cells["clnRate"].Value = item.RatePrice;
                            dgv.Rows[dgv.RowCount - 1].Cells["clnDisc"].Value = item.Comment;
                            dgv.Rows[dgv.RowCount - 1].Cells["clnBedTMN"].Value = item.BedTMIN;
                            dgv.Rows[dgv.RowCount - 1].Cells["clnBesTMN"].Value = item.BesTMIN;
                            dgv.Rows[dgv.RowCount - 1].Cells["clnAccountSide"].Value = "";
                            dgv.Rows[dgv.RowCount - 1].Cells["clnCode"].Value = item.EntityCode;
                        }
                    }
                }

                using (var db = new UnitOfWork())
                {
                    if (db.VoucherLineRepository != null)
                        if (dgv.CurrentRow != null)
                            foreach (DataGridViewRow row in dgv.Rows)
                            {
                                var code = (int) row.Cells["clnCode"].Value;

                                var entityCapital = db.AccountCapitalRepository.GetById(code);
                                if (entityCapital != null)
                                    row.Cells["clnAccountSide"].Value = entityCapital.Name;

                                var entityBank = db.BankAccountRepository.GetById(code);
                                if (entityBank != null)
                                    row.Cells["clnAccountSide"].Value = entityBank.Name;

                                var entityCash = db.CashDeskRepository.GetById(code);
                                if (entityCash != null)
                                    row.Cells["clnAccountSide"].Value = entityCash.Name;

                                var entityCoins = db.CoinsRepository.GetById(code);
                                if (entityCoins != null)
                                    row.Cells["clnAccountSide"].Value = entityCoins.Name;

                                var entityCost = db.CostRepository.GetById(code);
                                if (entityCost != null)
                                    row.Cells["clnAccountSide"].Value = entityCost.Name;

                                var entityIncome = db.IncomeRepository.GetById(code);
                                if (entityIncome != null)
                                    row.Cells["clnAccountSide"].Value = entityIncome.Name;

                                var entityPeople = db.PeopleRepository.GetById(code);
                                if (entityPeople != null)
                                    row.Cells["clnAccountSide"].Value =
                                        entityPeople.FirstName + " " + entityPeople.LastName;

                                var value = (int) row.Cells["clnIdCurrency"].Value;
                                var resultCurrency = db.CurrencyRepository.GetById(value);
                                if (resultCurrency != null)
                                    row.Cells["clnCurrency"].Value = resultCurrency.Name;
                            }
                }

                GetSumRecords();
            }
        }


        private void btnOk_Click(object sender, EventArgs e)
        {
            if (dgv.Rows.Count > 0)
            {
                if (btnBess.Text != btnBeds.Text)
                {
                    MessageBox.Show("کاربر گرامی مقادیر بدهکاری و بستانکاری بایستی برابر باشند");
                    return;
                }

                if (VoucherId != 0)
                {
                    var voucherLines = (from DataGridViewRow row in dgv.Rows
                        select new VoucherLine
                        {
                            Id = int.Parse(row.Cells["clnId"].Value.ToString()),
                            VoucherHeaderId = VoucherId,
                            EntityCode = int.Parse(row.Cells["clnCode"].Value.ToString()),
                            Comment = row.Cells["clnDisc"].Value == null ? " " : row.Cells["clnDisc"].Value.ToString(),
                            BedPrice = decimal.Parse(row.Cells["clnBed"].Value == null
                                ? "0"
                                : row.Cells["clnBed"].Value.ToString()),
                            BesPrice = decimal.Parse(row.Cells["clnBes"].Value == null
                                ? "0"
                                : row.Cells["clnBes"].Value.ToString()),
                            CurrencyId = int.Parse(row.Cells["clnIdCurrency"].Value.ToString()),
                            RatePrice = decimal.Parse(row.Cells["clnRate"].Value.ToString()),
                            BedTMIN = decimal.Parse(row.Cells["clnBedTMN"].Value == null
                                ? "0"
                                : row.Cells["clnBedTMN"].Value.ToString().ToString()),
                            BesTMIN = decimal.Parse(row.Cells["clnBesTMN"].Value == null
                                ? "0"
                                : row.Cells["clnBesTMN"].Value.ToString().ToString())
                        }).ToList();

                    var voucherHeader = new VoucherHeader
                    {
                        Id = VoucherId,
                        UserId = UtilityClass.UserId,
                        Comment = txtDisc.Text,
                        ManualDate = txtDate.Text,
                        LogRecord = DateTime.Now
                        //VoucherLines = voucherLines
                    };
                    using (var dbContext = new UnitOfWork())
                    {
                        dbContext.VoucherHeaderRepository.Update(voucherHeader);
                        dbContext.VoucherLineRepository.UpdateLine(voucherLines);

                        //foreach (VoucherLine line in voucherLines)
                        //{
                        //    var lines = new VoucherLine()
                        //    {
                        //        Id = line.Id,
                        //        VoucherHeaderId = VoucherId,
                        //        EntityCode = line.EntityCode,
                        //        Comment = line.Comment,
                        //        BedPrice = line.BedPrice,
                        //        BesPrice = line.BesPrice,
                        //        CurrencyId = line.CurrencyId,
                        //        RatePrice = line.RatePrice,
                        //        BedTMIN = line.BedTMIN,
                        //        BesTMIN = line.BesTMIN
                        //    };
                        //}
                        dbContext.Save();


                        DialogResult = DialogResult.OK;
                    }
                }
                else
                {
                    var voucherLines = (from DataGridViewRow row in dgv.Rows
                        select new VoucherLine
                        {
                            EntityCode = int.Parse(row.Cells["clnCode"].Value.ToString()),
                            Comment = row.Cells["clnDisc"].Value == null ? " " : row.Cells["clnDisc"].Value.ToString(),
                            BedPrice = decimal.Parse(row.Cells["clnBed"].Value == null
                                ? "0"
                                : row.Cells["clnBed"].Value.ToString()),
                            BesPrice = decimal.Parse(row.Cells["clnBes"].Value == null
                                ? "0"
                                : row.Cells["clnBes"].Value.ToString()),
                            CurrencyId = int.Parse(row.Cells["clnIdCurrency"].Value.ToString()),
                            RatePrice = decimal.Parse(row.Cells["clnRate"].Value.ToString()),
                            BedTMIN = decimal.Parse(row.Cells["clnBedTMN"].Value == null
                                ? "0"
                                : row.Cells["clnBedTMN"].Value.ToString().ToString()),
                            BesTMIN = decimal.Parse(row.Cells["clnBesTMN"].Value == null
                                ? "0"
                                : row.Cells["clnBesTMN"].Value.ToString().ToString())
                        }).ToList();
                    var voucherHeader = new VoucherHeader
                    {
                        UserId = UtilityClass.UserId,
                        Comment = txtDisc.Text,
                        ManualDate = txtDate.Text,
                        LogRecord = DateTime.Now,
                        VoucherLines = voucherLines
                    };
                    using (var dbContext = new UnitOfWork())
                    {
                        dbContext.VoucherHeaderRepository.Insert(voucherHeader);

                        //dbContext.VoucherLineRepository.Insert(line);
                        dbContext.Save();


                        DialogResult = DialogResult.OK;
                    }
                }
            }
        }


        private void dgv_KeyUp(object sender, KeyEventArgs e)
        {
        }


        private void dgv_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            //txt_dgv = (DataGridViewTextBoxEditingControl) e.Control;
        }

        private void dgv_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void dgv_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == 12)
            {
                using (var page = new GetDataDocumentPage())
                {
                    if (dgv.CurrentRow != null)
                    {
                        UtilityClass.AccCode = dgv.CurrentRow.Cells["clnCode"].Value.ToString();
                        UtilityClass.AccName = dgv.CurrentRow.Cells["clnAccountSide"].Value.ToString();
                        UtilityClass.Bed = Convert.ToDecimal(dgv.CurrentRow.Cells["clnBed"].Value.ToString());
                        UtilityClass.Bes = Convert.ToDecimal(dgv.CurrentRow.Cells["clnBes"].Value.ToString());
                        UtilityClass.CurrencyCode =
                            Convert.ToInt32(dgv.CurrentRow.Cells["clnIdCurrency"].Value.ToString());
                        UtilityClass.RatePrice = Convert.ToDecimal(dgv.CurrentRow.Cells["clnRate"].Value.ToString());
                        UtilityClass.BedTMN = Convert.ToDecimal(dgv.CurrentRow.Cells["clnBedTMN"].Value.ToString());
                        UtilityClass.BesTMN = Convert.ToDecimal(dgv.CurrentRow.Cells["clnBesTMN"].Value.ToString());
                    }

                    page.ShowDialog();
                    if (dgv.CurrentRow != null)
                    {
                        dgv.CurrentRow.Cells["clnBed"].Value = UtilityClass.Bed;
                        dgv.CurrentRow.Cells["clnBes"].Value = UtilityClass.Bes;
                        dgv.CurrentRow.Cells["clnIdCurrency"].Value = UtilityClass.CurrencyCode;
                        dgv.CurrentRow.Cells["clnCurrency"].Value = UtilityClass.Currency;
                        dgv.CurrentRow.Cells["clnRate"].Value = UtilityClass.RatePrice;
                        dgv.CurrentRow.Cells["clnBedTMN"].Value = UtilityClass.BedTMN;
                        dgv.CurrentRow.Cells["clnBesTMN"].Value = UtilityClass.BesTMN;
                        dgv.CurrentRow.Cells["clnAccountSide"].Value = UtilityClass.AccName;
                        dgv.CurrentRow.Cells["clnCode"].Value = UtilityClass.AccCode;
                    }
                }

                GetSumRecords();
            }

            if (e.ColumnIndex == 13)
            {
                if (dgv.CurrentRow != null) dgv.Rows.Remove(dgv.CurrentRow);
                GetSumRecords();
            }
        }

        private void dgv_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.Enter)
            //{
            //    if (dgv.CurrentCell.ColumnIndex == 3)
            //    {
            //        using (GetDataDocumentPage page = new GetDataDocumentPage())
            //        {
            //            page.ShowDialog();

            //            if (dgv.CurrentRow != null)
            //            {
            //                dgv.CurrentRow.Cells["clnBed"].Value = UtilityClass.Bed;
            //                dgv.CurrentRow.Cells["clnBes"].Value = UtilityClass.Bes;
            //                dgv.CurrentRow.Cells["clnIdCurrency"].Value = UtilityClass.CurrencyCode;
            //                dgv.CurrentRow.Cells["clnCurrency"].Value = UtilityClass.Currency;
            //                dgv.CurrentRow.Cells["clnRate"].Value = UtilityClass.RatePrice;
            //                dgv.CurrentRow.Cells["clnBedTMN"].Value = UtilityClass.BedTMN;
            //                dgv.CurrentRow.Cells["clnBesTMN"].Value = UtilityClass.BesTMN;
            //                e.Handled = true;
            //                SendKeys.Send("{Tab}");
            //            }
            //        }
            //    }
            //    else
            //    {
            //        e.Handled = true;
            //        SendKeys.Send("{Tab}");
            //    }
            //}
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (var page = new GetDataDocumentPage())
            {
                ClearCash();
                page.ShowDialog();

                if (!string.IsNullOrEmpty(UtilityClass.AccCode))
                {
                    dgv.Rows.Add();

                    dgv.Rows[dgv.RowCount - 1].Cells["clnBed"].Value = UtilityClass.Bed;
                    dgv.Rows[dgv.RowCount - 1].Cells["clnBes"].Value = UtilityClass.Bes;
                    dgv.Rows[dgv.RowCount - 1].Cells["clnIdCurrency"].Value = UtilityClass.CurrencyCode;
                    dgv.Rows[dgv.RowCount - 1].Cells["clnCurrency"].Value = UtilityClass.Currency;
                    dgv.Rows[dgv.RowCount - 1].Cells["clnRate"].Value = UtilityClass.RatePrice;
                    dgv.Rows[dgv.RowCount - 1].Cells["clnBedTMN"].Value = UtilityClass.BedTMN;
                    dgv.Rows[dgv.RowCount - 1].Cells["clnBesTMN"].Value = UtilityClass.BesTMN;
                    dgv.Rows[dgv.RowCount - 1].Cells["clnAccountSide"].Value = UtilityClass.AccName;
                    dgv.Rows[dgv.RowCount - 1].Cells["clnCode"].Value = UtilityClass.AccCode;
                    ClearCash();
                }

                GetSumRecords();
            }
        }

        private void ClearCash()
        {
            UtilityClass.Bed = 0;
            UtilityClass.Bes = 0;
            UtilityClass.CurrencyCode = 0;
            UtilityClass.Currency = "";
            UtilityClass.RatePrice = 0;
            UtilityClass.BedTMN = 0;
            UtilityClass.BesTMN = 0;
            UtilityClass.AccName = "";
            UtilityClass.AccCode = "";
        }

        private void GetSumRecords()
        {
            double bed = 0;
            double bes = 0;
            foreach (DataGridViewRow dgvRow in dgv.Rows)
                if (dgvRow != null)
                {
                    bed += double.Parse(dgvRow.Cells["clnBedTMN"].Value.ToString());
                    bes += double.Parse(dgvRow.Cells["clnBesTMN"].Value.ToString());
                }

            btnBeds.Text = bed.ToString(CultureInfo.InvariantCulture);
            btnBess.Text = bes.ToString(CultureInfo.InvariantCulture);
        }

        private void txtDate_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                SendKeys.Send("{Tab}");
            }
        }

        private void DocumentOperationPage_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Insert) btnAdd_Click(null, null);
            if (e.KeyCode == Keys.Escape)
                Close();
        }

        private void txtDisc_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{Tab}");
        }
    }
}