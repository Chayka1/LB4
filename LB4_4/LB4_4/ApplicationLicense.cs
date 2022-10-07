using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_4
{
    internal class ApplicationLicense
    {
        private string key = "";
        private string keyp = "K43JH42G3J4G5J4HG6JHK57G4JHKJH32H";
        private string keyt = "J324LJJ";
        private Control controlA = new Control();
        public string ControlA
        {
            get { return controlA.ToString(); }
        }
        private enum Control
        {
            Common,
            Pro,
            Trial
        }
        void AllowTrial()
        {
            Console.WriteLine("Пробний режим");
            controlA = Control.Trial;
        }
        void AllowPro()
        {
            Console.WriteLine("Платна версія");
            controlA = Control.Pro;
        }
        void AllowCommon()
        {
            Console.WriteLine("Безкоштовна версія");
        }
        public ApplicationLicense(string key)
        {
            Console.WriteLine(controlA);
            if (key == keyp)
            {
                this.key = keyp;
                AllowPro();
                Console.WriteLine(controlA);
            }
            else if (key == keyt)
            {
                this.key = keyt;
                AllowTrial();
                Console.WriteLine(controlA);
            }
            else
            {
                AllowCommon();
                Console.WriteLine(controlA);
            }
        }
    }
}