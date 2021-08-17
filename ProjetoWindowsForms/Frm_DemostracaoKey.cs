using System;
using System.Windows.Forms;

namespace ProjetoWindowsForms
{
    public partial class Frm_DemostracaoKey : Form
    {
        public Frm_DemostracaoKey()
        {
            InitializeComponent();
        }

        private void Frm_DemostracaoKey_Load(object sender, EventArgs e)
        {

        }

        private void Txt_Input_TextChanged(object sender, EventArgs e)
        {

        }

        private void Btn_Reset_Click(object sender, EventArgs e)
        {
            Txt_Msg.Text = "";
            Txt_Input.Text = "";

            Lbl_Upper.Text = "";
            Lbl_Lower.Text = "";
        }

        private void Txt_Input_KeyDown(object sender, KeyEventArgs e)
        {
            Txt_Msg.AppendText("\r\n" + "Pressionei uma tecla: " + e.KeyCode + "\r\n");
            Txt_Msg.AppendText("\t" + "Código da tecla: " + ((int)e.KeyCode) + "\r\n");
            Txt_Msg.AppendText("\t" + "Nome da tecla: " + e.KeyData + "\r\n");
           

            Lbl_Lower.Text = e.KeyCode.ToString().ToLower();
            Lbl_Upper.Text = e.KeyCode.ToString().ToUpper();
        }
    }
}
