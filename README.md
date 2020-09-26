# C# Object-Orientated Programming - Computer Shop Scenario

The goal of this assignment to help me familiarized with class and object creation. This assignment touches a wide range of object orientated concepts such as properties, constructors, inheritance, polymorphism, `ReadOnlyDictionary\<TKey, TValue\>` and enumerations. 

## Installation

```bash

git clone https://github.com/jia-von/c-oop-assignment-computer-shop.git
cd c-oop-assignment-computer-shop
start devenv Computer-Shop.sln

```

## Computer Shop Scenario

- A program, ***Computer-Shop*** was written that will create objects ***Cellphones***, ***CPU***, ***Desktop***, and ***Laptop*** . These objects inherites from base class ***Device***. Additionally, the hypothetical ***Computer-Shop*** also create peripherals like ***Keyboard***, ***Mouse***, and ***Screen***. For user to attached and create their own ***CPU Device***. These peripherals are classes that inherites from base class ***Peripheral*** with ***ConnectorType*** properties such as USB Type-A, microUSB, and DisplayPort. 

- The user within the ***Computer-Shop*** can create a ***CPU*** with specified ***Peripherals***, ***ConnectorType***, and ***Peripherals***. 

- The user can also connect/disconnect these peripherals based on the connector type and port availabilities using `ConnectPeripheral()` and `DisconnectPeripheral()` methods which accepts polymorphic arguement. 

- The user can also start their device using `StartUp()` method. 

- Pre-written codes are written within `Program.cs` for user to experiment with the program as shown below.

![Screenshot](/References/ScreenShot.PNG)






