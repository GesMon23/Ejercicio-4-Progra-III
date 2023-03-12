internal class Program
{
    private static void Main(string[] args)
    {
        string nombre = " ", apellidos = " ", dire = " ",op_Salida=" ",salida_Prog=" ", servicios=" ", op_Ins=" ", srvcs_Contratados=" ";
        double codigo = 0, cost_Inst = 0, cost_Tec = 0, desc = 0, cuot_Desc = 0,plan_Bronce=0, plan_Oro=0,plan_Plati=0, conta_Bronce = 0, conta_Oro = 0, conta_Plati = 0, precio=0, subtotal=0, total=0;
        bool salida=false, salida_Program=false;
        int op=0, op_Plan=0;
        do
        {
            Console.WriteLine("BIENVEIDO AL SISTEMA DE CONTRATACÍÓN DE SERVICIOS");
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("----------POR FAVOR, INGRESA TUS DATOS-----------");
            Console.Write("Nombre:\t");
            nombre = Console.ReadLine();
            Console.Write("Apellidos: ");
            apellidos = Console.ReadLine();
            Console.Write("Dirección: ");
            dire = Console.ReadLine();
            do
            {
                Console.WriteLine("\n\n-------------------------------------------------");
                Console.WriteLine("------TE OFRECEMOS LOS SIGUIENTES SERVICIOS------");
                Console.WriteLine("1. Telefonía");
                Console.WriteLine("2. Cable");
                Console.WriteLine("3. Internet");
                Console.WriteLine("4. Salir\n");
                Console.Write("Ingresa la opción que deseas:\t");
                op = int.Parse(Console.ReadLine());
                if (op == 4)
                {
                    salida = true;
                }
                else
                {
                    Console.WriteLine("\n-------------------------------------------------");
                    Console.WriteLine("-------TE OFRECEMOS LOS SIGUIENTES PLANES--------");
                    switch (op)
                    {
                        case 1:
                            plan_Bronce = 100;
                            plan_Oro = 200;
                            plan_Plati = 300;
                            servicios = "\tTelefonía: \n\t";
                            break;
                        case 2:
                            plan_Bronce = 150;
                            plan_Oro = 250;
                            plan_Plati = 350;
                            servicios = "\tCable: \n\t";
                            break;
                        case 3:
                            plan_Bronce = 200;
                            plan_Oro = 300;
                            plan_Plati = 400;
                            servicios = "\tInternet: \n\t";
                            break;
                    }
                    Console.WriteLine("1. Plan Bronce:\t\tQ" + plan_Bronce);
                    Console.WriteLine("2. Plan Oro:\t\tQ" + plan_Oro);
                    Console.WriteLine("3. Plan Platinum:\tQ" + plan_Plati);
                    Console.WriteLine("¿Qué plan es el que te deseas?");
                    op_Plan = int.Parse(Console.ReadLine());
                    switch (op_Plan)
                    {
                        case 1:
                            precio = plan_Bronce;
                            conta_Bronce += 1;
                            servicios += "\tPlan Bronce:\tQ" + precio + "\n";
                            break;
                        case 2:
                            precio = plan_Oro;
                            conta_Oro += 1;
                            servicios += "\tPlan Oro:\tQ" + precio + "\n";
                            break;
                        case 3:
                            precio = plan_Plati;
                            conta_Plati += 1;
                            servicios += "\tPlan Platino:\tQ" + precio + "\n";
                            break;
                    }
                    subtotal += precio;
                    srvcs_Contratados += servicios;
                    Console.WriteLine("¿Estas interesado en otro servicio? Si/No");
                    op_Salida = Console.ReadLine();
                    if (op_Salida == "No" || op_Salida == "NO" || op_Salida == "no" || op_Salida == "nO")
                    {
                        salida = true;
                    }
                }
            } while (salida != true);
            Console.WriteLine("¿Es primera instalación de servicios? Si/No");
            op_Ins = Console.ReadLine();
            if (op_Ins == "Si" || op_Ins == "si" || op_Ins == "SI" || op_Ins == "sI")
            {
                Random random = new Random();
                codigo = random.Next(1000, 9000);
                cost_Inst = 100;
                cost_Tec = 125;
            }
            else
            {
                Console.WriteLine("Ingresa tu código de 4 dígitos");
                codigo = double.Parse(Console.ReadLine());
            }
            if (conta_Bronce == 2)
            {
                cuot_Desc = 0.05;
            }
            else if (conta_Bronce >= 3)
            {
                cuot_Desc = 0.06;
            }
            if (conta_Oro == 2)
            {
                cuot_Desc = 0.07;
            }
            else if (conta_Oro >= 3)
            {
                cuot_Desc = 0.08;
            }
            if (conta_Plati == 2)
            {
                cuot_Desc = 0.10;
            }
            else if (conta_Plati >= 3)
            {
                cuot_Desc = 0.12;
            }
            desc = subtotal * cuot_Desc;
            total = subtotal - desc + cost_Inst + cost_Tec;
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("---------------------FACTURA---------------------");
            Console.WriteLine("Nombre:\t\t\t" + nombre + " " + apellidos);
            Console.WriteLine("Dirección:\t\t" + dire);
            Console.WriteLine("Código:\t\t\t" + codigo);
            Console.WriteLine("Servicios contratados: \n" + srvcs_Contratados);
            Console.WriteLine("Subtotal: \t\t\tQ" + subtotal);
            Console.WriteLine("Descuento realizado: \t\tQ" + desc);
            Console.WriteLine("Costo de Instalación: \t\tQ" + cost_Inst);
            Console.WriteLine("Gastos de equipo técnico:   \tQ" + cost_Tec);
            Console.WriteLine("Total a pagar: \t\t\tQ" + total);
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("-------------------------------------------------\n\n\n");
            Console.WriteLine("¿Deseas ingresar a un nuevo cliente? Si/No");
            salida_Prog = Console.ReadLine();
            if (salida_Prog == "No" || salida_Prog == "NO" || salida_Prog == "no" || salida_Prog == "nO")
            {
                salida_Program = true;
                Console.WriteLine("\n\n\n\n");
            }
        } while (salida_Program != true);
        }
        
}