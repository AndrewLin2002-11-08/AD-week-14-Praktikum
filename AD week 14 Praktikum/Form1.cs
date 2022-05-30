using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace AD_week_14_Praktikum
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        MySqlConnection sqlConnect = new MySqlConnection("server=localhost;uid=root;pwd=;database=premier_league");
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlAdapter;
        String sqlQuery;
        DataTable dtPemain = new DataTable();
        DataTable dtPraktikum = new DataTable();
        DataTable dtskorpemain = new DataTable();
        int PosisiSekarang = 0;



        private void Form1_Load(object sender, EventArgs e)
        {
            sqlQuery = "SELECT t.team_id as `ID Tim`, t.team_name as `Nama Tim`, CONCAT(m.manager_name,' ','(',n.nation,')'),CONCAT(home_stadium,',',' ',city,' ','(',capacity,')') FROM team t, manager m, player p, nationality n WHERE t.manager_id = m.manager_id AND m.nationality_id = n.nationality_id";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtPemain);
            IsiDataPemain(0);
            //sqlQuery = "select concat(p.player_name,' ',sum(if(d.`type` = 'GO' or d.`type` ='GP',1, 0)),'(',sum(if(d.`type` ='GP',1, 0)),')')  as 'Top Score' from player p, dmatch d where  p.player_id=d.player_id group by p.player_id order by 1;";
            //sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            //sqlAdapter = new MySqlDataAdapter(sqlCommand);
            //sqlAdapter.Fill(dtPemain);

            IsiDataPemain(0);
        }

        public void IsiDataPemain(int Posisi)
        {
            Lbl_teamname.Text = dtPemain.Rows[Posisi][0].ToString();
            Lbl_manager.Text = dtPemain.Rows[Posisi][2].ToString();
            Lbl_stadium.Text = dtPemain.Rows[Posisi][3].ToString();
            //Lbl_todtskorpemainpscorer.Text = dtskorpemain.Rows[Posisi][0].ToString();
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            IsiDataPemain(0);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_prev_Click(object sender, EventArgs e)
        {

        }

        private void btn_last_Click(object sender, EventArgs e)
        {
            IsiDataPemain(dtPemain.Rows.Count - 1);
        }

        private void Btn_next_Click(object sender, EventArgs e)
        {
           if (PosisiSekarang < dtPemain.Rows.Count - 1)
           {
                PosisiSekarang++;
                IsiDataPemain(PosisiSekarang);
           }
           else
           {
                MessageBox.Show("DATA ERROR!!");
           }
        }

        private void Lbl_topscorer_Click(object sender, EventArgs e)
        {

        }
    }
}
