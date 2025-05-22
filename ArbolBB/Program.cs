using ArbolBusBin;

ArbolBB ar = new ArbolBB();
ar.Agrega(7);
ar.Agrega(4);
ar.Agrega(10);
ar.Agrega(1);
ar.Agrega(6);
ar.Agrega(9);
ar.ImprimePre();
ar.ImprimeIn();
ar.ImprimePos();
Console.WriteLine($"El mayor valor del arbol es: {ar.ObtenMayor()}");
Console.WriteLine($"Numero de nodos hojas: {ar.ContarHojas()}");
