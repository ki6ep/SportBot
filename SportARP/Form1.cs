using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AutoHotkey.Interop;

namespace SportARP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            Application.EnableVisualStyles();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AutoHotkeyEngine ahkEngine = new AutoHotkeyEngine();

            string ahkCode = @"
        #Persistent
        F1::
        SetTimer, Magic, 1000
        return

        F2:: 
        SetTimer, Magic, Off
        return

        Magic:
        isHeld := false

        if (!isHeld) {
            SendInput, {h down}
            isHeld := true
            Sleep, 5000
            SendInput, {h up}
            Sleep, 4000
        }
        return
    ";

            ahkEngine.ExecRaw(ahkCode);
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.adv-rp.com/join/");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Process.Start("https://forum.advance-rp.ru/members/hakaru-hashimoto.803898/");
            Process.Start("https://t.me/DeathsHand");
        }
    }
}