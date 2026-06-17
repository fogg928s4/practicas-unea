import views.public.Intervalo

class Test {
    // No se han creado obj, solo referencias
    // el new es como arrays, son ref a objettos
    Intervalo[] intervalos = new Intervalos[100];

    // aqui si se cren los obj
    for(int i = 0; i < intervalos.length; i++)
        intervalos[i] = new Intervalo();
}
