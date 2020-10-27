using System;

using BIM3DSG_Importer.Authentication;

using ITinnovationsLibrary.Functions;

using BIM3DSG_Importer.Utility;

namespace BIM3DSG_Importer.SelectDB
{
    internal class SelectDBUtility
    {
        public static void SelectDB()
        {
            try
            {
                do
                {
                    SelectDBWindow selw = new SelectDBWindow();

                    if (selw.ShowDialog() == true)
                    {
                        DB.SelectDB_NoOpenConnection(selw.DSN);

                        string name = selw.DSN.Substring(4);

                        AuthenticationUtility.Check(true);
                    }
                } while (!DB.SettedDSN);
            }
            catch (Exception ex)
            {
                Message.ErrorMessage("Unexpected error during DB selection!\n\n" + ex.Message);
            }
        }
    }
}
