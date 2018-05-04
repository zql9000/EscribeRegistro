using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace EscribeRegistro
{
    public partial class fmrPrincipal : Form
    {
        private struct Registro
        {
            public int Id;
            public int Dato;
        }

        private FileStream oArchivo;
        private BinaryWriter writer;

        Registro oDatoBoca = new Registro();
        Registro oDatoOjos = new Registro();

        public fmrPrincipal()
        {
            InitializeComponent();

            oArchivo = File.Open("d:\\Compartido\\compartido.dat", FileMode.OpenOrCreate, FileAccess.Write, FileShare.ReadWrite);
            writer = new BinaryWriter(oArchivo, Encoding.Default);

            oDatoBoca.Id = 1;
            oDatoOjos.Id = 2;
        }

        private void nudBoca_ValueChanged(object sender, EventArgs e)
        {
            oDatoBoca.Dato = (int)nudBoca.Value;

            writer.BaseStream.Position = 0;

            writer.Write(oDatoBoca.Id);
            writer.Write(oDatoBoca.Dato);

            writer.Flush();
        }

        private void nudOjos_ValueChanged(object sender, EventArgs e)
        {
            oDatoOjos.Dato = (int)nudOjos.Value;

            writer.BaseStream.Position = 8;

            writer.Write(oDatoOjos.Id);
            writer.Write(oDatoOjos.Dato);

            writer.Flush();
        }
    }
}
