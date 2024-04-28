

namespace Tarea2TercerItem.Class
{
    public class Main
    {
        public void Caculo() {

            int PrimeraNota = 0;
            int SegundaNota = 0;
            int TerceraNota = 0;

            try
            {

                Console.WriteLine("Ingrece la primera nota:");
                PrimeraNota = Convert.ToInt32(Console.ReadLine());

                if (PrimeraNota >= 7) {
                    Console.WriteLine("Promocionado");

                }
                else if (PrimeraNota >= 4 && PrimeraNota < 7)
                {
                    Console.WriteLine("Regular");
                }

                else if (PrimeraNota <4){

                    Console.WriteLine("Reprobado");
                        }
                //esto es un salto de linea
                Console.WriteLine();


                Console.WriteLine("Ingrece la segunda nota:");
                SegundaNota = Convert.ToInt32(Console.ReadLine());

                if (SegundaNota >= 7)
                {
                    Console.WriteLine("Promocionado");

                }
                else if (SegundaNota >= 4 && SegundaNota < 7)
                {
                    Console.WriteLine("Regular");
                }

                else if (SegundaNota < 4)
                {

                    Console.WriteLine("Reprobado");
                }

                //esto es un salto de linea
                Console.WriteLine();


                Console.WriteLine("Ingrece la tercer nota:");
                TerceraNota = Convert.ToInt32(Console.ReadLine());

                if (TerceraNota >= 7)
                {
                    Console.WriteLine("Promocionado");

                }
                else if (TerceraNota >= 4 && TerceraNota < 7)
                {
                    Console.WriteLine("Regular");
                }

                else if (TerceraNota < 4)
                {

                    Console.WriteLine("Reprobado");
                }


            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ocurrio un error al ingresar los datos{ ex}");
            
            
            }
                
                
               



}
    }
}
