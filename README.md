# C# Object-Orientated Programming - Computer Shop Scenario

The goal of this assignment to help me familiarized with class and object creation. This assignment touches a wide range of object orientated concepts such as properties, constructors, inheritance, polymorphism, `ReadOnlyDictionary<TKey, TValue>` and enumerations. 

## Installation

```bash

git clone https://github.com/jia-von/c-oop-assignment-computer-shop.git
cd c-oop-assignment-computer-shop
start devenv Computer-Shop.sln

```

## Computer Shop Scenario

- A program, `Computer-Shop.sln` was written that will create objects using classes: `Cellphones.cs`, `CPU.cs`, `Desktop.cs`, and `Laptop.cs` . These class inherites from base class `Device.cs`. Additionally, this hypothetical `Computer-Shop.sln` can create peripherals like `Keyboard.cs`, `Mouse.cs`, and `Screen.cs`. For user to attached and create their own ***CPU Device***. These peripherals are classes that inherites from base class `Peripheral.cs` with ***ConnectorType*** properties such as USB Type-A, microUSB, and DisplayPort. 

- The user within the `Computer-Shop.sln` can create a ***CPU*** with specified ***Peripherals*** and ***ConnectorType***. 

- The user can also connect/disconnect these peripherals based on the connector type and port availabilities using `ConnectPeripheral()` and `DisconnectPeripheral()` methods which accepts polymorphic arguement. 

- The user can also start their device using `StartUp()` method. 

- Pre-written codes are written within `Program.cs` for user to experiment with the program as shown below.

![Screenshot](/References/ScreenShot.PNG)






