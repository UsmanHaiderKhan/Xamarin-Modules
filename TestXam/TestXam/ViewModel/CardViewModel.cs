using System.Collections.Generic;
using System.Collections.ObjectModel;
using TestXam.Model;

namespace TestXam.ViewModel
{
    public class CardViewModel
    {
        public IList<CardData> CardCollection { get; set; }
        public object SelectedItem { get; set; }

        public CardViewModel()
        {
            CardCollection = new List<CardData>();
            GenerateCardModel();
        }

        private void GenerateCardModel()
        {
            //for (var i = 0;  i< 10; i++)
            //{
            CardCollection = new ObservableCollection<CardData>()
                {
                    new CardData()
                    {
                        HeadTitle = "1 day ago -ON facebook ",
                        HeadLines = "Am Waiting for the class at evs lahore",
                        ProfileImage = "usman.png",
                        HeadDes = "a written or spoken statement about something that enables a reader or listener to picture it I recognized the place from your description"
                    },
                    new CardData()
                    {
                        HeadTitle = "9 hour ago -ON Instagram ",
                        HeadLines = "Am Waiting for the class at evs lahore",
                        ProfileImage = "usman.png",
                        HeadDes = "a written or spoken statement about something that enables a reader or listener to picture it I recognized the place from your description"
                    },
                    new CardData()
                    {
                        HeadTitle = "5 day ago -ON Twitter ",
                        HeadLines = "Am Waiting for the class at evs lahore",
                        ProfileImage = "usman.png",
                        HeadDes = "a written or spoken statement about something that enables a reader or listener to picture it I recognized the place from your description"
                    },
                    new CardData()
                    {
                        HeadTitle = "5 mint ago -ON what'sapp ",
                        HeadLines = "Am Waiting for the class at evs lahore",
                        ProfileImage = "usman.png",
                        HeadDes = "a written or spoken statement about something that enables a reader or listener to picture it I recognized the place from your description"
                    },
                };
            //  }
        }
    }
}
