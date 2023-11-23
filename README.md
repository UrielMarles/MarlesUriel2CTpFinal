![logo-proyecto](RENT-A-TRONIC/IMAGENES/FONDOS/TITULO.gif)
# Rent-a-tronic - Entrega 2do TP Integrador

**Alumno:** Uriel Nicolás Marlés  
**División:** 2C

## Objetivo del Programa

Rent-a-tronic es un programa diseñado para una empresa que alquila animatrónicos para fiestas infantiles. El objetivo de la empresa es generar ingresos y recolectar esencia de las almas de los niños.

## Funcionalidades del Programa

- Sistema de usuarios que diferencia entre administradores y empleados comunes, ocultando información confidencial a los empleados.
- Agenda personal para cada animatrónico, permitiendo la reserva de fiestas solo en fechas disponibles.
- Cada fiesta puede tener hasta tres animatrónicos (relación en una tabla intermedia).
- Interfaz de edición y barra de búsqueda para entidades (animatrónicos, fiestas, usuarios).
- Desactivación automática de fiestas pasadas, manteniendo un historial y calculando ingresos y almas recolectadas.
- Historial del empleado encargado de cada fiesta y cantidad de fiestas realizadas por cada empleado.
- Importación y exportación de datos desde y hacia archivos CSV, con posibilidad de crear backups sin sobrescribir.

## Aplicación de Temas Requeridos

### Excepciones

- Archivo `Scripts/Excepciones.cs` con excepciones personalizadas utilizadas en el programa.
- Cada excepción se maneja en un contexto específico, diferenciándola de excepciones no controladas.
- Formulario creado para mostrar un desglose de excepciones no manejadas.

### Pruebas Unitarias

- Proyecto `TESTS` que contiene pruebas unitarias verificando la correcta comunicación con la base de datos, envío y modificación de información.

### Interfaces

- Interfaz `IEntidades` para conectar el comportamiento común de todas las entidades.

### Genéricos

- Uso de genéricos en el formulario `FrmTablas<T>` y la clase `ColeccionEntidades<T>`.
- `FrmTablas` recibe una clase que implementa `IEntidades` y crea un formulario mostrando una tabla y las formas de interactuar con ella.
- `ColeccionEntidades` filtra entidades dentro de su colección utilizando diferentes métodos.

### Archivos

- Comunicación con archivos en la clase estática `FilesManager` que se encarga de escritura, lectura y traducción.

### Delegados y Eventos

- Uso de eventos como `eventoUsuarioObtenido` y `eventoCerrando`.
- `eventoUsuarioObtenido` avisa a los suscriptores que se recibió un nuevo usuario, actualizando la información sin recrear formularios.
- `eventoCerrando` permite informar al formulario principal sobre el cierre de la aplicación desde un formulario hijo.

### Lambda

- Ejemplos de lambda en el evento `eventoUsuarioObtenido` y la función que muestra un error en la tabla durante 5 segundos.

### Multihilo/Asincronismo

- Uso de asincronismo en los botones de `frmTabla`, donde los mensajes están temporizados con `Task.Sleep()` sin bloquear la interacción con el programa.

### Conexión a Base de Datos / SQL

- Generación dinámica de comandos SQL en la clase `ConexionConTabla`.
- Única instancia de la clase `ConexionConTabla` en todo el proyecto para permitir cambios en la base de datos con facilidad.
- Métodos dentro de `FileManager` para la creación rápida de tablas y la carga de backups.

---
