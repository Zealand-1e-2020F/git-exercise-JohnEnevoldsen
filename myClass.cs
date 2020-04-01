namespace GitExercise
{
    class myClass
    {
        private string _navn;
        private string _adresse;
        private int _postNr;
        public string Navn{
            get{return _navn;}
            set{_navn = value;}
        }
        public string Adresse{
            get{return _adresse;}
            set{_adresse = value;}
        }
        public int PostNr{
            get{return _postNr;}
            set{_postNr = value;}
        }
    }
}