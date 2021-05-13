using Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Runtime.Serialization;
using System.Xml;
using System.Xml.Serialization;

namespace Storage
{
    public static class UserStorage
    {
        public static List<UserEntity> userEntities = new List<UserEntity>();

        public static void Save()
        {
            try
            {
                DataSet ds = new DataSet();
                DataTable dt = new DataTable(); 
                dt.TableName = "User"; 
                dt.Columns.Add("Name"); 
                dt.Columns.Add("Age");
                dt.Columns.Add("Email");
                dt.Columns.Add("Password");
                ds.Tables.Add(dt); 

                foreach (var user in userEntities) 
                {
                    DataRow row = ds.Tables["User"].NewRow(); 
                    row["Name"] = user.Name;
                    row["Age"] = user.Age;
                    row["Email"] = user.Identity.Email;
                    row["Password"] = user.Identity.Password;
                    ds.Tables["User"].Rows.Add(row);
                }
                ds.WriteXml("Data.xml");
            }
            catch
            {
            }
        }
        public static void Read()
        {
            if (File.Exists("Data.xml")) 
            {
                DataSet ds = new DataSet();
                ds.ReadXml("Data.xml");

                foreach (DataRow item in ds.Tables["User"].Rows)
                {
                    userEntities.Add(new UserEntity
                    {
                        Name = item["Name"].ToString(),
                        Age = Convert.ToInt32(item["Age"]),
                        Identity = new IdentityTokenEntity {Email= item["Email"].ToString(), Password = item["Password"].ToString() }
                    });
                }
            }
        }
    }
}
