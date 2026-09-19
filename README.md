<h1 align="center"> Historial Web 🌐</h1>
<h3 align="center"> Simulador de historial de navegación con lista doblemente enlazada</h3>

🧰 Herramientas usadas

<p align="center">
  <a href="https://skillicons.dev">
    <img src="https://skillicons.dev/icons?i=visualstudio,cs,dotnet,git,github,&theme=light" />
  </a>
</p>

---

## 1. Descripción del Problema

El proyecto consiste en desarrollar una aplicación de consola en C# que simule el funcionamiento básico de un historial de navegación web.

El historial permitirá registrar páginas web y desplazarse entre ellas utilizando las opciones **Atrás** y **Adelante**. Para representar esta estructura se utilizará una **lista doblemente enlazada**, donde cada nodo tendrá una referencia al nodo siguiente y al nodo anterior.

La aplicación permitirá agregar nuevas páginas, retroceder, avanzar, visualizar el historial en ambos sentidos y eliminar páginas del historial.

---

## 2. Requerimientos del caso

* Crear una clase `PaginaWeb` que almacene la URL y el título de la página.
* Crear una clase `NodoDoble` que almacene una página web.
* Cada nodo debe tener una referencia al siguiente nodo y al nodo anterior.
* Crear una clase `ListaDoble` con los atributos `cabeza` y `cola`.
* Permitir agregar nuevas páginas al final de la lista.
* Permitir retroceder a la página anterior.
* Permitir avanzar a la página siguiente.
* Permitir mostrar el historial desde el inicio hasta el final.
* Permitir mostrar el historial desde el final hasta el inicio.
* Permitir eliminar una página mediante su URL.
* Controlar los casos de lista vacía, primer nodo, último nodo y nodo intermedio.

## 3. Diagrama de la lista doblemente enlazada

```text
CABEZA
  ↓
[Nodo T1] ⇄ [Nodo T2] ⇄ [Nodo T3]
                            ↑
                           COLA
```

Cada nodo tiene dos referencias:

```text
Anterior ← [ Nodo ] → Siguiente
```

La referencia `Anterior` permite retroceder en el historial y la referencia `Siguiente` permite avanzar.

### ¿Qué información tendrá cada página?

Cada página web será almacenada dentro de un nodo de la lista doblemente enlazada.

| Dato      | Ejemplo                      |
| --------- | ---------------------------- |
| URL       | https://www.google.com       |
| Título    | Google                       |
| Anterior  | Referencia al nodo anterior  |
| Siguiente | Referencia al nodo siguiente |

Y en código seguirá esta estructura:

```text
NodoDoble
 ├── Dato
 ├── Siguiente
 └── Anterior
```

La información de cada página será representada mediante la clase `PaginaWeb`:

```text
PaginaWeb
 ├── Url
 └── Titulo
```

## Ejemplo de conexión de nodos

```text
                    CABEZA
                      ↓
              ┌─────────────────┐
              │ Google          │  
  Anterior ←  │ https://google  │
    Null      │                 | Siguiente   
              └─────────────────┘     ↓
                                  ┌─────────────────┐
                        ↑         │ YouTube         │
                     Anterior ←   │ https://youtube │
                                  │                 | Siguiente 
                                  └─────────────────┘     ↓
                                                    ┌─────────────────┐
                                           ↑        │ GitHub          │
                                        Anterior ←  │ https://github  │
                                                    │                 |  Siguiente → null 
                                                    └─────────────────┘
                                                              ↑
                                                             COLA
```

## 4. Operaciones principales

### Agregar al final

Las nuevas páginas se agregan al final de la lista mediante el método:

```csharp
AgregarAlFinal()
```

### Retroceder

La página actual puede desplazarse hacia atrás utilizando:

```csharp
paginaActual = paginaActual.Anterior;
```

### Avanzar

Para desplazarse hacia adelante se utiliza:

```csharp
paginaActual = paginaActual.Siguiente;
```

### Eliminar

Las páginas pueden eliminarse buscando su URL y actualizando las referencias de los nodos involucrados.

### Mostrar historial

El historial puede recorrerse en dos sentidos:

```text
Adelante:
Cabeza → Nodo → Nodo → Cola

Atrás:
Cola → Nodo → Nodo → Cabeza
```

## 5. Menú de la aplicación

```text
=== APLICACIÓN: HISTORIAL DE NAVEGACIÓN WEB ===

1. Visitar nueva página (Agregar al final)
2. Retroceder (Atrás)
3. Avanzar (Adelante)
4. Mostrar historial completo (Adelante y Atrás)
5. Eliminar página del historial
6. Salir
```

La aplicación también muestra la página que se encuentra actualmente seleccionada.
