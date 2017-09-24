using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace eXam
{
    public class HomePage : ContentPage
    {
        Button button = null;
        public HomePage()
        {
            NavigationPage.SetHasNavigationBar(this, false);

            AbsoluteLayout layout = new AbsoluteLayout();
            this.Content = layout;

            Image image = new Image {
                Source = ImageSource.FromResource("eXam.Images.background.jpg"),
                Aspect = Aspect.AspectFill };

            layout.Children.Add(
                view: image, 
                bounds: new Rectangle(x: 0, y: 0, width: 1, height: 1), 
                flags: AbsoluteLayoutFlags.SizeProportional);

            this.button = new Button {
                Text = "Start eXam!",
                BackgroundColor = Color.LightCoral,
                Font = Font.SystemFontOfSize(20)
            };
            layout.Children.Add(view: button, 
                bounds: new Rectangle(x: 0.5, y: 0.5, width: 150, height: 60), 
                flags: AbsoluteLayoutFlags.PositionProportional);

            

        }

        private async void StartButton_Clicked(object sender, EventArgs e)
        {
            var viewModel = new QuestionPageViewModel(App.CurrentGame);
            await this.Navigation.PushAsync(new QuestionPage(viewModel));         
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            this.button.Clicked += StartButton_Clicked;
        }

        protected override void OnDisappearing()
        {
            this.button.Clicked -= StartButton_Clicked;
            base.OnDisappearing();
        }

    }
}