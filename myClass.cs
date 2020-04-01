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
        public myClass(string navn, string adresse){
            _navn = navn;
            _adresse = adresse;
        }
        public override string ToString(){
            return $"Hej jeg hedder {_navn} og jeg bor ved {_adresse}. Postnummeret er {_postNr}";
        }
    }
}