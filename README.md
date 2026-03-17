# Windows Forms Calculator Application

A clean, functional desktop calculator built using **C#** and **Windows Forms**. This application supports standard arithmetic operations and features a hybrid input system allowing for both mouse-driven and keyboard-driven interaction.

## 🚀 Features
* **Core Arithmetic:** Supports Addition (+), Subtraction (-), Multiplication (*), and Division (/).
* **Hybrid Input System:** Users can interact via the GUI buttons or directly through the keyboard (numeric pad and shortcuts). 
* **Error Handling:** Robust logic to manage special cases, such as preventing division by zero through user-friendly message alerts. 
* **Input Validation:** The result display is set to "Read-Only" mode to prevent invalid manual text entry, ensuring data integrity. 
* **Advanced Controls:**
    * **CE (Clear Entry):** Clears the current input. 
    * **C (Clear):** Resets the entire calculator state and memory.
    * **± (Negate):** Toggles the sign of the current value. 
    * **Backspace:** Removes the last digit entered.

## 🛠️ Tech Stack
* **Language:** C# 
* **Framework:** .NET Windows Forms 
* **Tools:** Visual Studio

## 📂 Logic Implementation
The application utilizes a `KeyPreview` configuration to intercept keyboard events before they reach specific controls, allowing for seamless global keyboard shortcuts. 
* **Keyboard Shortcuts:**
    * `Enter` or `=` for results. 
    * `ESC` to close the application.
    * `Delete` for Clear Entry. 
    * Standard numeric and operator keys for input. 

## ⚙️ How to Run
1. Open the project solution (`.sln`) in **Visual Studio**.
2. Build the project to restore dependencies.
3. Press `F5` or click **Start** to launch the application.

---
*Developed as part of the Object-Oriented Programming (POO) Portfolio - 2025* 
