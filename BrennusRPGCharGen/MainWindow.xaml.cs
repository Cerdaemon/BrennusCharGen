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

        List<TextBox> linkTierRoll = new List<TextBox>();
        List<Label> linkTierTypes = new List<Label>();

        List<TextBox> linkStarRoll = new List<TextBox>();
        List<Label> linkStarTypes = new List<Label>();


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
            textBox_Manifestation_Type.Text = "" + getManifestation(rollD100).Type;
            
        }

        private int RollRandom(int low, int high) {

            Random rnd = new Random();

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
                linkStarTypes[index - 1].Content = "" + getStar(roll).Type;
            }

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

        private Star getStar(int roll)
        {
            if (roll <= 10)
            {
                return Star.Dead_Star;
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
                return Star.Living_Star;
            }


            return Star.No_Star;
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
    }
}
