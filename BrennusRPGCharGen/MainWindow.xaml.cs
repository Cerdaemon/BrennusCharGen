using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BrennusRPGCharGen
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        Random rnd = new Random();

        List<TextBox> linkTierRoll = new List<TextBox>();
        List<Label> linkTierTypes = new List<Label>();

        List<TextBox> linkStarRoll = new List<TextBox>();
        List<Label> linkStarTypes = new List<Label>();


        List<TextBox> powerTierRoll = new List<TextBox>();
        List<Label> powerTierTypes = new List<Label>();

        List<TextBox> powerStarRoll = new List<TextBox>();
        List<Label> powerStarTypes = new List<Label>();

        List<TextBox> dreamRolled = new List<TextBox>();
        List<Label> dreamName = new List<Label>();
        List<TextBox> dreamCount = new List<TextBox>();

        List<TextBox> nightmareRolled = new List<TextBox>();
        List<Label> nightmareName = new List<Label>();
        List<TextBox> nightmareCount = new List<TextBox>();

        Character character = new Character();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Link_Roll_Click(object sender, RoutedEventArgs e)
        {
            grid_Link.Height = 40;
            grid_Link.Children.RemoveRange(5, grid_Link.Children.Count - 5);

            linkTierRoll.Clear();
            linkTierTypes.Clear();
            linkStarRoll.Clear();
            linkStarTypes.Clear();


            int rollD100 = RollRandom(1, 100);
            textBox_Link_Rolled_Amount.Text = "" + rollD100;

            int rollLinkAmount = 0;

            if (rollD100 <= 60)
            {
                textBox_Link_Amount.Text = "0";
            }
            else if (rollD100 > 60 && rollD100 <= 84)
            {
                rollLinkAmount = RollRandom(1, 3);
                textBox_Link_Amount.Text = "" + rollLinkAmount;
            }
            else if (rollD100 > 84 && rollD100 <= 99)
            {
                rollLinkAmount = RollRandom(1, 6);
                textBox_Link_Amount.Text = "" + rollLinkAmount;
            }
            else if (rollD100 == 100)
            {
                rollLinkAmount = RollRandom(1, 12);
                textBox_Link_Amount.Text = "" + rollLinkAmount;
            }

            character.passAmountOfLinks(rollLinkAmount);

            for (int i = 1; i <= rollLinkAmount; i++)
            {

                grid_Link.Height += 60;
                //Link Tier

                Label linkTier = new Label();
                linkTier.Content = "Link " + i + ": Tier: ";
                linkTier.HorizontalAlignment = HorizontalAlignment.Left;
                linkTier.VerticalAlignment = VerticalAlignment.Top;
                linkTier.Width = 70;
                linkTier.Height = 30;
                linkTier.Margin = new Thickness(20.0, grid_Link.Height - 60.0, 0, 0);
                grid_Link.Children.Add(linkTier);


                TextBox linkTierValue = new TextBox();
                linkTierValue.Name = "LinkTierText" + i;
                linkTierValue.HorizontalAlignment = HorizontalAlignment.Left;
                linkTierValue.VerticalAlignment = VerticalAlignment.Top;
                linkTierValue.Width = 30;
                linkTierValue.Height = 20;
                linkTierValue.Margin = new Thickness(100.0, grid_Link.Height - 55.0, 0, 0);
                grid_Link.Children.Add(linkTierValue);
                linkTierRoll.Add(linkTierValue);


                Label linkRolledTier = new Label();
                linkRolledTier.Content = "";
                linkRolledTier.HorizontalAlignment = HorizontalAlignment.Left;
                linkRolledTier.VerticalAlignment = VerticalAlignment.Top;
                linkRolledTier.Width = 80;
                linkRolledTier.Height = 30;
                linkRolledTier.Margin = new Thickness(140.0, grid_Link.Height - 60.0, 0, 0);
                grid_Link.Children.Add(linkRolledTier);
                linkTierTypes.Add(linkRolledTier);


                Button roll_Link_Tier = new Button();
                roll_Link_Tier.Name = "rlt" + i;
                roll_Link_Tier.Click += new RoutedEventHandler(roll_Link_Tier_Click);
                roll_Link_Tier.Content = "Roll";
                roll_Link_Tier.HorizontalAlignment = HorizontalAlignment.Left;
                roll_Link_Tier.VerticalAlignment = VerticalAlignment.Top;
                roll_Link_Tier.Width = 40;
                roll_Link_Tier.Height = 20;
                roll_Link_Tier.Margin = new Thickness(230.0, grid_Link.Height - 55.0, 0, 0);
                grid_Link.Children.Add(roll_Link_Tier);


                //Link Star
                Label linkStar = new Label();
                linkStar.Content = "            Star: ";
                linkStar.HorizontalAlignment = HorizontalAlignment.Left;
                linkStar.VerticalAlignment = VerticalAlignment.Top;
                linkStar.Width = 70;
                linkStar.Height = 30;
                linkStar.Margin = new Thickness(20.0, grid_Link.Height - 30.0, 0, 0);
                grid_Link.Children.Add(linkStar);


                TextBox linkStarValue = new TextBox();
                linkStarValue.Name = "LinkTierText" + i;
                linkStarValue.HorizontalAlignment = HorizontalAlignment.Left;
                linkStarValue.VerticalAlignment = VerticalAlignment.Top;
                linkStarValue.Width = 30;
                linkStarValue.Height = 20;
                linkStarValue.Margin = new Thickness(100.0, grid_Link.Height - 25.0, 0, 0);
                grid_Link.Children.Add(linkStarValue);
                linkStarRoll.Add(linkStarValue);


                Label linkRolledStar = new Label();
                linkRolledStar.Content = "";
                linkRolledStar.HorizontalAlignment = HorizontalAlignment.Left;
                linkRolledStar.VerticalAlignment = VerticalAlignment.Top;
                linkRolledStar.Width = 80;
                linkRolledStar.Height = 30;
                linkRolledStar.Margin = new Thickness(140.0, grid_Link.Height - 30.0, 0, 0);
                grid_Link.Children.Add(linkRolledStar);
                linkStarTypes.Add(linkRolledStar);


                Button roll_Link_Star = new Button();
                roll_Link_Star.Name = "rls" + i;
                roll_Link_Star.Click += new RoutedEventHandler(roll_Link_Tier_Click);
                roll_Link_Star.Content = "Roll";
                roll_Link_Star.HorizontalAlignment = HorizontalAlignment.Left;
                roll_Link_Star.VerticalAlignment = VerticalAlignment.Top;
                roll_Link_Star.Width = 40;
                roll_Link_Star.Height = 20;
                roll_Link_Star.Margin = new Thickness(230.0, grid_Link.Height - 25.0, 0, 0);
                grid_Link.Children.Add(roll_Link_Star);

            }

        }

        private void Manifestation_Roll_Click(object sender, RoutedEventArgs e)
        {
            int rollD100 = RollRandom(1, 100);
            textBox_Manifestation_Rolled_Amount.Text = "" + rollD100;

            Manifestation manifestation = getManifestation(rollD100);

            textBox_Manifestation_Type.Text = "" + manifestation.Type;

            character.passManifestation(manifestation);
            fillCharacterStats();
        }

        private void Physique_Roll_Click(object sender, RoutedEventArgs e)
        {
            // Using same Tier list as for other powers, in the rules the only difference is a 5% higher chance for exemplar and thus 5% less for paragon
            int rollD100 = RollRandom(1, 100);
            textBox_Physique_Roll.Text = "" + rollD100;
            textBox_Physique.Text = "" + getTier(rollD100).Type;

        }

        private void Power_Amount_Roll_Click(object sender, RoutedEventArgs e)
        {
            grid_Power.Height = 0;
            grid_Power.Children.Clear();

            powerTierRoll.Clear();
            powerTierTypes.Clear();
            powerStarRoll.Clear();
            powerStarTypes.Clear();

            int rollD100 = RollRandom(1, 100);
            int amount = 0;
            textBox_Power_Amount_Roll.Text = "" + rollD100;

            if(rollD100 <= 75)
            {
                textBox_Power_Single_Multi.Text = "Single Power";
                amount = 1;
            }
            else
            {
                int powerCountRoll = RollRandom(1, 100);
                if(powerCountRoll <= 20)
                {
                    amount = 2;  
                }
                else if(20 < powerCountRoll && powerCountRoll <= 40)
                {
                    amount = 3;
                }
                else if (40 < powerCountRoll && powerCountRoll <= 60)
                {
                    amount = 4;
                }
                else if (60 < powerCountRoll && powerCountRoll <= 80)
                {
                    amount = 5;
                }
                else if (80 < powerCountRoll && powerCountRoll <= 99)
                {
                    amount = 6;
                }
                else if (powerCountRoll == 100)
                {
                    amount = 7;
                }

                textBox_Power_Single_Multi.Text = amount + " Powers";
            }

            character.passAmountOfPowers(amount);

            for (int i = 1; i <= amount; i++)
            {
                grid_Power.Height += 60;
                //Link Tier

                Label powerTier = new Label();
                powerTier.Content = "Power " + i + ": Tier: ";
                powerTier.HorizontalAlignment = HorizontalAlignment.Left;
                powerTier.VerticalAlignment = VerticalAlignment.Top;
                powerTier.Width = 80;
                powerTier.Height = 30;
                powerTier.Margin = new Thickness(20.0, grid_Power.Height - 60.0, 0, 0);
                grid_Power.Children.Add(powerTier);


                TextBox powerTierValue = new TextBox();
                powerTierValue.Name = "PowerTierText" + i;
                powerTierValue.HorizontalAlignment = HorizontalAlignment.Left;
                powerTierValue.VerticalAlignment = VerticalAlignment.Top;
                powerTierValue.Width = 30;
                powerTierValue.Height = 20;
                powerTierValue.Margin = new Thickness(110.0, grid_Power.Height - 55.0, 0, 0);
                grid_Power.Children.Add(powerTierValue);
                powerTierRoll.Add(powerTierValue);


                Label powerRolledTier = new Label();
                powerRolledTier.Content = "";
                powerRolledTier.HorizontalAlignment = HorizontalAlignment.Left;
                powerRolledTier.VerticalAlignment = VerticalAlignment.Top;
                powerRolledTier.Width = 80;
                powerRolledTier.Height = 30;
                powerRolledTier.Margin = new Thickness(190.0, grid_Power.Height - 60.0, 0, 0);
                grid_Power.Children.Add(powerRolledTier);
                powerTierTypes.Add(powerRolledTier);


                Button roll_Power_Tier = new Button();
                roll_Power_Tier.Name = "rlt" + i;
                roll_Power_Tier.Click += new RoutedEventHandler(roll_Power_Tier_Click);
                roll_Power_Tier.Content = "Roll";
                roll_Power_Tier.HorizontalAlignment = HorizontalAlignment.Left;
                roll_Power_Tier.VerticalAlignment = VerticalAlignment.Top;
                roll_Power_Tier.Width = 40;
                roll_Power_Tier.Height = 20;
                roll_Power_Tier.Margin = new Thickness(280.0, grid_Power.Height - 55.0, 0, 0);
                grid_Power.Children.Add(roll_Power_Tier);


                //Link Star
                Label powerStar = new Label();
                powerStar.Content = "               Star: ";
                powerStar.HorizontalAlignment = HorizontalAlignment.Left;
                powerStar.VerticalAlignment = VerticalAlignment.Top;
                powerStar.Width = 82;
                powerStar.Height = 30;
                powerStar.Margin = new Thickness(20.0, grid_Power.Height - 30.0, 0, 0);
                grid_Power.Children.Add(powerStar);


                TextBox powerStarValue = new TextBox();
                powerStarValue.Name = "LinkTierText" + i;
                powerStarValue.HorizontalAlignment = HorizontalAlignment.Left;
                powerStarValue.VerticalAlignment = VerticalAlignment.Top;
                powerStarValue.Width = 70;
                powerStarValue.Height = 20;
                powerStarValue.Margin = new Thickness(110.0, grid_Power.Height - 25.0, 0, 0);
                grid_Power.Children.Add(powerStarValue);
                powerStarRoll.Add(powerStarValue);


                Label powerRolledStar = new Label();
                powerRolledStar.Content = "";
                powerRolledStar.HorizontalAlignment = HorizontalAlignment.Left;
                powerRolledStar.VerticalAlignment = VerticalAlignment.Top;
                powerRolledStar.Width = 80;
                powerRolledStar.Height = 30;
                powerRolledStar.Margin = new Thickness(190.0, grid_Power.Height - 30.0, 0, 0);
                grid_Power.Children.Add(powerRolledStar);
                powerStarTypes.Add(powerRolledStar);


                Button roll_Power_Star = new Button();
                roll_Power_Star.Name = "rls" + i;
                roll_Power_Star.Click += new RoutedEventHandler(roll_Power_Tier_Click);
                roll_Power_Star.Content = "Roll";
                roll_Power_Star.HorizontalAlignment = HorizontalAlignment.Left;
                roll_Power_Star.VerticalAlignment = VerticalAlignment.Top;
                roll_Power_Star.Width = 40;
                roll_Power_Star.Height = 20;
                roll_Power_Star.Margin = new Thickness(280.0, grid_Power.Height - 25.0, 0, 0);
                grid_Power.Children.Add(roll_Power_Star);
            }

        }

        private void Roll_Dreams_Nightmares(object sender, RoutedEventArgs e)
        {
            Grid_Dreams.Height = 0;
            Grid_Dreams.Children.Clear();
            Grid_Nightmares.Height = 0;
            Grid_Nightmares.Children.Clear();
            dreamRolled.Clear();
            dreamName.Clear();
            dreamCount.Clear();
            nightmareRolled.Clear();
            nightmareName.Clear();
            nightmareCount.Clear();


            character.Dreams.Clear();
            character.Nightmares.Clear();

            int amount = 0;

            amount = character.TotalDreams;
            for (int i = 1; i <= amount; i++)
            {
                Grid_Dreams.Height += 30;
                //Link Tier

                Label name = new Label();
                name.Content = "Dream: ";
                name.HorizontalAlignment = HorizontalAlignment.Left;
                name.VerticalAlignment = VerticalAlignment.Top;
                name.Width = 80;
                name.Height = 30;
                name.Margin = new Thickness(10.0, Grid_Dreams.Height - 30.0, 0, 0);
                Grid_Dreams.Children.Add(name);


                TextBox dreamRoll = new TextBox();
                dreamRoll.Name = "DreamText" + i;
                dreamRoll.HorizontalAlignment = HorizontalAlignment.Left;
                dreamRoll.VerticalAlignment = VerticalAlignment.Top;
                dreamRoll.Width = 30;
                dreamRoll.Height = 20;
                dreamRoll.Margin = new Thickness(100.0, Grid_Dreams.Height - 25.0, 0, 0);
                Grid_Dreams.Children.Add(dreamRoll);
                dreamRolled.Add(dreamRoll);

                Label nameBox = new Label();
                nameBox.Content = "";
                nameBox.HorizontalAlignment = HorizontalAlignment.Left;
                nameBox.VerticalAlignment = VerticalAlignment.Top;
                nameBox.Width = 80;
                nameBox.Height = 30;
                nameBox.Margin = new Thickness(130.0, Grid_Dreams.Height - 30.0, 0, 0);
                Grid_Dreams.Children.Add(nameBox);
                dreamName.Add(nameBox);

                Label x_label = new Label();
                x_label.Content = "x";
                x_label.HorizontalAlignment = HorizontalAlignment.Left;
                x_label.VerticalAlignment = VerticalAlignment.Top;
                x_label.Width = 15;
                x_label.Height = 30;
                x_label.Margin = new Thickness(240, Grid_Dreams.Height - 30.0, 0, 0);
                Grid_Dreams.Children.Add(x_label);

                TextBox times = new TextBox();
                times.Name = "DreamText" + i;
                times.HorizontalAlignment = HorizontalAlignment.Left;
                times.VerticalAlignment = VerticalAlignment.Top;
                times.Width = 20;
                times.Height = 20;
                times.Margin = new Thickness(255, Grid_Dreams.Height - 25.0, 0, 0);
                Grid_Dreams.Children.Add(times);
                dreamCount.Add(times);

                Button dream_roll_Button = new Button();
                dream_roll_Button.Name = "drb" + i;
                dream_roll_Button.Click += new RoutedEventHandler(roll_Dream_Click);
                dream_roll_Button.Content = "Roll";
                dream_roll_Button.HorizontalAlignment = HorizontalAlignment.Left;
                dream_roll_Button.VerticalAlignment = VerticalAlignment.Top;
                dream_roll_Button.Width = 40;
                dream_roll_Button.Height = 20;
                dream_roll_Button.Margin = new Thickness(285, Grid_Dreams.Height - 25.0, 0, 0);
                Grid_Dreams.Children.Add(dream_roll_Button);
            }

            amount = character.TotalNightmares;
            for (int i = 1; i <= amount; i++)
            {
                Grid_Nightmares.Height += 30;
                //Link Tier

                Label name = new Label();
                name.Content = "Nightmare: ";
                name.HorizontalAlignment = HorizontalAlignment.Left;
                name.VerticalAlignment = VerticalAlignment.Top;
                name.Width = 80;
                name.Height = 30;
                name.Margin = new Thickness(10.0, Grid_Nightmares.Height - 30.0, 0, 0);
                Grid_Nightmares.Children.Add(name);


                TextBox nightmareRoll = new TextBox();
                nightmareRoll.Name = "NightmareText" + i;
                nightmareRoll.HorizontalAlignment = HorizontalAlignment.Left;
                nightmareRoll.VerticalAlignment = VerticalAlignment.Top;
                nightmareRoll.Width = 30;
                nightmareRoll.Height = 20;
                nightmareRoll.Margin = new Thickness(100.0, Grid_Nightmares.Height - 25.0, 0, 0);
                Grid_Nightmares.Children.Add(nightmareRoll);
                nightmareRolled.Add(nightmareRoll);

                Label nameBox = new Label();
                nameBox.Content = "";
                nameBox.HorizontalAlignment = HorizontalAlignment.Left;
                nameBox.VerticalAlignment = VerticalAlignment.Top;
                nameBox.Width = 80;
                nameBox.Height = 30;
                nameBox.Margin = new Thickness(130.0, Grid_Nightmares.Height - 30.0, 0, 0);
                Grid_Nightmares.Children.Add(nameBox);
                nightmareName.Add(nameBox);

                Label x_label = new Label();
                x_label.Content = "x";
                x_label.HorizontalAlignment = HorizontalAlignment.Left;
                x_label.VerticalAlignment = VerticalAlignment.Top;
                x_label.Width = 15;
                x_label.Height = 30;
                x_label.Margin = new Thickness(240, Grid_Nightmares.Height - 30.0, 0, 0);
                Grid_Nightmares.Children.Add(x_label);

                TextBox times = new TextBox();
                times.Name = "DreamText" + i;
                times.HorizontalAlignment = HorizontalAlignment.Left;
                times.VerticalAlignment = VerticalAlignment.Top;
                times.Width = 20;
                times.Height = 20;
                times.Margin = new Thickness(255, Grid_Nightmares.Height - 25.0, 0, 0);
                Grid_Nightmares.Children.Add(times);
                nightmareCount.Add(times);

                Button dream_roll_Button = new Button();
                dream_roll_Button.Name = "nrb" + i;
                dream_roll_Button.Click += new RoutedEventHandler(roll_Nightmare_Click);
                dream_roll_Button.Content = "Roll";
                dream_roll_Button.HorizontalAlignment = HorizontalAlignment.Left;
                dream_roll_Button.VerticalAlignment = VerticalAlignment.Top;
                dream_roll_Button.Width = 40;
                dream_roll_Button.Height = 20;
                dream_roll_Button.Margin = new Thickness(285, Grid_Nightmares.Height - 25.0, 0, 0);
                Grid_Nightmares.Children.Add(dream_roll_Button);
            }

            character.passAmountODreamsAndNightmares();
        }

        private int RollRandom(int low, int high) {          

            return rnd.Next(low, high + 1);
        }

        protected void roll_Link_Tier_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;

            int index = 0;

            if(button.Name.Length == 5)
            {
                Int32.TryParse("" + button.Name[button.Name.Length - 2] + "" + button.Name[button.Name.Length - 1], out index);
            }
            else
            {
                Int32.TryParse("" + button.Name[button.Name.Length - 1], out index);
            }
            

            if (button.Name.Contains("rlt"))
            {
                int roll = RollRandom(1, 100);
                linkTierRoll[index - 1].Text = "" + roll;
                linkTierTypes[index - 1].Content = "" + getTier(roll).Type;
            }

            if (button.Name.Contains("rls"))
            {
                int roll = RollRandom(1, 100);
                linkStarRoll[index - 1].Text = "" + roll;
                Star star = getStar(roll, -1);
                linkStarTypes[index - 1].Content = "" + star.Type;

                if(star.Type == StarType.Black_Hole)
                {
                    character.passLinkDV(50, index);
                }
                else if (star.Type == StarType.D2)
                {
                    character.passLinkDV(30, index);
                }
                else if (star.Type == StarType.D1)
                {
                    character.passLinkDV(15, index);
                }
                else if (star.Type == StarType.Failed_Star)
                {
                    character.passLinkDV(10, index);
                }
                else if (star.Type == StarType.White_Hole)
                {
                    character.passLinkDV(-100, index);
                }
                else
                {
                    character.passLinkDV(-5, index);
                }

            }

        }

        protected void roll_Power_Tier_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;

            int index = 0;

            if (button.Name.Length == 5)
            {
                Int32.TryParse("" + button.Name[button.Name.Length - 2] + "" + button.Name[button.Name.Length - 1], out index);
            }
            else
            {
                Int32.TryParse("" + button.Name[button.Name.Length - 1], out index);
            }

            Tier tier = new Tier();
            Star star = new Star();
            int tiermod = 0;

            if (button.Name.Contains("rlt"))
            {
                int roll = RollRandom(1, 100);
                powerTierRoll[index - 1].Text = "" + roll;
                tier = getTier(roll);
                character.passTier(tier, index);
                int newlvl = tier.PreciseLevel + (tiermod * 3);
                powerTierTypes[index - 1].Content = "" + Tier.returnTierByLevel(newlvl).Type + "(" + newlvl + ")";
            }

            if (button.Name.Contains("rls"))
            {
                int roll = RollRandom(1, 100);
                powerStarRoll[index - 1].Text = "" + roll;
                star = getStar(roll, index - 1);
                tiermod = star.TierModifier;

                tier = character.Powers[index - 1].Tier;
                if (tier.Type != TierType.Normie)
                {
                    if(tier.PreciseLevel + (tiermod * 3) > 0 && tier.PreciseLevel + (tiermod * 3) < 13)
                    {
                        int newlvl = tier.PreciseLevel + (tiermod * 3);                        
                        powerTierTypes[index - 1].Content = "" + Tier.returnTierByLevel(newlvl).Type + "(" + newlvl + ")";
                    }
                    else if(tier.PreciseLevel + (tiermod * 3) < 1)
                    {
                        powerTierTypes[index - 1].Content = "" + Tier.returnTierByLevel(1).Type + "(" + 1 + ")";
                    }
                    else if(tier.PreciseLevel + (tiermod * 3) > 12)
                    {
                        powerTierTypes[index - 1].Content = "" + Tier.returnTierByLevel(12).Type + "(" + 12 + ")";
                    }
                    
                }
                character.passStar(star, index);
                powerStarTypes[index - 1].Content = "" + star.Type;
            }
            
            fillCharacterStats();

        }

        protected void roll_Dream_Click(object sender, EventArgs e)
        {

            Button button = sender as Button;

            int index = 0;

            if (button.Name.Length == 5)
            {
                Int32.TryParse("" + button.Name[button.Name.Length - 2] + "" + button.Name[button.Name.Length - 1], out index);
            }
            else
            {
                Int32.TryParse("" + button.Name[button.Name.Length - 1], out index);
            }



            int roll = RollRandom(1, 41);
            dreamRolled[index - 1].Text = "" + roll;
            Dream dream = getDream(roll, index);
            dreamName[index - 1].Content = "" + dream.Name;

            //if (character.Dreams.Contains(dream))
            //{
            //    //int i = character.Dreams.IndexOf(dream);
            //    int dc;
            //    Int32.TryParse(dreamCount[index - 1].Text, out dc);
            //    dreamCount[index - 1].Text = "" + (dc + 1);
            //    //character.Dreams.Remove(dream);
            //    //Grid_Dreams.Children.RemoveRange((i) * 6,6);
            //}
            //else
            //{
                dreamCount[index - 1].Text = "1";
            //}

            character.passDream(dream, index);
            fillCharacterStats();
        }

        protected void roll_Nightmare_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;

            int index = 0;

            if (button.Name.Length == 5)
            {
                Int32.TryParse("" + button.Name[button.Name.Length - 2] + "" + button.Name[button.Name.Length - 1], out index);
            }
            else
            {
                Int32.TryParse("" + button.Name[button.Name.Length - 1], out index);
            }



            int roll = RollRandom(1, 41);
            nightmareRolled[index - 1].Text = "" + roll;
            Nightmare nightmare = getNightmare(roll, index);
            nightmareName[index - 1].Content = "" + nightmare.Name;

            //if (character.Nightmares.Contains(nightmare))
            //{
            //    //int i = character.Nightmares.IndexOf(nightmare);
            //    int dc;
            //    Int32.TryParse(dreamCount[index - 1].Text, out dc);
            //    dreamCount[index - 1].Text = "" + (dc + 1);
            //    //character.Nightmares.Remove(nightmare);
            //    //Grid_Nightmaress.Children.RemoveRange((i) * 6,6);
            //}
            //else
            //{
                nightmareCount[index - 1].Text = "1";
            //}

            character.passNightmare(nightmare, index);
            fillCharacterStats();
        }

        private Tier getTier(int roll){

            int level = RollRandom(1, 100);

            if (roll <= 45)
            {
                if(level <= 40)
                {
                    return Tier.Exemplar1;
                }
                else if(40 < level && level <= 74)
                {
                    return Tier.Exemplar2;
                }
                else if(74 < level)
                {
                    return Tier.Exemplar3;
                }
               
            }
            else if (45 < roll && roll <= 74)
            {
                if (level <= 40)
                {
                    return Tier.Paragon1;
                }
                else if (40 < level && level <= 74)
                {
                    return Tier.Paragon2;
                }
                else if (74 < level)
                {
                    return Tier.Paragon3;
                }
            }
            else if (74 < roll && roll <= 90)
            {
                if (level <= 40)
                {
                    return Tier.Apex1;
                }
                else if (40 < level && level <= 74)
                {
                    return Tier.Apex2;
                }
                else if (74 < level)
                {
                    return Tier.Apex3;
                }
            }
            else if (90 < roll && roll <= 99)
            {
                if (level <= 40)
                {
                    return Tier.God1;
                }
                else if (40 < level && level <= 74)
                {
                    return Tier.God2;
                }
                else if (74 < level)
                {
                    return Tier.God3;
                }
            }
            else if (roll == 100)
            {
                return Tier.Transcendent;
            }

            return Tier.Normie;
        }

        // Maybe fix the index issue so that it works for links also

        private Star getStar(int roll, int ind)
        {
            if (roll <= 10)
            {
                int rollDead = RollRandom(1, 100);
                if(ind >= 0)
                {
                    powerStarRoll[ind].Text += " > " + rollDead;
                }                
                return getDeadStar(rollDead, ind);
            }
            else if (10 < roll && roll <= 20)
            {
                return Star.Y_Star;
            }
            else if (20 < roll && roll <= 33)
            {
                return Star.L_Star;
            }
            else if (33 < roll && roll <= 52)
            {
                return Star.M_Star;
            }
            else if (52 < roll && roll <= 63)
            {
                return Star.K_Star;
            }
            else if (63 < roll && roll <= 74)
            {
                return Star.G_Star;
            }
            else if (74 < roll && roll <= 85)
            {
                return Star.F_Star;
            }
            else if (84 < roll && roll <= 95)
            {
                return Star.O_Star;
            }
            else if (95 < roll && roll <= 100)
            {
                int rollLiving = RollRandom(1, 100);
                if (ind >= 0)
                {
                    powerStarRoll[ind].Text += " > " + rollLiving;
                }
                return getLivingStar(rollLiving, ind);
            }

            return Star.No_Star;
        }

        private Star getDeadStar(int roll, int ind)
        {
            if (roll <= 10)
            {
                return Star.Black_Hole;
            }
            else if (10 < roll && roll <= 33)
            {
                return Star.D1_Star;
            }
            else if (33 < roll && roll <= 50)
            {
                return Star.D2_Star;
            }
            else if (50 < roll && roll <= 85)
            {
                return Star.Failed_Star;
            }
            else if (85 < roll && roll <= 100)
            {
                int rollAgain = RollRandom(1, 100);
                if (ind >= 0)
                {
                    powerStarRoll[ind].Text += " > " + rollAgain;
                }
                return getStar(rollAgain, ind);
            }
            return Star.Dead_Star;
        }

        private Star getLivingStar(int roll, int ind)
        {
            if (roll <= 10)
            {
                int rollAgain = RollRandom(1, 100);
                if (ind >= 0)
                {
                    powerStarRoll[ind].Text += " > " + rollAgain;
                }
                return getStar(rollAgain, ind);
            }
            else if (10 < roll && roll <= 25)
            {
                return Star.Supernova;
            }
            else if (25 < roll && roll <= 51)
            {
                return Star.Exotic_Star;
            }
            else if (51 < roll && roll <= 79)
            {
                return Star.Binary_Star;
            }
            else if (79 < roll && roll <= 89)
            {
                return Star.Star_Forge;
            }
            else if (89 < roll && roll <= 99)
            {
                return Star.Quasar;
            }
            else if (99 < roll && roll <= 100)
            {
                return Star.White_Hole;
            }
            return Star.Living_Star;
        }

        private Manifestation getManifestation(int roll)
        {
            if (roll <= 65)
            {
                return Manifestation.Normal;
            }
            else if(65 < roll && roll <= 76)
            {
                return Manifestation.Drugged;
            }
            else if (76 < roll && roll <= 85)
            {
                return Manifestation.Overdose;
            }
            else if (85 < roll && roll <= 95)
            {
                return Manifestation.Near_Death;
            }
            else if (95 < roll && roll <= 99)
            {
                return Manifestation.After_Death;
            }
            else if (roll == 100)
            {
                return Manifestation.Returner;
            }

            return Manifestation.Normal;
        }

        private Dream getDream(int roll, int ind)
        {
            Dream dream = new Dream();
            if (roll <= 2)
            {
                dream = Dream.Wetness;
            }
            else if (roll > 2 && roll <= 4)
            {
                dream = Dream.Fragments;
            }
            else if (roll > 4 && roll <= 6)
            {
                dream = Dream.Power;
            }
            else if (roll > 6 && roll <= 8)
            {
                dream = Dream.Peace;
            }
            else if (roll > 8 && roll <= 10)
            {
                dream = Dream.Friends;
            }
            else if (roll > 10 && roll <= 12)
            {
                dream = Dream.Freedom;
            }
            else if (roll > 12 && roll <= 14)
            {
                dream = Dream.Forests;
            }
            else if (roll > 14 && roll <= 16)
            {
                dream = Dream.Life;
            }
            else if (roll > 16 && roll <= 18)
            {
                dream = Dream.Family;
            }
            else if (roll > 18 && roll <= 20)
            {
                dream = Dream.Love;
            }
            else if (roll > 20 && roll <= 22)
            {
                dream = Dream.Colours;
            }
            else if (roll > 22 && roll <= 24)
            {
                dream = Dream.Harmony;
            }
            else if (roll > 24 && roll <= 26)
            {
                dream = Dream.Riches;
            }
            else if (roll > 26 && roll <= 28)
            {
                dream = Dream.Flying;
            }
            else if (roll > 28 && roll <= 30)
            {
                dream = Dream.Home;
            }
            else if (roll > 30 && roll <= 32)
            {
                dream = Dream.Rest;
            }
            else if (roll > 32 && roll <= 34)
            {
                dream = Dream.Angels;
            }
            else if (roll > 34 && roll <= 36)
            {
                dream = Dream.Yourself;
            }
            else if (roll > 36 && roll <= 38)
            {
                dream = Dream.Defiance;
            }
            else if (roll > 38 && roll <= 40)
            {
                dream = Dream.Progeny;
            }
            else if(roll == 41)
            {
                dream = Dream.Fantasia;
            }

            int dc;
            Int32.TryParse(dreamCount[ind - 1].Text, out dc);
            if (dream.Stack != 0 && dc + 1 > dream.Stack)
            {
                roll = RollRandom(1, 41);
                dreamRolled[ind - 1].Text = "" + roll;
                dream = getDream(roll, ind);
            }

            return dream;
        }

        private Nightmare getNightmare(int roll, int ind)
        {
            Nightmare nightmare = new Nightmare();
            if (roll <= 2)
            {
                nightmare = Nightmare.Secrets;
            }
            else if (roll > 2 && roll <= 4)
            {
                nightmare = Nightmare.Lost_Woods;
            }
            else if (roll > 4 && roll <= 6)
            {
                nightmare = Nightmare.Loss;
            }
            else if (roll > 6 && roll <= 8)
            {
                nightmare = Nightmare.Enemies;
            }
            else if (roll > 8 && roll <= 10)
            {
                nightmare = Nightmare.Shadows;
            }
            else if (roll > 10 && roll <= 12)
            {
                nightmare = Nightmare.Monsters;
            }
            else if (roll > 12 && roll <= 14)
            {
                nightmare = Nightmare.The_Dead;
            }
            else if (roll > 14 && roll <= 16)
            {
                nightmare = Nightmare.A_Witch;
            }
            else if (roll > 16 && roll <= 18)
            {
                nightmare = Nightmare.Abuse;
            }
            else if (roll > 18 && roll <= 20)
            {
                nightmare = Nightmare.Lunacy;
            }
            else if (roll > 20 && roll <= 22)
            {
                nightmare = Nightmare.Strangers;
            }
            else if (roll > 22 && roll <= 24)
            {
                nightmare = Nightmare.Discord;
            }
            else if (roll > 24 && roll <= 26)
            {
                nightmare = Nightmare.A_Fall;
            }
            else if (roll > 26 && roll <= 28)
            {
                nightmare = Nightmare.Shame;
            }
            else if (roll > 28 && roll <= 30)
            {
                nightmare = Nightmare.Demons;
            }
            else if (roll > 30 && roll <= 32)
            {
                nightmare = Nightmare.The_Unknown;
            }
            else if (roll > 32 && roll <= 34)
            {
                nightmare = Nightmare.Lack;
            }
            else if (roll > 34 && roll <= 36)
            {
                nightmare = Nightmare.Fatigue;
            }
            else if (roll > 36 && roll <= 38)
            {
                nightmare = Nightmare.Lust;
            }
            else if (roll > 38 && roll <= 40)
            {
                nightmare = Nightmare.Your_Bane;
            }
            else if (roll == 41)
            {
                nightmare = Nightmare.The_Abyss;
            }

            int dc;
            Int32.TryParse(nightmareCount[ind - 1].Text, out dc);
            if (nightmare.Stack != 0 && dc + 1 > nightmare.Stack)
            {
                roll = RollRandom(1, 41);
                dreamRolled[ind - 1].Text = "" + roll;
                nightmare = getNightmare(roll, ind);
            }

            return nightmare;
        }

        private void fillCharacterStats()
        {
            textBox_Dreams.Text = "" + character.TotalDreams;
            textBox_Nightmares.Text = "" + character.TotalNightmares;
            textBox_Derangements.Text = "" + character.TotalDerangement;
            if(character.Manifestation != null)
            {
                textBox_Adonis.Text = "" + character.Manifestation.AdonisChance;
                textBox_Shadow.Text = "" + character.Manifestation.ShadowChance;
            }  
        }
    }
}
