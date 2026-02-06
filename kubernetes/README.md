# Kubernetes

Kubernetes es una plataforma de código abierto para automatizar la implementación, el escalado y la administración de aplicaciones en contenedores.

## Conceptos claves

### Clusters
> Un cluster consiste en un plano de control junto con nodos que corren aplicaciones contenerizadas.



### Pods
> Los Pods son las unidades de computación desplegables más pequeñas que se pueden crear y gestionar en Kubernetes. 

Son grupos de uno o más contenedores (que pueden ser de Docker) con almacenamiento y red compartidos. Son como tener una VM con varios servicios dentro de la misma, imitando un host lógico.
Los contenedores dentro de un Pod comparten dirección IP y puerto, y pueden encontrarse a través de localhost. También pueden comunicarse entre sí mediante comunicaciones estándar como SystemV o memoria compartida de POSIX. Contenedores en distintos pods no pueden comunicarse entre si al tener distintas IPs.

### kubelet
Se asegura de los *pods* estén corriendo y activos, junto con sus contenedores.

![Esquema](https://kubernetes.io/images/docs/kubernetes-cluster-architecture.svg)

### Deployment
Un deployment maneja los pods para mantener la carga de trabajo de una aplicación. Un controlador de Deployment proporciona actualizaciones declarativas para los Pods y los ReplicaSets.

#### Escalar un deployment

**ReplicationController** garantiza que un número determinado de réplicas se estén ejecutando en todo momento. En otras palabras, un ReplicationController se asegura que un pod o un conjunto homogéneo de pods siempre esté arriba y disponible.

**ReplicationSet** 

### Port vs TargetPort
Una aplicación puede declarar cualquier puerto de entrada a aun targetPort, aunque suele ser por conveniencia el mismo valor del puerto. El campo targetPort asegura que el tráfico llegué a la aplicación de destino. 

### Namespace
Un namespace permite aislar grupos de recursos desde un mismo clúster. Solo aplica para objetos de un namespace, como deployments, servicios y no para objetos que abarquen todo un cluster como nodos, StorageClass o volumenes.3

![Namespace](https://stacksimplify.com/course-images/azure-kubernetes-service-namespaces-2.png)

Estos pueden ir incluidos dentro del nombre de dns del cluster de la siguiente forma: `<servicio>.<namespace>.svc.cluster.local`. 

Podemos ver los namespaces disponibles con `kubectl get ns`.



## Red y Networking

### Service
> In Kubernetes, a Service is a method for exposing a network application that is running as one or more Pods in your cluster.

Expose an application running in your cluster behind a single outward-facing endpoint, even when the workload is split across multiple backends.

### Ingress
Ingress makes your *HTTP* (or *HTTPS*) network service available using a protocol-aware configuration mechanism, that understands web concepts like URIs, hostnames, paths, and more. The Ingress concept lets you map traffic to different backends based on rules you define via the Kubernetes API.

![Ingress](https://kubernetes.io/docs/images/ingress.svg)



## Docker desde un registry
En un entorno profesional de Kubernetes, el uso de imágenes sigue un flujo técnico preciso que involucra al Kubelet (el agente que corre en cada nodo), el Container Runtime (como containerd o Docker Engine) y el Registry externo.

Cuando creas un Pod, Kubernetes no tiene la imagen guardada en su base de datos. Debe descargarla a cada Nodo donde se vaya a ejecutar el Pod.

Un ejemplo de como tomar una imagen desde un registry privado sería

```bash
kubectl create secret docker-registry regcred \
  --docker-server=https://index.docker.io/v1/ \
  --docker-username=<tu-usuario> \
  --docker-password=<tu-password> \
  --docker-email=<tu-email>
```



## Kubectl

`kubectl` es la herramienta de línea de comandos estándar para comunicarse con el API Server de Kubernetes. Es tu "panel de control" principal.

### Apply
El comando apply sirve para aplicar los cambios en base a un archivo yaml.

```bash
kubectl -f [archivo-de-configiracion].yaml
```

### Get
Sirve para listar recursos y ver su estado general. 

```bash
# Get commands with basic output
kubectl get services                 # List all services in the namespace
kubectl get pods --all-namespaces    # List all pods in all namespaces
kubectl get pods -o wide             # List all pods in the current namespace, with more details
kubectl get deployment my-dep        # List a particular deployment
kubectl get pods                     # List all pods in the namespace
kubectl get pod my-pod -o yaml       # Get a pod's YAML
kubectl get secret my-secret       # Get a pod's YAML
```

### Describe
El comando `kubectl get` te dice qué está pasando (ej. "Error"), describe te dice por qué. Es fundamental para el troubleshooting. 

### Logs
El comando `kubectl logs <nombre-del-pod>`. muestra lo que está saliendo de STDOUT y STDERR. Es muy similar al comando `tail -f` en Linux si se agrega la flag `-f`.

