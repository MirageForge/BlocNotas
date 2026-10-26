# Bloc de Notas

Un bloc de notas ligero de escritorio desarrollado en **C#** y **WPF** (.NET), diseñado como una alternativa simple, rápida y funcional para la edición de notas y archivos de texto plano.

---

## 🚀 Tecnologías usadas

* **C#** - Lenguaje de programación principal.
* **.NET 10** - Plataforma de desarrollo moderna y de alto rendimiento.
* **WPF (Windows Presentation Foundation)** - Framework para el diseño de interfaces gráficas en Windows.
* **XAML** - Lenguaje declarativo para la definición de la interfaz de usuario.

---

## ✨ Características principales

* **Crear, abrir y guardar archivos de texto plano:** Soporte completo para flujos de trabajo con archivos `.txt` (y formatos compatibles), incluyendo diálogos nativos del sistema para abrir y guardar.
* **Interfaz limpia basada en XAML con menús nativos:** Menú superior accesible con opciones claras (*Nuevo*, *Abrir*, *Guardar*, *Salir*) y área de edición optimizada con fuente monoespaciada (`Consolas`) y scroll automático.

---

## 🛠️ Requisitos previos

* SDK de [.NET 10.0](https://dotnet.microsoft.com/) o superior.
* Sistema Operativo: **Windows 10 / 11**.
* Editor recomendado: [Visual Studio 2022 / 2026](https://visualstudio.microsoft.com/) o [Visual Studio Code](https://code.visualstudio.com/) con la extensión de C# Dev Kit.

---

## 💻 Compilación y Ejecución

Puedes clonar este repositorio y ejecutarlo directamente mediante la CLI de .NET:

```bash
# Restaurar dependencias y compilar
dotnet build

# Ejecutar la aplicación
dotnet run --project "Bloc de Notas/Bloc de Notas.csproj"
```

O abrir la solución `Bloc de Notas.slnx` en Visual Studio y presionar `F5`.

---

## 📁 Estructura del Proyecto

```text
├── .gitignore
├── Bloc de Notas.slnx
├── README.md
└── Bloc de Notas/
    ├── App.xaml / App.xaml.cs          # Punto de entrada y ciclo de vida de la aplicación
    ├── AssemblyInfo.cs                 # Información de ensamblado y temas
    ├── Bloc de Notas.csproj            # Configuración del proyecto .NET WPF
    ├── MainWindow.xaml                 # Diseño de la interfaz gráfica (XAML)
    └── MainWindow.xaml.cs              # Lógica de interacción y manejo de archivos
```
