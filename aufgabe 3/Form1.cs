using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Timer = System.Timers.Timer;

namespace aufgabe_3
{
    
    public partial class Form1 : Form
    {
        //Dll 
        [DllImport("iowkit", SetLastError = true)]
        private static extern int IowKitOpenDevice();

        [DllImport("iowkit", SetLastError = true)]
        private static extern void IowKitCloseDevice(int iowHandle);

        [DllImport("iowkit", SetLastError = true)]
        private static extern int IowKitGetNumDevs();

        [DllImport("iowkit", SetLastError = true)]
        private static extern int IowKitGetDeviceHandle(int numDevice);

        [DllImport("iowkit", SetLastError = true)]
        private static extern int IowKitWrite(int iowHandle, int numPipe, ref byte buffer, int length);
        
        //Timer
        private Timer aTimer = new Timer();

        private byte[] data = new byte[5];
        //LEDs
        private const byte pin17 = 1 << 0;  //grün
        private const byte pin18 = 1 << 1;  //gleb
        private const byte pin19 = 1 << 2;  //rot

        int handle;

        public Form1()
        {
            InitializeComponent();

            data[0]=0;
            data[1]=0;
            data[2]=pin17|pin18|pin19;
            data[3]=0;
            data[4]=0;
            update_label();
            IowKitWrite(handle ,0, ref data[0],5);
            
        }

        private void update_label()
        {
            label1.Text = "data[2]= " + string.Format("{0:X2}", data[2]) + "(" + data[2].ToString() + ")";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            handle = IowKitOpenDevice();

        }
        int se;
        private void cbRot_CheckedChanged(object sender, EventArgs e)
        {
            
            if (cbRot.Checked == true)
            {
                pRot.BackColor = Color.Red;
                se =  0x04;
                data[2] &= (byte)(~Convert.ToByte(se));
                IowKitWrite(handle, 0, ref data[0], 3);
                update_label();
            }
            else
            {
                data[2] |= Convert.ToByte(se);
                pRot.BackColor = Color.Black;
                update_label();
            }
        }
        int ss;
        private void cbGelb_CheckedChanged(object sender, EventArgs e)
        {
            
            if (cbGelb.Checked == true)
            {
                pGelb.BackColor = Color.Yellow;
                ss =  0x02;
                data[2] &= (byte)(~Convert.ToByte(ss));
                IowKitWrite(handle, 0, ref data[0], 3);
                update_label();
            }
            else
            {
                data[2] |= Convert.ToByte(ss);
                pGelb.BackColor = Color.Black;
                update_label();
            }

        }
        int sd;
        private void cbGruen_CheckedChanged(object sender, EventArgs e)
        {
            
            if (cbGruen.Checked == true)
            {
                pGruen.BackColor = Color.Green;
                sd =  0x01;
                data[2] &=(byte)(~ Convert.ToByte(sd));
                IowKitWrite(handle, 0, ref data[0], 3);
                update_label();
            }
            else
            {
                data[2] |= Convert.ToByte(sd);
                pGruen.BackColor = Color.Black;
                update_label();

            }
                   

        }
        int lauflicht;
        
        private void timer2_Tick(object sender, EventArgs e)
        {
            update_panel();
            IowKitWrite(handle, 0, ref data[0],5);
            update_label();
            lauflicht++;
            if (cbLauf.Checked)
            {
                cbLauf_CheckedChanged();
                update_label();
                
            }

        }

        private void cbLauf_CheckedChanged()
        {
            int cache = 7;

            update_label();
            if (lauflicht >= 3)
            {
                lauflicht = 0;
            }
            switch (lauflicht)
            {
                case 0:
                    if (cbRot.Checked)
                        cache &= ~pin19;
                    break;
                case 1:
                    if (cbGelb.Checked)
                        cache &= ~pin18;
                    break;
                case 2:
                    if (cbGruen.Checked)
                        cache &= ~pin17;
                    break;
            }
            data[2] = (byte)cache;
        }
        private void update_panel()
        {
            panelxd(pin17).BackColor=refundfarbe(pin17);
            panelxd(pin18).BackColor = refundfarbe(pin18);
            panelxd(pin19).BackColor = refundfarbe(pin19);
        }

        private Color refundfarbe(byte pin)
        {
            switch (pin)
            { case pin17:
                    return (data[2] & pin) == 0 ? Color.Green : Color.Black;
               case pin18:
                    return (data[2] & pin) == 0 ? Color.Yellow : Color.Black;
                case pin19:
                    return (data[2] & pin) == 0 ? Color.Red :Color.Black;
                default:
                    return Color.Black;



            }
        }
        private Panel panelxd(byte pin)
        {
            switch (pin)
            {
                case pin17:
                    return pGruen;
                case pin18:
                    return pGelb;
                case pin19:
                    return pRot; 
                default:
                    return null;



            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            IowKitCloseDevice(handle);
        }
    }
}
