# Sistema de Gestión de Nómina

Un sistema completo para la gestión y cálculo de pagos semanales de empleados, desarrollado en C# siguiendo principios de programación orientada a objetos.

## Descripción

Este sistema permite a las empresas calcular automáticamente los pagos semanales de diferentes tipos de empleados, gestionar su información y generar reportes detallados. La aplicación está diseñada con una arquitectura modular y escalable que facilita el mantenimiento y la extensión de funcionalidades.

## Características Principales

- **Gestión de múltiples tipos de empleados**: Asalariados, por horas, por comisión y asalariados por comisión
- **Cálculo automático de pagos**: Incluye manejo de horas extras para empleados por horas
- **Interfaz de usuario intuitiva**: Menú interactivo fácil de navegar
- **Generación de reportes**: Reportes detallados con totales semanales
- **Validación de datos**: Entrada segura de información con manejo de errores
- **Actualización de información**: Modificación de datos de empleados existentes

## Tipos de Empleados Soportados

### Empleado Asalariado
- Pago fijo semanal
- **Fórmula**: Pago = Salario Semanal

### Empleado por Horas
- Pago basado en horas trabajadas
- Tiempo extra (1.5x) después de 40 horas
- **Fórmula**: 
  - Hasta 40 horas: Pago = Sueldo por Hora × Horas Trabajadas
  - Más de 40 horas: Pago = (Sueldo por Hora × 40) + (Sueldo por Hora × 1.5 × Horas Extra)

### Empleado por Comisión
- Pago basado en ventas realizadas
- **Fórmula**: Pago = Ventas Brutas × Tarifa de Comisión

### Empleado Asalariado por Comisión
- Combina salario base con comisión por ventas
- Incluye bono del 10% sobre salario base
- **Fórmula**: Pago = (Ventas Brutas × Tarifa de Comisión) + Salario Base + (Salario Base × 0.10)

## Arquitectura del Sistema

El sistema está organizado en las siguientes clases principales:

- **`Empleado`**: Clase abstracta base que define la estructura común
- **`EmpleadoAsalariado`**: Implementación para empleados con salario fijo
- **`EmpleadoPorHoras`**: Implementación para empleados con pago por horas
- **`EmpleadoPorComision`**: Implementación para empleados con pago por comisión
- **`EmpleadoAsalariadoPorComision`**: Implementación para empleados con salario base más comisión
- **`GestorEmpleados`**: Maneja la lógica de negocio y almacenamiento
- **`InterfazUsuario`**: Controla la interacción con el usuario
- **`PruebaSistemaNomina`**: Clase principal con el punto de entrada del programa

## Tecnologías Utilizadas

- **Lenguaje**: C# (.NET 8)
- **Paradigma**: Programación Orientada a Objetos
- **Tipo de aplicación**: Aplicación de consola
- **Almacenamiento**: Colección en memoria (List<T>)

## Instalación y Ejecución

### Prerrequisitos
- .NET 8 SDK o superior
- Visual Studio 2022 o Visual Studio Code (opcional)

### Pasos de instalación

1. **Clonar el repositorio**
   ```bash
   git clone https://github.com/tu-usuario/sistema-nomina.git
   cd sistema-nomina
   ```

2. **Compilar el proyecto**
   ```bash
   dotnet build
   ```

3. **Ejecutar la aplicación**
   ```bash
   dotnet run
   ```

### Estructura de archivos

```
sistema-nomina/
│
├── Empleado.cs                           # Clase abstracta base
├── EmpleadoAsalariado.cs                # Empleado con salario fijo
├── EmpleadoPorHoras.cs                  # Empleado con pago por horas
├── EmpleadoPorComision.cs               # Empleado con pago por comisión
├── EmpleadoAsalariadoPorComision.cs     # Empleado con salario + comisión
├── GestorEmpleados.cs                   # Lógica de negocio
├── InterfazUsuario.cs                   # Interfaz de usuario
├── PruebaSistemaNomina.cs              # Clase principal
└── README.md                            # Este archivo
```

## Uso del Sistema

### Menú Principal

El sistema presenta un menú interactivo con las siguientes opciones:

1. **Agregar Empleado**: Permite registrar un nuevo empleado seleccionando su tipo
2. **Ver Todos los Empleados**: Muestra la lista completa de empleados registrados
3. **Actualizar Información de Empleado**: Modifica datos de empleados existentes
4. **Generar Reporte de Pagos**: Calcula y muestra el reporte semanal de pagos
5. **Salir**: Finaliza la aplicación

### Ejemplo de uso

```
=== SISTEMA DE GESTIÓN DE NÓMINA ===
Bienvenido al sistema de pagos de empleados

=== MENÚ PRINCIPAL ===
1. Agregar Empleado
2. Ver Todos los Empleados
3. Actualizar Información de Empleado
4. Generar Reporte de Pagos
5. Salir
Seleccione una opción (1-5):
```

## Principios de Diseño Aplicados

- **Herencia**: Todos los tipos de empleados heredan de la clase base `Empleado`
- **Polimorfismo**: Cada tipo de empleado implementa su propio método de cálculo de pago
- **Encapsulamiento**: Los datos están protegidos mediante propiedades
- **Abstracción**: La clase base define la interfaz común sin implementación específica
- **Responsabilidad única**: Cada clase tiene una responsabilidad específica
- **Principio abierto/cerrado**: Fácil extensión para nuevos tipos de empleados

## Contribución

Las contribuciones son bienvenidas. Por favor:

1. Haz fork del proyecto
2. Crea una rama para tu feature (`git checkout -b feature/nueva-funcionalidad`)
3. Commit tus cambios (`git commit -am 'Agregar nueva funcionalidad'`)
4. Push a la rama (`git push origin feature/nueva-funcionalidad`)
5. Abre un Pull Request

## Licencia

Este proyecto está bajo la Licencia MIT. Ver el archivo `LICENSE` para más detalles.

---

# Payroll Management System

A comprehensive system for managing and calculating weekly employee payments, developed in C# following object-oriented programming principles.

## Description

This system allows companies to automatically calculate weekly payments for different types of employees, manage their information, and generate detailed reports. The application is designed with a modular and scalable architecture that facilitates maintenance and extension of functionalities.

## Key Features

- **Multiple employee types management**: Salaried, hourly, commission-based, and salaried plus commission
- **Automatic payment calculation**: Includes overtime handling for hourly employees
- **Intuitive user interface**: Easy-to-navigate interactive menu
- **Report generation**: Detailed reports with weekly totals
- **Data validation**: Safe information input with error handling
- **Information updates**: Modification of existing employee data

## Supported Employee Types

### Salaried Employee
- Fixed weekly payment
- **Formula**: Payment = Weekly Salary

### Hourly Employee
- Payment based on hours worked
- Overtime (1.5x) after 40 hours
- **Formula**: 
  - Up to 40 hours: Payment = Hourly Rate × Hours Worked
  - Over 40 hours: Payment = (Hourly Rate × 40) + (Hourly Rate × 1.5 × Overtime Hours)

### Commission Employee
- Payment based on sales made
- **Formula**: Payment = Gross Sales × Commission Rate

### Salaried Plus Commission Employee
- Combines base salary with sales commission
- Includes 10% bonus on base salary
- **Formula**: Payment = (Gross Sales × Commission Rate) + Base Salary + (Base Salary × 0.10)

## System Architecture

The system is organized into the following main classes:

- **`Empleado`**: Abstract base class that defines the common structure
- **`EmpleadoAsalariado`**: Implementation for fixed salary employees
- **`EmpleadoPorHoras`**: Implementation for hourly employees
- **`EmpleadoPorComision`**: Implementation for commission employees
- **`EmpleadoAsalariadoPorComision`**: Implementation for base salary plus commission employees
- **`GestorEmpleados`**: Manages business logic and storage
- **`InterfazUsuario`**: Controls user interaction
- **`PruebaSistemaNomina`**: Main class with program entry point

## Technologies Used

- **Language**: C# (.NET 8)
- **Paradigm**: Object-Oriented Programming
- **Application type**: Console application
- **Storage**: In-memory collection (List<T>)

## Installation and Execution

### Prerequisites
- .NET 8 SDK or higher
- Visual Studio 2022 or Visual Studio Code (optional)

### Installation steps

1. **Clone the repository**
   ```bash
   git clone https://github.com/your-username/sistema-nomina.git
   cd sistema-nomina
   ```

2. **Build the project**
   ```bash
   dotnet build
   ```

3. **Run the application**
   ```bash
   dotnet run
   ```

### File structure

```
sistema-nomina/
│
├── Empleado.cs                           # Abstract base class
├── EmpleadoAsalariado.cs                # Fixed salary employee
├── EmpleadoPorHoras.cs                  # Hourly employee
├── EmpleadoPorComision.cs               # Commission employee
├── EmpleadoAsalariadoPorComision.cs     # Salary + commission employee
├── GestorEmpleados.cs                   # Business logic
├── InterfazUsuario.cs                   # User interface
├── PruebaSistemaNomina.cs              # Main class
└── README.md                            # This file
```

## System Usage

### Main Menu

The system presents an interactive menu with the following options:

1. **Add Employee**: Allows registering a new employee by selecting their type
2. **View All Employees**: Shows the complete list of registered employees
3. **Update Employee Information**: Modifies existing employee data
4. **Generate Payment Report**: Calculates and displays the weekly payment report
5. **Exit**: Closes the application

### Usage example

```
=== PAYROLL MANAGEMENT SYSTEM ===
Welcome to the employee payment system

=== MAIN MENU ===
1. Add Employee
2. View All Employees
3. Update Employee Information
4. Generate Payment Report
5. Exit
Select an option (1-5):
```

## Applied Design Principles

- **Inheritance**: All employee types inherit from the `Empleado` base class
- **Polymorphism**: Each employee type implements its own payment calculation method
- **Encapsulation**: Data is protected through properties
- **Abstraction**: The base class defines the common interface without specific implementation
- **Single responsibility**: Each class has a specific responsibility
- **Open/closed principle**: Easy extension for new employee types

## Contributing

Contributions are welcome. Please:

1. Fork the project
2. Create a feature branch (`git checkout -b feature/new-functionality`)
3. Commit your changes (`git commit -am 'Add new functionality'`)
4. Push to the branch (`git push origin feature/new-functionality`)
5. Open a Pull Request

## License

This project is under the MIT License. See the `LICENSE` file for more details.
