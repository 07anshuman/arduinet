

# 🛠️ Arduinet: Simplifying Multi-Microcontroller IoT Management

Arduinet is a C#-based framework designed to streamline the management and communication between multiple Arduino/ESP-based IoT devices. When working on projects involving multiple microcontrollers, interfacing them can be complex. Arduinet solves this challenge by providing a unified interface for device communication and interaction.

## 🌟 Key Features

- **📡 Multi-Protocol Support**: Arduinet supports Serial, Bluetooth, and Wi-Fi (ESP8266/ESP32) communication protocols.
- **🔌 Modular and Extensible Design**: Built with interfaces and dependency injection, allowing easy addition of new communication channels and devices.
- **🖥️ Centralized Device Management**: The framework manages the discovery, connection, and state maintenance of connected devices.
- **🔄 Bidirectional Messaging System**: Facilitates smooth communication between the host application and microcontrollers.
- **🖱️ Interactive GUI**: A user-friendly interface for visualizing device output, sending commands, and monitoring the IoT system.

## 🛠️ Architecture Overview

### 1. **🌐 ArduinetServer**
   - Acts as the central hub, initializing and managing communication channels for connected Arduino devices.
   - Supports extensibility via the `IArduinetChannel` interface, enabling the addition of new protocols.

### 2. **📋 ArduinetDeviceManager**
   - Handles device discovery and management. 
   - Creates and manages instances of `ArduinetDevice` for each detected microcontroller.

### 3. **📨 Messaging System**
   - The `ArduinetMessage` class represents messages exchanged between the host and devices.
   - The `ArduinetMessageHandler` processes incoming messages and dispatches them to the appropriate event handlers.

### 4. **🖥️ GUI Application**
   - Provides a visual interface for interacting with devices, sending commands, and viewing output.
   - Decouples the presentation logic from the core framework, enabling easy customization of the interface.

## 🗂️ Usage Workflow

1. **🔧 Server Initialization**: Start by initializing the `ArduinetServer`, which sets up supported communication channels (Serial, Bluetooth, Wi-Fi).
2. **🔍 Device Discovery**: The `ArduinetDeviceManager` scans for connected devices and adds them to the device list.
3. **🔗 Device Connection**: When a device is detected, the manager creates an `ArduinetDevice` instance and establishes communication.
4. **🔄 Bidirectional Communication**: Send commands and receive updates using `ArduinetMessage` instances, managed by the `ArduinetMessageHandler`.
5. **🖥️ Visualization and Interaction**: Use the GUI to monitor devices, view output, and send commands.

## 🚀 Extensibility

- **🛠️ Interfaces and Modular Design**: The framework uses interfaces like `IArduinetChannel` and `IArduinetDevice` to ensure modularity. This allows developers to easily add support for new communication protocols, device types, or custom functionality.
- **📚 Example Implementations**: Includes example integrations for various Arduino devices, demonstrating how to extend the framework.

## 🎯 Getting Started

1. Clone the repository.
2. Follow the provided example implementations to set up your devices.
3. Customize the communication channels and device management based on your specific IoT setup.

## 🤝 Contributing

Contributions are welcome! Feel free to submit issues, fork the repository, and create pull requests.
