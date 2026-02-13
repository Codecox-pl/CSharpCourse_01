namespace _02_EventosLambda
{
    public class MiClaseLambda
    {
        private string theVal;
        public event miEventoHandler valueChanged;

        public string Val
        {
            set { 
                theVal = value; 
                this.valueChanged(theVal); 
            } 
        }
    }
}
