/*
 * Author: Eric Honas
 * Class name: ComboCustomization.xaml.cs
 * Purpose: A component used for customizing a combo meal.
 */

using BleakwindBuffet.Data.Classes;
using BleakwindBuffet.Data.Interfaces;
using PointOfSale.Interfaces;
using System.Windows;
using System.Windows.Controls;

namespace PointOfSale.Screens.Menus
{
    /// <summary>
    /// A class that customizes a combo meal.
    /// </summary>
    public partial class ComboCustomization : CustomizationScreen
    {
        /// <summary>
        /// Creates a new ComboCustomization Component.
        /// </summary>
        public ComboCustomization()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Swaps to the customization screen of the chosen item.
        /// </summary>
        /// <param name="sender">The button that was clicked</param>
        /// <param name="e">The event arguments.</param>
        private void CustomizeItemClicked(object sender, RoutedEventArgs e)
        {
            if(sender is Button b)
            {
                if(DataContext is Combo combo)
                {
                    IMenuScreen menu = this.GetParent<ItemCustomization>();
                    if (menu == null) menu = this.GetParent<ItemModification>();

                    ItemModification modifier = new ItemModification();

                    IOrderItem item = combo.Entree;
                    if ((string)b.Tag == "1") item = combo.Drink;
                    else if ((string)b.Tag == "2") item = combo.Side;

                    CustomizationScreen screen = Helper.GetCustomizationScreen(item, out string text);
                    modifier.customizeItemLabel.Text = text;

                    screen.DataContext = item;
                    modifier.customizationContainer.Child = screen;
                    modifier.ReturnScreen = menu as UserControl;

                    menu.OrderComponent.ChangeScreen(modifier);
                }
            }
        }

        /// <summary>
        /// Goes to a menu where the item can be changed.
        /// </summary>
        /// <param name="sender">The button that was clicked.</param>
        /// <param name="e">The event arguments</param>
        private void ChangeItemClicked(object sender, RoutedEventArgs e)
        {
            if(sender is Button b)
            {
                if(DataContext is Combo combo)
                {
                    IMenuScreen menu = this.GetParent<ItemCustomization>();
                    if (menu == null) menu = this.GetParent<ItemModification>();

                    MenuSelectionScreen screen = new MenuSelectionScreen((string)b.Tag == "0", (string)b.Tag == "1", (string)b.Tag == "2");

                    screen.ReturnScreen = menu as UserControl;
                    screen.DataContext = combo;
                    screen.OrderComponent = this.GetParent<OrderComponent>();

                    menu.OrderComponent.ChangeScreen(screen);
                }
            }
        }
    }
}
