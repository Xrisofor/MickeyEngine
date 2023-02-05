using System;
using System.Collections.Generic;
using System.Reflection;
using System.Windows.Forms;

namespace Editor.App
{
    partial class AboutBox : Form
    {
        public AboutBox()
        {
            InitializeComponent();
            textBoxDescription.Text = AssemblyDescription;
        }

        public string AssemblyDescription
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyDescriptionAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyDescriptionAttribute)attributes[0]).Description;
            }
        }
    }
}
