## Intro a la progr async en .NET

> [!IMPORTANT]  
> Esto no entra en el parcial 1

La programación asíncrona es hacer múltiples cosas a la vez. Las tareas o procesos no "FIN A COMIENZO". En .NET se hace con la clase **Task<T>**, que es parte de la librería **Task Parallel Library**. Se basa en Promesas. La clase `Task<T>` representa una operación que devuelve (o promete devolver) un valor del tipo `T`. No debe de confundirse con una abstracción de los Threads.

> Míralo como el coso del 100 Montaditos que te dice cuando està tu comida. No te lo da, pero te lo promete con esa "garantía"

La keyword `async` convierte un método en asíncrono y permite usar `await` en su interior. Es recomendable que devuelvan un obj de tipo `Task<T>`. `await` devuelve el control al método que lo invocó.

```C#
// Tmbn se puede poner aqui el await para seguir al otro metodo y continuar la ejecucion
Task<string> getStringTask = client.GetStringAsync("example.com");

DoSomeOtherStuff();

await urlContents = await getStringTask;

```

## Desayuno

Es como cocinar un desayuno. En vez de esperar a q se caliente el cafe y luego hacer los huevos, hacemos los huevos MIENTRAS se calienta el café. 

Pero! Solo hay UN cocinero (vos)... si hubiera más de uno, sería **parelelismo**. La asincronía se basa en **aprovechar huecos** libres de ejecución para hacer algo más.