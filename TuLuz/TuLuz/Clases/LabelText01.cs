using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TuLuz.Clases
{
    public partial class LabelText01 : UserControl
    {
        public enum TipoDato {  texto, numero, fecha}
        public string PP_Etiqueta
        {
            get { return lblEtiqueta.Text; }
            set { lblEtiqueta.Text = value; }
        }

        public bool PP_Validable { get; set; }
        public string PP_Nombre_Campo { get; set; }
        public string PP_Nombre_Tabla { get; set; }
        public string PP_Mensaje_Error { get; set; }
        public int PP_Ancho { get; set; } = 10;
        public int PP_Decimales { get; set; } = 2;

        public TipoDato PP_TipoDato
        {
            get { return TipoD; }
            set
            {
                TipoD = value;
                string mascara = "";
                switch (TipoD)
                {
                    //MASCARA VACIA
                    case TipoDato.texto:
                        TxtDato.Mask = mascara.PadLeft(PP_Ancho, ' ');
                        TxtDato.TextAlign = HorizontalAlignment.Left;
                        break;
                    //MASCARA TIPO NUMERO
                    case TipoDato.numero:
                        mascara = mascara.PadLeft(PP_Ancho - PP_Decimales - 1, '9') + ".";
                        if (PP_Decimales >= 1)
                            mascara = mascara.PadRight(PP_Ancho, '9');
                        TxtDato.Mask = mascara;
                        TxtDato.TextAlign = HorizontalAlignment.Right;
                        break;
                    //MASCARA TIPO FECHA
                    case TipoDato.fecha:
                        TxtDato.Mask = "00/00/0000";
                        TxtDato.TextAlign = HorizontalAlignment.Left;
                        break;

                    default:
                        break;
                }
            }
            
        }

        public string PP_Text
        {
            get => TxtDato.Text;
            set
            {
                if (TipoD == TipoDato.numero)
                {
                    if (PP_Decimales == 0)
                        TxtDato.Text = string.Format("{0:" + TxtDato.Mask.Replace('9', '0') + "}", int.Parse(value));
                    else
                        TxtDato.Text = string.Format("{0:" + TxtDato.Mask.Replace('9', '0') + "}", double.Parse(value));
                }
            }
        }

        public bool PP_MaskFull => TxtDato.MaskFull;

        TipoDato TipoD = TipoDato.texto;

        public bool PP_ReadOnly
        {
            get => TxtDato.ReadOnly;
            set => TxtDato.ReadOnly = value;
        }

        public LabelText01()
        {
            InitializeComponent();
        }

        
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void TxtDato_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar("."))
            {
                if (this.PP_TipoDato == TipoDato.numero)
                {
                    int blanco = TxtDato.Text.IndexOf(' ');
                    int entero = PP_Ancho - PP_Decimales - 1;
                    if (blanco <= entero && blanco !=-1)
                    {
                        for (int i = 0; i < entero; i++)
                        {
                            TxtDato.Text = " " + TxtDato.Text;
                        }
                    }
                    TxtDato.SelectionStart = TxtDato.Text.Length;
                }
            }
        }
    }
}
