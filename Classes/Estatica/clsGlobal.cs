using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Collections;
using System.Collections.Generic;
/*using System.Runtime;
using System.Globalization;*/
using System.Xml.Serialization;
using System.Xml;
using System.Globalization;

//=======================================================================================================
namespace CasaMendes.Classes.Estatica
{
    //====================================================================================================
    public class clsGlobal //Início da classe clsGlobal.
    {
        
        //====================================================================================================
        private static OpenFileDialog fDialogo;

        //====================================================================================================
        //private static int LinhasPromocao = 0;

        //====================================================================================================
        public static int CodigoVenda { get; set; }

        //====================================================================================================
        public static string TagForm { get; set; }
        
        //====================================================================================================
        public static decimal DeStringParadecimal(string sValor)
        {
           if(sValor != string.Empty) return Convert.ToDecimal(sValor);
            else return 0;
        }

        //===================================================================================================
        public static void CarregarEstados(ComboBox cb)
        {
            string SiglasDeEstados = "ACALAPBACEDFESGOMAMTMSMGPAPBPRPEPIRJRNRSRORRSCSPSETO";
            cb.Items.Clear();
            int tamanho = (SiglasDeEstados.Length - 1);
            for (int i = 0; i < tamanho; i += 2)
            {
                cb.Items.Add(SiglasDeEstados.Substring(i, 2));
            }
        }

        //====================================================================================================
        public static void Abririmagens(PictureBox PicFoto)
        {
            fDialogo = new OpenFileDialog();
            fDialogo.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            // Set the file dialog to filter for graphics files.
            fDialogo.Filter = "imagens (*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF| All files (*.*)|*.*";
            // Allow the user to select multiple imagens.
            fDialogo.Multiselect = true;
            fDialogo.Title = Application.ProductName;
            DialogResult dialogResult = fDialogo.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                PicFoto.Image = Image.FromFile(fDialogo.FileName);
            }
            else
            {
                //PicFoto.Image = Image.FromFile(clsGlobal.ValidarDiretorio(clsGlobal.sCaminho, @"\CasaMendes.jpg"));
                PicFoto.Image = Properties.Resources.CasaMendes1Jpg; //Image.FromFile(clsGlobal.ValidarDiretorio();
            }

            fDialogo.Dispose();
        }

        /*
         * ====================================================================================================
         * Lista de países do mundo
         * Abaixo há uma lista de países que podem ser copiados e colados em uma questão, como um menu suspenso.
         */
        public static void CarregarPaises(ComboBox cb)
        {
            cb.Items.Clear();
            string[] Paises =
            {"AD - Andorra"
            ,"AE - Emirados Árabes Unidos"
            ,"AF - Afeganistão"
            ,"AG - Antígua e Barbuda"
            ,"AI - Anguilla"
            ,"AL - Albânia"
            ,"AM - Armênia"
            ,"AO - Angola"
            ,"AQ - Antártica"
            ,"AR - Argentina"
            ,"AS - Samoa Americana"
            ,"AT - Áustria"
            ,"AU - Austrália"
            ,"AW - Aruba"
            ,"AZ - Azerbaijão"
            ,"BA - Bósnia e Herzegovina"
            ,"BB - Barbados"
            ,"BD - Bangladesh"
            ,"BE - Bélgica"
            ,"BF - Burkina Faso"
            ,"BG - Bulgária"
            ,"BH - Barém"
            ,"BI - Burundi"
            ,"BJ - Benin"
            ,"BL - São Bartolomeu"
            ,"BM - Bermuda"
            ,"BN - Brunei"
            ,"BO - Bolívia"
            ,"BR - Brasil"
            ,"BS - Bahamas"
            ,"BT - Butão"
            ,"BV - Ilha Bouvet"
            ,"BW - Botswana"
            ,"BY - Belarus"
            ,"BZ - Belize"
            ,"CA - Canadá"
            ,"CC - Ilhas Cocos(Keeling)"
            ,"CD - Congo, República Democrática"
            ,"CF - República Centro-Africana"
            ,"CG - Congo, República do"
            ,"CH - Suíça"
            ,"CI - Costa do Marfim"
            ,"CK - Ilhas Cook"
            ,"CL - Chile"
            ,"CM - Camarões"
            ,"CN - China"
            ,"CO - Colômbia"
            ,"CR - Costa Rica"
            ,"CU - Cuba"
            ,"CV - Cabo Verde"
            ,"CW - Curaçao"
            ,"CX - Ilha Christmas"
            ,"CY - Chipre"
            ,"CZ - República Tcheca"
            ,"DE - Alemanha"
            ,"DJ - Djibuti"
            ,"DK - Dinamarca"
            ,"DM - Dominica"
            ,"DO - República Dominicana"
            ,"DZ - Argélia"
            ,"EC - Equador"
            ,"EE - Estônia"
            ,"EG - Egito"
            ,"EH - Saara Ocidental"
            ,"ER - Eritréia"
            ,"ES - Espanha"
            ,"ET - Etiópia"
            ,"FI - Finlândia"
            ,"FJ - Fiji"
            ,"FK - Ilhas Falkland(Malvinas)"
            ,"FM - Micronésia, Estados Federados da"
            ,"FO - Ilhas Feroe"
            ,"FR - França"
            ,"FX - França Metropolitana"
            ,"GA - Gabão"
            ,"GB - Reino Unido"
            ,"GD - Grenada"
            ,"GE - Geórgia"
            ,"GF - Guiana Francesa"
            ,"GG - Guernsey"
            ,"GH - Gana"
            ,"GI - Gibraltar"
            ,"GL - Greenland"
            ,"GM - Gâmbia"
            ,"GN - Guiné"
            ,"GP - Guadelupe"
            ,"GQ - Guiné Equatorial"
            ,"GR - Grécia"
            ,"GS - Geórgia do Sul e Ilhas"
            ,"GT - Guatemala"
            ,"GU - Guam"
            ,"GW - Guiné-Bissau"
            ,"GY - Guiana"
            ,"HK - Hong Kong"
            ,"HM - Ilhas Heard and McDonald"
            ,"HN - Honduras"
            ,"HR - Croácia"
            ,"HT - Haiti"
            ,"HU - Hungria"
            ,"ID - Indonésia"
            ,"IE - Irlanda"
            ,"IL - Israel"
            ,"IM - Ilha de Man"
            ,"IN - Índia"
            ,"IO - Território Britânico do Oceano Índico"
            ,"IQ - Iraque"
            ,"IR - Irã"
            ,"IS - Islândia"
            ,"IT - Itália"
            ,"JE - Jersey"
            ,"JM - Jamaica"
            ,"JO - Jordânia"
            ,"JP - Japão"
            ,"KE - Quênia"
            ,"KG - Quirguistão"
            ,"KH - Camboja"
            ,"KI - Kiribati"
            ,"KM - Cômoros"
            ,"KN - São Cristóvão e Nevis"
            ,"KP - Coreia do Norte"
            ,"KR - Coreia do Sul"
            ,"KW - Kuwait"
            ,"KY - Ilhas Caiman"
            ,"KZ - Cazaquistão"
            ,"LA - Laos"
            ,"LB - Líbano"
            ,"LC - Santa Lúcia"
            ,"LI - Liechtenstein"
            ,"LK - Sri Lanka"
            ,"LR - Libéria"
            ,"LS - Lesoto"
            ,"LT - Lituânia"
            ,"LU - Luxemburgo"
            ,"LV - Letônia"
            ,"LY - Líbia"
            ,"MA - Marrocos"
            ,"MC - Mônaco"
            ,"MD - Moldova"
            ,"ME - Montenegro"
            ,"MF - Saint Martin"
            ,"MG - Madagascar"
            ,"MH - Ilhas Marshall"
            ,"MK - Macedônia"
            ,"ML - Mali"
            ,"MM - Birmânia"
            ,"MN - Mongólia"
            ,"MO - Macao"
            ,"MP - Ilhas Marianas do Norte"
            ,"MQ - Martinica"
            ,"MR - Mauritânia"
            ,"MS - Montserrat"
            ,"MT - Malta"
            ,"mu – Ilhas Maurício"
            ,"MV - Maldivas"
            ,"MW - Malawi"
            ,"MX - México"
            ,"MY - Malásia"
            ,"MZ - Moçambique"
            ,"NA - Namíbia"
            ,"NC - Nova Caledônia"
            ,"NE - Níger"
            ,"NF - Ilha Norfolk"
            ,"NG - Nigéria"
            ,"NI - Nicarágua"
            ,"NL - Holanda"
            ,"NO - Noruega"
            ,"NP - Nepal"
            ,"NR - Nauru"
            ,"NU - Niue"
            ,"NZ - Nova Zelândia"
            ,"OM - Omã"
            ,"PA - Panamá"
            ,"PE - Peru"
            ,"PF - Polinésia Francesa"
            ,"PG - Papua Nova Guiné"
            ,"PH - Filipinas"
            ,"PK - Paquistão"
            ,"PL - Polônia"
            ,"PM - Saint Pierre e Miquelon"
            ,"PN - Ilhas Pitcairn"
            ,"PR - Porto Rico"
            ,"PS - Faixa de Gaza"
            ,"PS - Cisjordânia"
            ,"PT - Portugal"
            ,"PW - Palau"
            ,"PY - Paraguai"
            ,"QA - Qatar"
            ,"RE - Reunião"
            ,"RO - Romênia"
            ,"RS - Sérvia"
            ,"RU - Rússia"
            ,"RW - Ruanda"
            ,"SA - Arábia Saudita"
            ,"SB - Ilhas Salomão"
            ,"SC - Seicheles"
            ,"SD - Sudão"
            ,"SE - Suécia"
            ,"SG - Cingapura"
            ,"SH - Santa Helena, Ascensão e Tristão da Cunha"
            ,"SI - Eslovênia"
            ,"SJ - Svalbard"
            ,"SK - Eslováquia"
            ,"SL - Serra Leoa"
            ,"SM - San Marino"
            ,"SN - Senegal"
            ,"SO - Somália"
            ,"SR - Suriname"
            ,"SS - Sudão do Sul"
            ,"ST - São Tomé e Príncipe"
            ,"SV - El Salvador"
            ,"SX - São Martinho"
            ,"SY - Síria"
            ,"SZ - Suazilândia"
            ,"TC - Ilhas Turks e Caicos"
            ,"TD - Chad"
            ,"TF - Sul da França e Antártica"
            ,"TG - Togo"
            ,"TH - Tailândia"
            ,"TJ - Tadjiquistão"
            ,"TK - Toquelau"
            ,"TL - Timor-Leste"
            ,"TM - Turcomenistão"
            ,"TN - Tunísia"
            ,"TO - Tonga"
            ,"TR - Turquia"
            ,"TT - Trinidad e Tobago"
            ,"TV - Tuvalu"
            ,"TW - Taiwan"
            ,"TZ - Tanzânia"
            ,"UA - Ucrânia"
            ,"UG - Uganda"
            ,"UM - Ilhas Menores Distantes dos Estados Unidos"
            ,"US - Estados Unidos"
            ,"UY - Uruguai"
            ,"UZ - Uzbequistão"
            ,"VA - Santa Sé(Cidade do Vaticano)"
            ,"VC - São Vicente e Granadinas"
            ,"VE - Venezuela"
            ,"VG - Ilhas Virgens Britânicas"
            ,"VI - Ilhas Virgens Americanas"
            ,"VN - Vietnã"
            ,"VU - Vanuatu"
            ,"WF - Ilhas Wallis e Futuna"
            ,"WS - Samoa"
            ,"XK - Kosovo"
            ,"YE - Iêmen"
            ,"YT - Maiote"
            ,"ZA - África do Sul"
            ,"ZM - Zâmbia"
            ,"ZW - Zimbábue"};

            foreach (string p in Paises)
            {
                cb.Items.Add(p);
            }

        }

        //===============================================================================================
        public static string sCaminho = Application.StartupPath;
        public static string ValidarDiretorio(string pDiretorio = "", string pArquivo = "")
        {
            if (pDiretorio == null) { return (null); }
            string sDir = pDiretorio.Substring(pDiretorio.Length - 1, 1);
            if (sDir == @"\")
            { sDir = string.Concat(pDiretorio, pArquivo); }
            else
            { sDir = string.Concat(pDiretorio, @"\", pArquivo); }
            return sDir.ToString();
        }

        //===============================================================================================
        public static void LimparControles(Control.ControlCollection c)
        {
            try
            {
                foreach (Control control in c)
                {
                    if (control.HasChildren)
                    {
                        //LimparControles(control.Controls);
                    }
                    else
                    {
                        if (control is TextBox)
                        {
                            TextBox txt = (TextBox)control;
                            txt.Clear();
                        }
                        if (control is ComboBox)
                        {
                            ComboBox cmb = (ComboBox)control;
                            if (cmb.Items.Count > 0)
                                cmb.Items.Clear();
                            cmb.Text = null;
                        }

                        if (control is CheckBox)
                        {
                            CheckBox chk = (CheckBox)control;
                            chk.Checked = false;
                        }

                        if (control is RadioButton)
                        {
                            RadioButton rdo = (RadioButton)control;
                            rdo.Checked = false;
                        }

                        if (control is ListBox)
                        {
                            ListBox listBox = (ListBox)control;
                            listBox.ClearSelected();
                        }

                        if (control is MaskedTextBox)
                        {
                            MaskedTextBox MtB = (MaskedTextBox)control;
                            MtB.Text = null;
                        }

                        if (control is DateTimePicker)
                        {
                            DateTimePicker DtP = (DateTimePicker)control;
                            DtP.Text = "#11/07/2019#";
                        }

                        if (control is PictureBox)
                        {
                            PictureBox pic = (PictureBox)control;
                            pic.Image = null;
                        }

                    }
                }

            }
            catch { }
        }

        //===============================================================================================
        public static void AbilitarControles(Control.ControlCollection c, bool status)
        {
            foreach (Control control in c)
            {
                if (control.HasChildren)
                {
                    AbilitarControles(control.Controls, status);
                }
                else
                {
                    if (control is TextBox)
                    {
                        TextBox txt = (TextBox)control;
                        txt.Enabled = status;
                    }
                    if (control is ComboBox)
                    {
                        ComboBox cmb = (ComboBox)control;
                        if (cmb.Items.Count > 0)
                            cmb.Enabled = status;
                    }

                    if (control is CheckBox)
                    {
                        CheckBox chk = (CheckBox)control;
                        chk.Enabled = status;
                    }

                    if (control is RadioButton)
                    {
                        RadioButton rdo = (RadioButton)control;
                        rdo.Enabled = status;
                    }

                    if (control is ListBox)
                    {
                        ListBox listBox = (ListBox)control;
                        listBox.Enabled = status;
                    }

                    if (control is MaskedTextBox)
                    {
                        MaskedTextBox MtB = (MaskedTextBox)control;
                        MtB.Enabled = status;
                    }

                    if (control is DateTimePicker)
                    {
                        DateTimePicker DtP = (DateTimePicker)control;
                        DtP.Enabled = status;
                    }

                    if (control is PictureBox)
                    {
                        //PictureBox pic = (PictureBox)control;
                        //pic.Enabled = status;
                    }

                }
            }
        }

        //===============================================================================================
        public static void CorDaPenaDosControles(Control.ControlCollection c)
        {
            Color CorDaPena = Color.Red;
            Color CorDeFundoFora = Color.GreenYellow;
            decimal dCodigo;
            decimal dValor;
            foreach (Control control in c)
            {
                if (control is TextBox)
                {
                    TextBox txt = (TextBox)control;
                    txt.ForeColor = CorDaPena;
                    txt.BackColor = CorDeFundoFora;

                    if (txt.Text == "") break;

                    if (txt.Name == "txtCodigoDeBarras")
                    {
                        dCodigo = Convert.ToDecimal(txt.Text);
                        txt.Text = dCodigo.ToString("0000000000000");
                    }


                    if (txt.Name == "txtValorCompra")
                    {
                        dValor = Convert.ToDecimal(txt.Text);
                        txt.Text = dValor.ToString("C2");
                    }

                    if (txt.Name == "txtQuantidade")
                    {
                        dValor = Convert.ToDecimal(txt.Text);
                        txt.Text = dValor.ToString("00000000");
                    }

                    if (txt.Name == "txtPrecoUnitario")
                    {
                        dValor = Convert.ToDecimal(txt.Text);
                        txt.Text = dValor.ToString("C2");
                    }

                    if (txt.Name == "txtEstoque")
                    {
                        dValor = Convert.ToDecimal(txt.Text);
                        txt.Text = dValor.ToString("00000000");
                    }

                    if (txt.Name == "txtDesconto")
                    {
                        dValor = Convert.ToDecimal(txt.Text);
                        txt.Text = dValor.ToString("C2");
                    }

                    if (txt.Name == "txtPrecoDeVendaVista")
                    {
                        dValor = Convert.ToDecimal(txt.Text);
                        txt.Text = dValor.ToString("C2");
                    }

                    if (txt.Name == "txtPrecoDeVendaAnotar")
                    {
                        dValor = Convert.ToDecimal(txt.Text);
                        txt.Text = dValor.ToString("C2");
                    }

                    if (txt.Name == "txtCartao")
                    {
                        dValor = Convert.ToDecimal(txt.Text);
                        txt.Text = dValor.ToString("C2");
                    }
                }


                if (control is ComboBox)
                {
                    ComboBox cmb = (ComboBox)control;
                    cmb.ForeColor = CorDaPena;
                    cmb.BackColor = CorDeFundoFora;
                }

                if (control is CheckBox)
                {
                    CheckBox chk = (CheckBox)control;
                    chk.ForeColor = CorDaPena;
                    chk.BackColor = CorDeFundoFora;
                }

                if (control is RadioButton)
                {
                    RadioButton rdo = (RadioButton)control;
                    rdo.ForeColor = CorDaPena;
                    rdo.BackColor = CorDeFundoFora;
                }

                if (control is ListBox)
                {
                    ListBox listBox = (ListBox)control;
                    listBox.ForeColor = CorDaPena;
                    listBox.BackColor = CorDeFundoFora;
                }

                if (control is MaskedTextBox)
                {
                    MaskedTextBox MtB = (MaskedTextBox)control;
                    MtB.ForeColor = CorDaPena;
                    MtB.BackColor = CorDeFundoFora;
                }

                if (control is DateTimePicker)
                {
                    DateTimePicker DtP = (DateTimePicker)control;
                    DtP.ForeColor = CorDaPena;
                    DtP.BackColor = CorDeFundoFora;
                }

                if (control is PictureBox)
                {
                    PictureBox pic = (PictureBox)control;
                    //pic.Image = null;
                    pic.BackColor = CorDeFundoFora;
                }
            }
        }

        //===============================================================================================
        public static void RegistrarLogDeErros(int numeroDoErro, string MenssagemDeErro)
        {
            try
            {
                string path = ValidarDiretorio(sCaminho, @"\CasaMendes.Log");

                //// Create the file if it not exists.
                if (!File.Exists(path))
                {
                    File.Create(path);
                }

                //Create the file.
                using (StreamWriter sw = new StreamWriter(path, true))
                //using (FileStream fs = File.OpenWrite(path),)
                {
                    //AddText(fs,numeroDoErro.ToString() + ": " + MenssagemDeErro);
                    sw.WriteLine(numeroDoErro.ToString() + ": " + MenssagemDeErro);
                    sw.Flush();
                    sw.Dispose();
                }

            }
            catch //(Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
        }

        //===============================================================================================
        public static void SetUpDataGridView(DataGridView dgv)
        {
            DataGridViewCellStyle style = dgv.ColumnHeadersDefaultCellStyle;
            style.BackColor = Color.Gold;
            style.ForeColor = Color.Red;
            dgv.AllowUserToAddRows = false;
            dgv.AutoGenerateColumns = true;
            dgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Raised;
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            dgv.GridColor = SystemColors.ActiveBorder;
            dgv.RowHeadersVisible = false;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.MultiSelect = false;
            dgv.BackgroundColor = Color.Green;
            dgv.ReadOnly = true;
        }

        /// <summary>
        /// Alinhar os elementos na grade
        /// </summary>
        /// <param name="dgv">Datagridview</param>
        /// <param name="posicao">Direita: right, Esquerda: left, Centro: center</param>
        public static void AlinharElementosNoGridView(DataGridView dgv,int index, string posicao="left")
        {
            switch (posicao)
            {
                case "left":
                    dgv.Columns[index].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                    break;
                case "center":
                    dgv.Columns[index].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    break;
                case "right":
                    dgv.Columns[index].DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight;
                    break;
            }
        }

        //===============================================================================================
        public static string MontarTitulo(string pTitulo = "", string pTitulo2 = "")
        {
            string tmp;
            if ((pTitulo == "") && (pTitulo2 != "")) { tmp = "PDV - " + pTitulo2 + "."; }
            else if ((pTitulo2 == "") && (pTitulo != "")) { tmp = "PDV - " + pTitulo + "."; }
            else if ((pTitulo != "") && (pTitulo2 != "")) { tmp = "PDV - " + pTitulo + " - " + pTitulo2 + "."; }
            else { tmp = Application.ProductName; }

            return tmp;
        }

        //===============================================================================================
        public static int DimencionarColuna(int tColuna, int tGrid)
        {
            int Tamanho = tGrid - 24;
            Tamanho = (tColuna * Tamanho) / 100;
            return Tamanho;
        }

        //===============================================================================================
        public static void RedimencionarGrade(Form frm, DataGridView dgv)
        {
            try
            {
                //          //=============================================================================================
                int Espaco = (frm.Width - 16);
                dgv.Left = 8;
                dgv.Width = Espaco - 16;
                dgv.Height = frm.Height - 130;
                frm.Refresh();
                //          //=============================================================================================
            }
            catch
            {

            }

        }

        //===============================================================================================
        public static decimal Calcular(DataGridView dgv, int _iCelula)
        {
            decimal soma = 0;
            decimal celula;
            Int32 conte = dgv.Rows.Count - 1;

            for (Int32 i = 0; i <= conte; i++)
            {
                if (dgv.Rows[i].Cells[_iCelula].Value != null)
                {
                    celula = Convert.ToDecimal(dgv.Rows[i].Cells[_iCelula].Value.ToString().Replace("R$ ", ""));
                    soma += celula;
                }
            }
            return soma;
        }

        //===============================================================================================
        public static bool SomenteNumeros(KeyPressEventArgs e)
        {
            int mascara = e.KeyChar;
            if (mascara >= 48 && mascara <= 57 || e.KeyChar == 8 || e.KeyChar == 42 || e.KeyChar == 120)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

    }

} //Fim da classe clsGlobal.

////-------------------------------------Encrypta/Decrypta---------
////public static string Encrypt(string What)
////{
////    int EpN, Dracula;
////    string Before, After, Aeneima, DeMoNs;
////    Before = " ?!@#$%^&*()_+|0123456789abcdefghijklmnopqrstuvwxyz.,-~ABCDEFGHIJKLMNOPQRSTUVWXYZ������������������������ض�ڥ"
////    After = " ��@#$%^&*()_+|01��456789�b�d��gh�jklm���q����vw��z.-~,A����FGH�JK�MNضQR�T�VWX�Z?!23acefinoprstuxyBCDEILOPSUY"


////        for(EpN = 1; EpN <= What.Length; EpN++)
////        {
////        Dracula = What.Substring(Before, EpN, 1);
////     //        If Not Dracula% = 0 Then
////     //        If Not Dracula% = 0 Then
////     //            Aeneima$ = Mid(After$, Dracula%, 1)
////     //            DeMoNs$ = DeMoNs$ + Aeneima$
////     //        End If
////     //    Next
////    }
////    //    Encrypt = DeMoNs$
////    return "";
////}

////Function DeEncrypt(What As String) As String
////    Dim Before$, After$, EpN%, Dracula%, Aeneima$, DeMoNs$
////    Before$ = " ��@#$%^&*()_+|01��456789�b�d��gh�jklm���q����vw��z.-~,A����FGH�JK�MNضQR�T�VWX�Z?!23acefinoprstuxyBCDEILOPSUY"
////    After$ = " ?!@#$%^&*()_+|0123456789abcdefghijklmnopqrstuvwxyz.,-~ABCDEFGHIJKLMNOPQRSTUVWXYZ������������������������ض�ڥ"
////    For EpN% = 1 To Len(What)
////        Dracula% = InStr(Before$, Mid(What, EpN%, 1))
////        If Not Dracula% = 0 Then
////            Aeneima$ = Mid(After$, Dracula%, 1)
////            DeMoNs$ = DeMoNs$ + Aeneima$
////        End If
////    Next
////    DeEncrypt = DeMoNs$
////End Function

//using (var reader = new StringReader(texto))
//{ //só trocar para o arquivo aqui
//    int size = int.Parse(reader.ReadLine());
//    for (int i = 0; i < size; i++)
//    {
//        string[] linha = reader.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
//        WriteLine($"{linha[0]}, {linha[1]}, {linha[2]}"); //depois troca para o Vector3
//    }
//}


//StreamReader sr = new StreamReader(FilePath);
//importingData = new Account();
//string line;
//string[] row = new string[5];
//while ((line = sr.ReadLine()) != null)
//{
//    row = line.Split(',');

//    importingData.Add(new Transaction
//    {
//        Date = DateTime.Parse(row[0]),
//        Reference = row[1],
//        Description = row[2],
//        Amount = decimal.Parse(row[3]),
//        Category = (Category)Enum.Parse(typeof(Category), row[4])
//    });
//}


//public static DataGridView ChecarPromocao()
//{
//    try
//    {

//        if (!File.Exists(arquivo))
//        {
//            using (StreamWriter sw = new StreamWriter(new FileStream(arquivo, FileMode.CreateNew)))
//            {
//                string chave = "178400924;";
//                double valor = 0.01666666667;
//                sw.WriteLine(chave + "3;" + valor);

//                chave = "7897395020101;";
//                valor = 0.16666666667;

//                sw.WriteLine(chave + "3;" + valor);

//                chave = "7898945735094;";
//                valor = 0.01666666667;

//                sw.WriteLine(chave + "3;" + valor);
//            }
//        }

//        return CarregarListas();

//    }
//    catch
//    {
//        return null;
//    }
//}

//private static DataGridView CarregarListas()
//{
//    try
//    {
//        DataGridView Grade = new DataGridView();

//        clsGlobal.SetUpDataGridView(Grade);
//        Grade.AutoGenerateColumns = false;

//        Grade.Columns.Add("Chave", "Chave");
//        Grade.Columns.Add("Quantidade", "Quantidade");
//        Grade.Columns.Add("Valor", "Valor");
//        Grade.Visible = false;

//        LinhasPromocao = 0;

//        using (StreamReader sr = new StreamReader(new FileStream(arquivo, FileMode.Open)))
//        {
//            while (sr.Peek() >= 0)
//            {
//                LinhasPromocao++;
//                arquivo = sr.ReadLine();
//                SepararStrings(arquivo, Grade);
//            }
//        }
//        return Grade;

//    }
//    catch//(Exception ex)
//    {
//        //MessageBox.Show(ex.Message);
//        return null;
//    }
//}

//private static void SepararStrings(string arquivo, DataGridView Grade)
//{

//    string chave, Quantidade, temp = "", temp2 = "", valor;
//    int tamanho = arquivo.Length-1;

//    int valortemp=0, valortemp2=0;

//    for(int i = 0; i < tamanho - 1; i++)
//    {
//        if (arquivo.Substring(i, 1) == ";" && temp != ";") { 
//            temp = arquivo.Substring(i, 1); valortemp = i; }
//    }


//    for (int j = 0; j < tamanho - 1;  j++)
//    {
//        if (arquivo.Substring(j, 1) == ";")
//        {
//            temp2 = arquivo.Substring(j, 1); valortemp2 = j;
//        }
//    }
//    //if (temp == ";" && temp2 == ";") {
//    //    t = tamanho - (i);
//    //    chave = arquivo.Substring(0, valortemp).Trim();

//    //    Quantidade = arquivo.Substring(valortemp2 + 1, 1).Trim();

//    //    valor = arquivo.Substring((valortemp + 3 ), valortemp2+3).Trim();

//    //    string[] row = {chave, Quantidade, valor};
//    //    Grade.Rows.Add(row);

//    //if (k == LinhasPromocao) break;
//    //k++;
//    LinhasPromocao = 0;

//    if (temp == ";" && temp2 == ";")
//    {
//        //chave = arquivo.Substring(0, valortemp).Trim();
//        chave = TirarValor(arquivo, 0, valortemp).Trim();
//        //Quantidade = arquivo.Substring(valortemp2 - 1, 1).Trim();

//        Quantidade = TirarValor( arquivo,valortemp+1, 1).Trim();
//        valortemp2 = arquivo.Length + valortemp+3;

//        //valor = arquivo.Substring((valortemp + 3), valortemp2).Trim();
//        valor = TirarValor(arquivo, valortemp + 3, valortemp2).Trim();

//        string[] row = { chave, Quantidade, valor };
//        Grade.Rows.Add(row);

//    }
//}

//private static string TirarValor(string arq, int inicio, int tam) {
//    string tmp = arq.Substring(inicio, tam);

//    return tmp;
//}

//public static Double ConvertStringDouble(string stringVal)
//{
//    Double decimalVal = 0;

//    try
//    {
//       decimalVal = System.Convert.ToDouble(stringVal);
//    }
//    catch (System.OverflowException)
//    {
//        System.Console.WriteLine(
//            "The conversion from string to decimal overflowed.");
//    }
//    catch (System.FormatException)
//    {
//        System.Console.WriteLine(
//            "The string is not formatted as a decimal.");
//    }
//    catch (System.ArgumentNullException)
//    {
//        System.Console.WriteLine(
//            "The string is null.");
//    }

//    return decimalVal;
//}
