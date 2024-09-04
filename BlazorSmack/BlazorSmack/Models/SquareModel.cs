namespace BlazorSmack.Models
{
    public class SquareModel
    {
        //Variable privada que almacena un valor booleno que indica si se muestra o no el cuadrado
        private bool isShown;
        //Id: el Identificador del cuadrado
        public int Id { get; set; }
        //Una propiedad que almacena el estilo CSS para el cuadrado
        public string Style { get; set; }

        public bool IsShown
        {
            //El getter devuelve la el valor de la variable privada isShown.
            get => isShown;
            //El setter establece el valor de la variable privada isShown y tambien actualiza
            //la propiedad Style en funcion del valor de isShown
            //Si isShown es true, Stlyle es "mole", sino es vacio
            
            set
            {
                isShown = value;
                if (isShown)
                {
                    Style = "square";
                }
                else
                {
                    Style = "";
                }
            }
        }
    }
}
