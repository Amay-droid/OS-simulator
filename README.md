
# MiniOS – Mini Operating System Simulator

## Overview

**MiniOS** is a console-based **Operating System Simulator** built in **C#** that demonstrates core OS concepts such as **process management** and **CPU scheduling**. The project allows users to create processes and observe how the CPU schedules and executes them using classical scheduling algorithms.

This simulator is designed for **learning, demonstration, and resume showcasing**.

---

## Key Features

* Process Control Block (PCB) implementation
* Process lifecycle simulation *(New → Ready → Running → Terminated)*
* Kernel-like Process Manager
* CPU Scheduling using **First Come First Serve (FCFS)**
* Modular and extensible architecture
* Console-based interactive menu

---

## Tech Stack

* **Language:** C#
* **Framework:** .NET
* **Type:** Console Application

---

## Project Structure

```
MiniOS/
├── Core/
│   ├── Process.cs
│   └── ProcessManager.cs
├── Scheduling/
│   ├── Scheduler.cs
│   └── FCFSScheduler.cs
├── Program.cs
├── MiniOS.csproj
```

---

## How to Run

```bash
dotnet build
dotnet run
```

---

## Menu Options

| Option | Description        |
| ------ | ------------------ |
| 1      | Create Process     |
| 2      | View All Processes |
| 3      | Run FCFS Scheduler |
| 4      | Exit               |

---

## Screenshots
<img width="707" height="300" alt="Screenshot 2026-02-05 150253" src="https://github.com/user-attachments/assets/0cd4dbd2-c8f6-4002-b801-d8e29c06a43d" />
<img width="732" height="369" alt="Screenshot 2026-02-05 150306" src="https://github.com/user-attachments/assets/7ab1b513-7c5b-48ea-b135-86f141e3556b" />
<img width="603" height="447" alt="Screenshot 2026-02-05 150318" src="https://github.com/user-attachments/assets/cf00abf7-fc41-4a6d-bafb-699494849a4c" />




---

## Resume Description

**Mini Operating System Simulator | C#**
Developed a console-based OS simulator in C# demonstrating process management and CPU scheduling. Implemented PCB abstraction, kernel-like process manager, and FCFS scheduling using object-oriented design principles.

---


