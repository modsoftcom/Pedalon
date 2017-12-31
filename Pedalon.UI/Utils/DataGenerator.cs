using Pedalon.UI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;

namespace Pedalon.UI.Utils
{
    public static class DataGenerator
    {
        static Excel.Application xlApp;
        static Excel.Workbook xlWorkbook;
        static Excel._Worksheet xlWorksheet;
        static Excel.Range xlRange;
        public static void GetMembers(string fname)
        {
            xlApp = new Excel.Application()
            {
                Visible = false
            };

            object oMiss = System.Reflection.Missing.Value;
            xlWorkbook = xlApp.Workbooks.Open(fname, oMiss,
                          oMiss, oMiss,
                          oMiss, oMiss,
                          oMiss, oMiss,
                          oMiss, oMiss,
                          oMiss, oMiss,
                          oMiss, oMiss,
                          oMiss);
            xlWorksheet = xlWorkbook.Sheets[1];
            xlRange = xlWorksheet.UsedRange;

            for (int i = 1; i <= 51; i++)
            {
                try
                {
                    Member member = new Member();
                    if (xlRange.Cells[i, 1] != null && xlRange.Cells[i, 1].Value2 != null)
                        member.Name = xlRange.Cells[i, 1].Value2.ToString();
                    if (xlRange.Cells[i, 2] != null && xlRange.Cells[i, 2].Value2 != null)
                        member.Lastname = xlRange.Cells[i, 2].Value2.ToString();
                    if (xlRange.Cells[i, 3] != null && xlRange.Cells[i, 3].Value2 != null)
                        member.CitizenNumber = xlRange.Cells[i, 3].Value2.ToString();
                    if (xlRange.Cells[i, 4] != null && xlRange.Cells[i, 4].Value2 != null)
                        member.Nationality = xlRange.Cells[i, 4].Value2.ToString();
                    if (xlRange.Cells[i, 5] != null && xlRange.Cells[i, 5].Value2 != null)
                        member.MotherName = xlRange.Cells[i, 5].Value2.ToString();
                    if (xlRange.Cells[i, 6] != null && xlRange.Cells[i, 6].Value2 != null)
                        member.Gender = xlRange.Cells[i, 6].Value2.ToString();
                    if (xlRange.Cells[i, 7] != null && xlRange.Cells[i, 7].Value2 != null)
                        member.Job = xlRange.Cells[i, 7].Value2.ToString();
                    if (xlRange.Cells[i, 8] != null && xlRange.Cells[i, 8].Value2 != null)
                        member.Mail = xlRange.Cells[i, 8].Value2.ToString();
                    if (xlRange.Cells[i, 9] != null && xlRange.Cells[i, 9].Value2 != null)
                        member.Phone = xlRange.Cells[i, 9].Value2.ToString();
                    if (xlRange.Cells[i, 10] != null && xlRange.Cells[i, 10].Value2 != null)
                        member.Address = xlRange.Cells[i, 10].Value2.ToString();
                    Service<Member>.AddOrUpdate(member);
                }
                catch (Exception ex)
                {
                    throw;
                }
            }

            //cleanup
            GC.Collect();
            GC.WaitForPendingFinalizers();

            //rule of thumb for releasing com objects:
            //  never use two dots, all COM objects must be referenced and released individually
            //  ex: [somthing].[something].[something] is bad

            //release com objects to fully kill excel process from running in the background
            Marshal.ReleaseComObject(xlRange);
            Marshal.ReleaseComObject(xlWorksheet);

            //close and release
            xlWorkbook.Close();
            Marshal.ReleaseComObject(xlWorkbook);

            //quit and release
            xlApp.Quit();
            Marshal.ReleaseComObject(xlApp);

            System.Windows.Forms.MessageBox.Show("Üye bilgileri başarıyla aktarıldı","Bilgi");
        }

        public static void GetFees(string fname)
        {
            xlApp = new Excel.Application()
            {
                Visible = false
            };

            object oMiss = System.Reflection.Missing.Value;
            xlWorkbook = xlApp.Workbooks.Open(fname, oMiss,
                          oMiss, oMiss,
                          oMiss, oMiss,
                          oMiss, oMiss,
                          oMiss, oMiss,
                          oMiss, oMiss,
                          oMiss, oMiss,
                          oMiss);
            xlWorksheet = xlWorkbook.Sheets[2];
            xlRange = xlWorksheet.UsedRange;
            List<Member> Members = Service<Member>.SelectAll();
            for (int i = 2; i <= 52; i++)
            {
                if (xlRange.Cells[i, 3] != null && xlRange.Cells[i, 3].Value2 != null)
                {
                    try
                    {
                        Fee fee = new Fee();
                        fee.Member = Members.SingleOrDefault(m => m.Name.Equals(xlRange.Cells[i, 1].Value2.ToString()) && m.Lastname.Equals(xlRange.Cells[i, 2].Value2.ToString()));
                        fee.Type = "Giriş Aidatı";
                        fee.Amount = Convert.ToDecimal(xlRange.Cells[i, 3].Value2.ToString());
                        Service<Fee>.AddOrUpdate(fee);
                    }
                    catch (Exception ex)
                    {

                        throw;
                    }
                }

                for (int j = 4; j < 16; j++)
                {
                    if (xlRange.Cells[i, j] != null && xlRange.Cells[i, j].Value2 != null)
                    {
                        try
                        {
                            Fee fee = new Fee();
                            fee.Member = Members.SingleOrDefault(m => m.Name.Equals(xlRange.Cells[i, 1].Value2.ToString()) && m.Lastname.Equals(xlRange.Cells[i, 2].Value2.ToString()));
                            fee.Type = "Aylık Ödeme";
                            fee.GivenDate = (j + 6) > 12 ? new DateTime(2018, (j + 6) % 12, 1) : new DateTime(2017, j + 6, 1);
                            fee.Amount = Convert.ToDecimal(xlRange.Cells[i, j].Value2.ToString());
                            Service<Fee>.AddOrUpdate(fee);
                        }
                        catch (Exception ex)
                        {

                            throw;
                        }
                    }
                }
            }

            //cleanup
            GC.Collect();
            GC.WaitForPendingFinalizers();

            //rule of thumb for releasing com objects:
            //  never use two dots, all COM objects must be referenced and released individually
            //  ex: [somthing].[something].[something] is bad

            //release com objects to fully kill excel process from running in the background
            Marshal.ReleaseComObject(xlRange);
            Marshal.ReleaseComObject(xlWorksheet);

            //close and release
            xlWorkbook.Close();
            Marshal.ReleaseComObject(xlWorkbook);

            //quit and release
            xlApp.Quit();
            Marshal.ReleaseComObject(xlApp);
            System.Windows.Forms.MessageBox.Show("Üye aidat bilgileri başarıyla aktarıldı", "Bilgi");
        }
    }
}
