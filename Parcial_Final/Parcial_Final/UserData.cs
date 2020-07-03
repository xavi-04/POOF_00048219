using System;
using System.Collections.Generic;
using System.Data;

namespace Parcial_Final
{
    public class UserData
    {
        public static List<Usser> getLista()
        {
            string sql = "select * from APPUSER";

            DataTable dt = ConnectionBD.ExecuteQuery(sql);

            List<Usser> lista = new List<Usser>();
            foreach (DataRow fila in dt.Rows)
            {
                Usser u = new Usser();
                u.IdUser = Convert.ToInt32(fila[0].ToString());
                u.FullName = fila[1].ToString();
                u.UserName = fila[2].ToString();
                u.Password = fila[3].ToString();
                u.UserType = Convert.ToBoolean(fila[4].ToString());


                lista.Add(u);
            }
            return lista;
        }
    }
}