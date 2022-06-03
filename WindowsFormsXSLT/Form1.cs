using System;
using System.Windows.Forms;

using System.Xml.Xsl;
using System.IO;

namespace WindowsFormsXSLT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Шлях до папки (bin\Debug)
            string pathToApp = Path.GetDirectoryName(Application.ExecutablePath);

            //Шлях до шаблону XSLT
            string pathToTemplate = Path.Combine(pathToApp, "..\\..\\Template.xslt");

            //Шлях до XML даних
            string pathToXmlData = Path.Combine(pathToApp, "..\\..\\XmlData.xml");

            //Шлях до файлу куди буде записаний результат трансформації XML даних
            string pathToSaveResult = Path.Combine(pathToApp, "..\\..\\Result.html");


            XslCompiledTransform xsltTransform = new XslCompiledTransform();

            //Завантаження шаблону
            xsltTransform.Load(pathToTemplate, new XsltSettings(), null);

            //Трансформація і запис результату
            xsltTransform.Transform(pathToXmlData, pathToSaveResult);

        }
    }
}
