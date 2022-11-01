namespace BiblioCalculadora
{
    public class CalculadoraString
    {
        /*
        public int Add(string numeros)
        {
            if (string.IsNullOrEmpty(numeros))
            {
                return 0;
            }
            else
            {
                return int.Parse(numeros);
            }
        }
        */
        /*
        public int Add(string numeros)
        {

            string[] partes = numeros.Split(',') ;//por cada , crea un indice nuevo

            if (string.IsNullOrEmpty(numeros))
            {
                return 0;
            }
            else
            {
                if (partes.Length == 1)//si hay solo un elemento retorno el numero
                {
                    return int.Parse(numeros);
                }
                else
                {
                    return int.Parse(partes[0]) + int.Parse(partes[1]);//sumo dos numeros
                }
            }
           
        }
        
        public int Add(string numeros)
        {

            string[] partes = numeros.Split(',');//por cada , crea un indice nuevo

            if (string.IsNullOrEmpty(numeros))
            {
                return 0;
            }
            else
            {
             
                int totalNumero = 0;
                foreach (string numero in partes)
                {
                    totalNumero += int.Parse(numero);
                }
                return totalNumero;                
            }

        }
        public int Add(string numeros)
        {

            string[] partes = numeros.Split(new char[] {',','\n'});//por cada , crea un indice nuevo

            if (string.IsNullOrEmpty(numeros))
            {
                return 0;
            }
            else
            {

                int totalNumero = 0;
                foreach (string numero in partes)
                {
                    totalNumero += int.Parse(numero);
                }
                return totalNumero;
            }

        }
        */
        public int Add(string numeros)
        {

           

            if (string.IsNullOrEmpty(numeros))
            {
                return 0;
            }
            else
            {
                if (numeros.StartsWith("//"))//verifico si comienza con barras entonces acepto todo tipo de caracter
                {
                    char separador = numeros[2];//caracter que se encuentra en el tercer elemento es el separador
                    numeros = numeros.Substring(2);//uso lista a partir de la seleccion indicada
                    numeros = numeros.Replace(separador, ',');//reemplazo los puntos por comas

                }
                string[] partes = numeros.Split(new char[] { ',', '\n' }, StringSplitOptions.RemoveEmptyEntries);//por cada , crea un indice nuevo. StringSplitOptions.RemoveEmptyEntries saco espacios vacios

                int totalNumero = 0;
                foreach (string numero in partes)
                {
                    if (int.Parse(numero) < 0)
                    {
                        throw new NegativoNoPermitidoExcpetion();
                    }
                    totalNumero += int.Parse(numero);
                }
                return totalNumero;
            }

        }

    }
}