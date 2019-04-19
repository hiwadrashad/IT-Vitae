using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace De_Dierentuin
{
    public partial class Form1 : Form
    {

        static string name = "";
        static int energy = 0;
        static int eat = 25;
        DataTable dtbl = new DataTable();
        bool createTable = true;



        abstract class UseEnergy
        {
            public abstract int monkeyEnergy { get; }
            public abstract int lionEnergy { get; }
            public abstract int elephantEnergy { get; }
        }

        class DerivedClass : UseEnergy
        {
            public override int monkeyEnergy
            {
                get
                {
                    return 2;
                }
            }
            public override int lionEnergy
            {
                get
                {
                    return 10;
                }
            }
            public override int elephantEnergy
            {
                get
                {
                    return 5;
                }
            }
        }


        class Animal
        {
            public static string Name()
            {
                return name;
            }
            public static int Energy()
            {
                return energy;
            }
            public static int Eat()
            {
                return eat;
            }

        }

        class Monkey : Animal
        {

            public new static string Name()
            {
                return "Monkey";
            }
            public new static int Energy()
            {
                return 20;
            }
            public new static int Eat()
            {
                return eat * 10;
            }
        }

        class Lion : Animal
        {
            public new static string Name()
            {
                return "Lion";
            }
            public new static int Energy()
            {
                return 10;
            }
            public new static int Eat()
            {
                return eat * 25;
            }

        }

        class LionNonlead : Lion
        {
            public new static string Name()
            {
                return "Lion";
            }
            public new static int Energy()
            {
                return 10;
            }
            public new static int Eat()
            {
                return eat * 25;
            }
        }

        class Elephant : Animal
        {
            public new static string Name()
            {
                return "Elephant";
            }
            public new static int Energy()
            {
                return 10;
            }
            public new static int Eat()
            {
                return eat * 50;
            }
        }



        public Form1()
        {
            InitializeComponent();
        }

        static int amountofmonkeys = 0;
        static int amountoflions = 0;
        static int amountofelephants = 0;

        private void FeedAll_Click(object sender, EventArgs e)
        {
            int i = 0;
            while (i < listBox.Items.Count)
            {
                string storage = Convert.ToString(listBox.Items[i]);
                if (storage.Contains(Convert.ToString(Monkey.Name())))
                {
                    string animaltext = Convert.ToString(listBox.Items[i]);
                    string animalnumbercutofbefore = animaltext.Split(new[] { Convert.ToString(Monkey.Name()) }, StringSplitOptions.None).Last();
                    string animalnumber = animalnumbercutofbefore.Split(new[] { " " }, StringSplitOptions.None).First();
                    string animalenergy = animaltext.Split(new[] { "Energy:" }, StringSplitOptions.None).Last();
                    int energyinnumbers = Convert.ToInt32(animalenergy);
                    string feededenergy = Convert.ToString(energyinnumbers + Monkey.Eat());
                    listBox.Items.RemoveAt(i);
                    listBox.Items.Insert(i, Convert.ToString(Monkey.Name() + animalnumber + " Energy:" + feededenergy));
                    dtbl.Rows[i][0] = (Convert.ToString(Monkey.Name()) + animalnumber);
                    dtbl.Rows[i][1] = feededenergy;
                    i++;
                }
                else
                if (storage.Contains(Convert.ToString(LionNonlead.Name())))
                {
                    string animaltext = Convert.ToString(listBox.Items[i]);
                    string animalnumbercutofbefore = animaltext.Split(new[] { Convert.ToString(LionNonlead.Name()) }, StringSplitOptions.None).Last();
                    string animalnumber = animalnumbercutofbefore.Split(new[] { " " }, StringSplitOptions.None).First();
                    string animalenergy = animaltext.Split(new[] { "Energy:" }, StringSplitOptions.None).Last();
                    int energyinnumbers = Convert.ToInt32(animalenergy);
                    string feededenergy = Convert.ToString(energyinnumbers + LionNonlead.Eat());
                    listBox.Items.RemoveAt(i);
                    listBox.Items.Insert(i, Convert.ToString(LionNonlead.Name() + animalnumber + " Energy:" + feededenergy));
                    dtbl.Rows[i][0] = (Convert.ToString(LionNonlead.Name()) + animalnumber);
                    dtbl.Rows[i][1] = feededenergy;
                    i++;
                }
                else
                if (storage.Contains(Convert.ToString(Elephant.Name())))
                {
                    string animaltext = Convert.ToString(listBox.Items[i]);
                    string animalnumbercutofbefore = animaltext.Split(new[] { Convert.ToString(Elephant.Name()) }, StringSplitOptions.None).Last();
                    string animalnumber = animalnumbercutofbefore.Split(new[] { " " }, StringSplitOptions.None).First();
                    string animalenergy = animaltext.Split(new[] { "Energy:" }, StringSplitOptions.None).Last();
                    int energyinnumbers = Convert.ToInt32(animalenergy);
                    string feededenergy = Convert.ToString(energyinnumbers + Elephant.Eat());
                    listBox.Items.RemoveAt(i);
                    listBox.Items.Insert(i, Convert.ToString(Elephant.Name() + animalnumber + " Energy:" + feededenergy));
                    dtbl.Rows[i][0] = (Convert.ToString(Elephant.Name()) + animalnumber);
                    dtbl.Rows[i][1] = feededenergy;
                    i++;
                }
                else
                { i++; }
            }


        }

        private void FeedMonkeys_Click(object sender, EventArgs e)
        {
            int i = 0;
            while (i < listBox.Items.Count)
            {
                string storage = Convert.ToString(listBox.Items[i]);
                if (storage.Contains(Convert.ToString(Monkey.Name())))
                {
                    string animaltext = Convert.ToString(listBox.Items[i]);
                    string animalnumbercutofbefore = animaltext.Split(new[] { Convert.ToString(Monkey.Name()) }, StringSplitOptions.None).Last();
                    string animalnumber = animalnumbercutofbefore.Split(new[] { " " }, StringSplitOptions.None).First();
                    string animalenergy = animaltext.Split(new[] { "Energy:" }, StringSplitOptions.None).Last();
                    int energyinnumbers = Convert.ToInt32(animalenergy);
                    string feededenergy = Convert.ToString(energyinnumbers + Monkey.Eat());
                    listBox.Items.RemoveAt(i);
                    listBox.Items.Insert(i, Convert.ToString(Monkey.Name() + animalnumber + " Energy:" + feededenergy));
                    dtbl.Rows[i][0] = (Convert.ToString(Monkey.Name()) + animalnumber);
                    dtbl.Rows[i][1] = feededenergy;
                    i++;
                }
                else
                { i++; }
            }
        }

        private void FeedLions_Click(object sender, EventArgs e)
        {
            int i = 0;
            while (i < listBox.Items.Count)
            {
                string storage = Convert.ToString(listBox.Items[i]);
                if (storage.Contains(Convert.ToString(LionNonlead.Name())))
                {
                    string animaltext = Convert.ToString(listBox.Items[i]);
                    string animalnumbercutofbefore = animaltext.Split(new[] { Convert.ToString(LionNonlead.Name()) }, StringSplitOptions.None).Last();
                    string animalnumber = animalnumbercutofbefore.Split(new[] { " " }, StringSplitOptions.None).First();
                    string animalenergy = animaltext.Split(new[] { "Energy:" }, StringSplitOptions.None).Last();
                    int energyinnumbers = Convert.ToInt32(animalenergy);
                    string feededenergy = Convert.ToString(energyinnumbers + LionNonlead.Eat());
                    listBox.Items.RemoveAt(i);
                    listBox.Items.Insert(i, Convert.ToString(LionNonlead.Name() + animalnumber + " Energy:" + feededenergy));
                    listBox.Items.RemoveAt(i);
                    listBox.Items.Insert(i, Convert.ToString(LionNonlead.Name() + animalnumber + " Energy:" + feededenergy));
                    dtbl.Rows[i][0] = (Convert.ToString(LionNonlead.Name()) + animalnumber);
                    dtbl.Rows[i][1] = feededenergy;
                    i++;
                }
                else
                { i++; }
            }
        }

        private void FeedElephants_Click(object sender, EventArgs e)
        {
            int i = 0;
            while (i < listBox.Items.Count)
            {
                string storage = Convert.ToString(listBox.Items[i]);
                if (storage.Contains(Convert.ToString(Elephant.Name())))
                {
                 
                    string animaltext = Convert.ToString(listBox.Items[i]);
                    string animalnumbercutofbefore = animaltext.Split(new[] { Convert.ToString(Elephant.Name()) }, StringSplitOptions.None).Last();
                    string animalnumber = animalnumbercutofbefore.Split(new[] { " " }, StringSplitOptions.None).First();
                    string animalenergy = animaltext.Split(new[] { "Energy:" }, StringSplitOptions.None).Last();
                    int energyinnumbers = Convert.ToInt32(animalenergy);
                    string feededenergy = Convert.ToString(energyinnumbers + Elephant.Eat());
                    listBox.Items.RemoveAt(i);
                    listBox.Items.Insert(i, Convert.ToString(Elephant.Name() + animalnumber + " Energy:" + feededenergy));
                    listBox.Items.RemoveAt(i);
                    listBox.Items.Insert(i, Convert.ToString(Elephant.Name() + animalnumber + " Energy:" + feededenergy));
                    dtbl.Rows[i][0] = (Convert.ToString(Elephant.Name()) + animalnumber);
                    dtbl.Rows[i][1] = feededenergy;
                    i++;
                }
                else
                { i++; }
            }
        }



        private void CreateMonkey_Click(object sender, EventArgs e)
        {
            amountofmonkeys += 1;
            listBox.Items.Add(Convert.ToString(Monkey.Name()) + Convert.ToString(amountofmonkeys) + " Energy:" + (Convert.ToString(Monkey.Energy())));

            if (createTable == true)
            {

                dtbl.Columns.Add("Animal");
                dtbl.Columns.Add("Energy");
                dataGridView.DataSource = dtbl;
                dtbl.Rows.Add(Convert.ToString(Monkey.Name()) + Convert.ToString(amountofmonkeys), Monkey.Energy());
                createTable = false;
            }
            else
            {
                dataGridView.DataSource = dtbl;
                dtbl.Rows.Add(Convert.ToString(Monkey.Name()) + Convert.ToString(amountofmonkeys), Monkey.Energy());
            }

        }

        private void CreateLion_Click(object sender, EventArgs e)
        {
            amountoflions += 1;
            listBox.Items.Add(Convert.ToString(LionNonlead.Name()) + Convert.ToString(amountoflions) + " Energy:" + (Convert.ToString(LionNonlead.Energy())));


            if (createTable == true)
            {

                dtbl.Columns.Add("Animal");
                dtbl.Columns.Add("Energy");
                dataGridView.DataSource = dtbl;
                dtbl.Rows.Add(Convert.ToString(LionNonlead.Name()) + Convert.ToString(amountoflions), LionNonlead.Energy());
                createTable = false;
            }
            else
            {
                dataGridView.DataSource = dtbl;
                dtbl.Rows.Add(Convert.ToString(LionNonlead.Name()) + Convert.ToString(amountoflions), LionNonlead.Energy());
            }
        }

        private void CreateElephant_Click(object sender, EventArgs e)
        {
            amountofelephants += 1;
            listBox.Items.Add(Convert.ToString(Elephant.Name()) + Convert.ToString(amountofelephants) + " Energy:" + (Convert.ToString(Elephant.Energy())));


            if (createTable == true)
            {

                dtbl.Columns.Add("Animal");
                dtbl.Columns.Add("Energy");
                dataGridView.DataSource = dtbl;
                dtbl.Rows.Add(Convert.ToString(Elephant.Name()) + Convert.ToString(amountofelephants), Elephant.Energy());
                createTable = false;
            }
            else
            {
                dataGridView.DataSource = dtbl;
                dtbl.Rows.Add(Convert.ToString(Elephant.Name()) + Convert.ToString(amountofelephants), Elephant.Energy());
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            Timer timer = new Timer();
            timer.Interval = (500);
            timer.Tick += new EventHandler(timer_Tick);
            timer.Start();

        }

        private void timer_Tick(object sender, EventArgs e)
        {

            if (listBox.Items.Count > 0)
            {
                {
                    DerivedClass x = new DerivedClass();
                    int i = 0;
                    while (i < listBox.Items.Count)
                    {
                        string storage = Convert.ToString(listBox.Items[i]);
                        if (storage.Contains(Convert.ToString(Monkey.Name())))
                        {
                            string animaltext = Convert.ToString(listBox.Items[i]);
                            string animalnumbercutofbefore = animaltext.Split(new[] { Convert.ToString(Monkey.Name()) }, StringSplitOptions.None).Last();
                            string animalnumber = animalnumbercutofbefore.Split(new[] { " " }, StringSplitOptions.None).First();
                            string animalenergy = animaltext.Split(new[] { "Energy:" }, StringSplitOptions.None).Last();
                            int energyinnumbers = Convert.ToInt32(animalenergy);
                            string feededenergy = Convert.ToString(energyinnumbers - (x.monkeyEnergy));
                            if (feededenergy != "0")
                            {
                                listBox.Items.RemoveAt(i);
                                listBox.Items.Insert(i, Convert.ToString(Monkey.Name() + animalnumber + " Energy:" + feededenergy));
                                dtbl.Rows[i][0] = (Convert.ToString(Monkey.Name()) + animalnumber);
                                dtbl.Rows[i][1] = feededenergy;
                                i++;
                            }
                            else
                            {
                                listBox.Items.RemoveAt(i);
                                dtbl.Rows.RemoveAt(i);
                            }
                        }
                        else
                        if (storage.Contains(Convert.ToString(LionNonlead.Name())))
                        {
                            string animaltext = Convert.ToString(listBox.Items[i]);
                            string animalnumbercutofbefore = animaltext.Split(new[] { Convert.ToString(LionNonlead.Name()) }, StringSplitOptions.None).Last();
                            string animalnumber = animalnumbercutofbefore.Split(new[] { " " }, StringSplitOptions.None).First();
                            string animalenergy = animaltext.Split(new[] { "Energy:" }, StringSplitOptions.None).Last();
                            int energyinnumbers = Convert.ToInt32(animalenergy);
                            string feededenergy = Convert.ToString(energyinnumbers - (x.lionEnergy));
                            if (feededenergy != "0")
                            {
                                listBox.Items.RemoveAt(i);
                                listBox.Items.Insert(i, Convert.ToString(LionNonlead.Name() + animalnumber + " Energy:" + feededenergy));
                                dtbl.Rows[i][0] = (Convert.ToString(LionNonlead.Name()) + animalnumber);
                                dtbl.Rows[i][1] = feededenergy;
                                i++;
                            }
                            else
                            {
                                listBox.Items.RemoveAt(i);
                                dtbl.Rows.RemoveAt(i);
                            }
                        }
                        else
                        if (storage.Contains(Convert.ToString(Elephant.Name())))
                        {
                            string animaltext = Convert.ToString(listBox.Items[i]);
                            string animalnumbercutofbefore = animaltext.Split(new[] { Convert.ToString(Elephant.Name()) }, StringSplitOptions.None).Last();
                            string animalnumber = animalnumbercutofbefore.Split(new[] { " " }, StringSplitOptions.None).First();
                            string animalenergy = animaltext.Split(new[] { "Energy:" }, StringSplitOptions.None).Last();
                            int energyinnumbers = Convert.ToInt32(animalenergy);
                            string feededenergy = Convert.ToString(energyinnumbers - (x.elephantEnergy));
                            if (feededenergy != "0")
                            {
                                listBox.Items.RemoveAt(i);
                                listBox.Items.Insert(i, Convert.ToString(Elephant.Name() + animalnumber + " Energy:" + feededenergy));
                                dtbl.Rows[i][0] = (Convert.ToString(Elephant.Name()) + animalnumber);
                                dtbl.Rows[i][1] = feededenergy;
                                i++;
                            }
                            else
                            {
                                listBox.Items.RemoveAt(i);
                                dtbl.Rows.RemoveAt(i);
                            }

                        }

                    }
                }




            }
        }
    }
}
