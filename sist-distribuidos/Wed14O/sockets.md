# Sockets

`System.NET.Sockets` es el dll que se usa para acceder a la red de bajo nivel. Nos permite elegir el protocolo incluso como TCP, UDP, etc. Es una librería de bajo nivel.

A partir de aqui, cada solución tendrá dos proyectos: un **server**, y un **client**.

## Server v Client

El servidor espera una respuesta, y luego responde. El cliente es al revés: envía un mensaje y luego espera una respuesta.