using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsApp1
{
    class ConDatabase
    {
        MySqlConnection con;
        MySqlCommand cm;
        public string Conn { get; set; } = "server=121.36.57.112;Uid=customer;password=Summer2020;Database=summer2020";

        public MySqlCommand OpenDatabase(string inquerystring="")
        {
            //连接数据库并配置查询语句
            con = new MySqlConnection(Conn);
            if(con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
                
                //cm = new MySqlCommand(inquerystring, con);
                
            }
            return cm = new MySqlCommand(inquerystring, con);
        }
        public MySqlConnection getCon()
        {
            //返回连接
            return con;
        }
    }
}
