using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalClass
{
    public abstract class Animal
    {
        protected string CanNang { get; set; }
        protected string ChieuCao { get; set; }

        public Animal(string cannang, string chieucao)
        {
            this.CanNang = cannang;
            this.ChieuCao = chieucao;
        }
        public abstract void PrintInfo();
    }

    class Cat : Animal
    {
        private string Ten { get; set; }
        public Cat(string cannang, string chieucao, string ten) : base(cannang, chieucao)
        {
            this.Ten = ten;
        }

        public override void PrintInfo()
        {
            Console.WriteLine("CanNang: {0}\nChieuCao: {1}\nTen: {2}", this.CanNang, this.ChieuCao, this.Ten);
        }

    }
}
