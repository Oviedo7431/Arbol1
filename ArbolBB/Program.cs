using ArbolBusBin;

ArbolBB ar = new ArbolBB();
ar.Agrega(1);
ar.Agrega(4);
ar.Agrega(3);
ar.Agrega(2);
ar.Agrega(5);
ar.Agrega(6);
ar.ImprimePre();
ar.ImprimeIn();
ar.ImprimePos();
Console.WriteLine($"El mayor valor del arbol es: {ar.ObtenMayor()}");
Console.WriteLine($"Numero de nodos hojas: {ar.ContarHojas()}");
Console.WriteLine(ar.VerifConsecutivo());
