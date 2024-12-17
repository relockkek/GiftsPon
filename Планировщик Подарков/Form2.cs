using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Планировщик_Подарков
{
    public partial class People : Form
    {
        private readonly DB db;
        private Human human;
        private Holidays holidays;
        private Gifts gifts;
        public People(DB db)
        {
            InitializeComponent();
            this.db = db;
            human = new Human();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Человек
            human.FirstName = textFirstName.Text;
            human.LastName = textLastName.Text;
            human.PatronymicName = textPatronymicName.Text;
            human.DR = textDR.Text;
            if (db != null)
            {
                db.AddHuman(human);
                DialogResult = DialogResult.OK;
                Close();



            }
            ///Подарки
            gifts.Name = NameGifts.Text;
            gifts.Price = PriceGifts.Text;
            gifts.holidays = HolidaysGifts;
            gifts.human = human;
            if (db != null)
            {
                db.AddGift(gifts);
                DialogResult = DialogResult.OK;
                Close();
            }

            //Праздники

            holidays.Name = NameHolidays.Text;
            holidays.Overview = OverviewHolidays.Text;
            holidays.Holiday = dateGift.Value;

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
