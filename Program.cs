//Alexis Adrian Abarca Arguello 
namespace MENU
{
    class program
    {
        private static object console;
        private static object writeLine;

        static string Main (string[] args)
        {
            bool continuar = true; 
            while (continuar)
            {
                //Menu de opciones 
                console.clear();
                object value1 = console.writeLine("----MENU de tienda de Anime----");
                console.writeLine("1-) OPCION 1");
                console.writeLine("2-) OPCION 2");
                console.writeLine("3-) OPCION 3");
                console.writeLine("4-) OPCION 4");
                console.writeLine("INGRESA UNA OPCION PARA CONTINUAR");
                int opcion = Convert.ToInt32(console.ReadLine());
                switch (opcion)
                {
                    case 1:
                         console.writeLine("Has entrado a la opcion playeras 1");
                         console.writeLine("presiona cualquier tecla para continuar");
                         console.Readkey();
                      break;
                    case 2:
                       console.writeLine("Has entrado a la opcion juguetes 2");
                       console.writeLine("presiona cualquier tecla para continuar");
                       console.Readkey();
                       break;
                     case 3:
                         console.writeLine("Has entrado a la opcion llaveros 3");
                         console.writeLine("presiona cualquier tecla para continuar");
                         console.Readkey();
                        break;
                     case 4:
                        object value = console.if (true)
                        {
                            writeLine
                        }("Esta seguro que desae salir?");
                       console.writeLine("si/no");
                       string deside = console.writeLine();
                       if (deside == "si")
                       {
                        continuar = false;
                       }
                       break;
                    default:
                     console.writeLine("Ustede ha ingresado una opcion no valida initente de nuevo . :");
                        break;

                }

            }
       
        }
    }
  
}  