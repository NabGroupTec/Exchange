using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Core.EntityClient;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Controls;
using Exchange.Domain.DataAccess;
using Exchange.Domain.DataAccess.Migrations;
using Janus.Windows.GridEX;
using Janus.Windows.GridEX.Export;
using MetroFramework.Controls;

namespace Exchange.App.Infrastracture
{
    public static class UtilityClass
    {
        public static decimal Bed;
        public static decimal Bes;
        public static int CurrencyCode;
        public static string Currency;
        public static decimal RatePrice;
        public static decimal BedTMN;
        public static decimal BesTMN;
        public static string AccCode;
        public static string AccName;
        public static decimal BuyPrice;
        public static List<string> CurrentUserPermissions = new List<string>();
        public static string ConnectionString { get; set; }
        public static int UserId { get; set; }
        public static string FullName { get; set; }
        public static int AccountCode { get; set; }
        public static string AccountName { get; set; }
        public static int CurrencyId { get; set; }

        public static int CuId { get; set; }
        public static string CuName { get; set; }

        public static int ParentSelectionId { get; set; }

        public static void GetAllControls(Control container)
        {
            foreach (Control c in container.Controls)
            {
                // SetPermissoin(c);
            }
        }

        public static void ShowMessage(Control ctl, string message)
        {
            ToastNotification.Show(ctl, message);
        }

        public static string GetDate()
        {
            var p = new PersianDateTime(DateTime.Now);

            return p.ToString();
        }
        public static string JustGetDate()
        {
            var p = new PersianDateTime(DateTime.Now);

            return p.Date.ToString();
        }
        public static Icon ToIcon(this Image instance)
        {
            using (var bm = (Bitmap) instance)
            {
                return Icon.FromHandle(bm.GetHicon());
            }
        }

        public static byte[] ImageToByteArray(Image imageIn)
        {
            var ms = new MemoryStream();
            imageIn.Save(ms, ImageFormat.Gif);
            return ms.ToArray();
        }

        public static Image ByteArrayToImage(byte[] byteArrayIn)
        {
            var ms = new MemoryStream(byteArrayIn);
            var returnImage = Image.FromStream(ms);
            return returnImage;
        }

        public static void NumberFilter(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                e.KeyChar != '/')
                e.Handled = true;

            if (e.KeyChar == '/' && ((TextBox) sender).Text.IndexOf('/') > -1) e.Handled = true;
        }

        public static void SetPermissoin(List<Control> ctl)
        {
            if (UserId == 1)
                return;
            foreach (var control in ctl)
            {
                if (control is MetroTile)
                    if (control.Tag != null)
                    {
                        control.Enabled = CurrentUserPermissions.Contains(control.Tag);
                        control.ForeColor = Color.DeepSkyBlue;
                    }

                if (control.Tag != null && !(control is MetroTile))
                    control.Visible = CurrentUserPermissions.Contains(control.Tag);

                if (control is DataGridViewX)
                {
                    var grd = (DataGridView) control;

                    foreach (DataGridViewColumn col in grd.Columns)
                        if (!string.IsNullOrEmpty(col.ToolTipText))
                            col.Visible = CurrentUserPermissions.Contains(col.ToolTipText);
                }

                if (control is MetroTabControl)
                    foreach (Control itm in control.Controls)
                        if (itm.Tag != null)
                            foreach (Control evrything in itm.Controls)
                                evrything.Visible = CurrentUserPermissions.Contains(itm.Tag.ToString());
            }
        }

        public static DataTable GetData(string sql)
        {
            var result = new DataSet();

            using (var context = new ExchangeDbContext())
            {
                var cmd = context.Database.Connection.CreateCommand();
                //cmd.CommandType = commandType;
                cmd.CommandText = sql;

                //foreach (var pr in parameters)
                //{
                //    var p = cmd.CreateParameter();
                //    p.ParameterName = pr.Key;
                //    p.Value = pr.Value;
                //    cmd.Parameters.Add(p);
                //}

                try
                {
                    context.Database.Connection.Open();
                    var reader = cmd.ExecuteReader();

                    do
                    {
                        var tb = new DataTable();
                        tb.Load(reader);
                        result.Tables.Add(tb);
                    } while (!reader.IsClosed);
                }
                finally
                {
                    context.Database.Connection.Close();
                }
            }

            return result.Tables[0];
        }

        public static DataTable GetDataLavan(string sql)
        {
            var result = new DataSet();

            using (var context = new LavanDbContext())
            {
                var cmd = context.Database.Connection.CreateCommand();
                //cmd.CommandType = commandType;
                cmd.CommandText = sql;

                //foreach (var pr in parameters)
                //{
                //    var p = cmd.CreateParameter();
                //    p.ParameterName = pr.Key;
                //    p.Value = pr.Value;
                //    cmd.Parameters.Add(p);
                //}

                try
                {
                    context.Database.Connection.Open();
                    var reader = cmd.ExecuteReader();

                    do
                    {
                        var tb = new DataTable();
                        tb.Load(reader);
                        result.Tables.Add(tb);
                    } while (!reader.IsClosed);
                }
                finally
                {
                    context.Database.Connection.Close();
                }
            }

            return result.Tables[0];
        }

        public static void CurrencyFormat(TextBoxX text)
        {
            if (!string.IsNullOrEmpty(text.Text))
            {
                var culture = new CultureInfo("en-US");
                text.Text = text.Text.Replace(".0000", "").Replace(".00", "").Replace(".0", "");
                var valueBefore = double.Parse(text.Text, NumberStyles.AllowThousands);
                text.Text = string.Format(culture, "{0:N0}", valueBefore);
                text.Select(text.Text.Length, 0);
            }
        }

        public static void ExportGridEx(GridEX gridEx, string name)
        {
            Stream sw = null;
            try
            {
                var sd = new SaveFileDialog {Filter = @"Excel File (*.xls)|*.xls|All Files (*.*)|*.*"};
                if (sd.ShowDialog() == DialogResult.OK)
                {
                    //sw = new FileStream(sd.FileName, FileMode.OpenOrCreate, FileAccess.ReadWrite);
                    sw = new FileStream(sd.FileName, FileMode.Create);
                    var grdListExporter = new GridEXExporter();
                    grdListExporter.SheetName = name;
                    grdListExporter.IncludeExcelProcessingInstruction = true;
                    grdListExporter.IncludeFormatStyle = true;
                    grdListExporter.IncludeHeaders = true;
                    grdListExporter.GridEX = gridEx;
                    grdListExporter.Export(sw);
                    MessageBox.Show(@"تهیه فایل با موفقیت انجام شد");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (sw != null)
                {
                    sw.Flush();
                    sw.Close();
                    sw.Dispose();
                }
            }
        }

        public static void ChangeConnection(this DbContext source, string initialCatalog = "", string dataSource = "",
            string userId = "", string password = "", bool integratedSecrity = true,
            string configConnectionStringName = "")
        {
            try
            {
                var configNameEf = string.IsNullOrEmpty(configConnectionStringName)
                    ? source.GetType().Name
                    : configConnectionStringName;

                var entityCnxStringBuilder = new EntityConnectionStringBuilder(ConfigurationManager
                    .ConnectionStrings[configNameEf].ConnectionString);

                var sqlCnxStringBuilder =
                    new SqlConnectionStringBuilder(entityCnxStringBuilder.ProviderConnectionString);

                if (!string.IsNullOrEmpty(initialCatalog))
                    sqlCnxStringBuilder.InitialCatalog = initialCatalog;
                if (!string.IsNullOrEmpty(dataSource))
                    sqlCnxStringBuilder.DataSource = dataSource;
                if (!string.IsNullOrEmpty(userId))
                    sqlCnxStringBuilder.UserID = userId;
                if (!string.IsNullOrEmpty(password))
                    sqlCnxStringBuilder.Password = password;

                sqlCnxStringBuilder.IntegratedSecurity = integratedSecrity;
                source.Database.Connection.ConnectionString = sqlCnxStringBuilder.ConnectionString;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}