# 🗂️ DocumentManager_FactoryMethodPattern

Electronic document management system demonstrating the **Factory Method** design pattern.  
Система электронного документооборота с применением паттерна **«Фабричный метод»**.

---

## 📌 About / О проекте

🎓 Developed for an Object-Oriented Analysis and Design (OOAD) course.  
💡 Uses a factory-based approach to create different document types dynamically.  
📦 Modular, extensible, multilingual (EN / RU).

🎓 Разработано в рамках курса по ООАП.  
💡 Реализовано создание документов разных типов через фабрики.  
📦 Модульная, расширяемая и многоязычная архитектура.

---

## 🔧 Features / Возможности

- 📄 **Multiple document types**: Letter, Order, Business Trip Order  
  Несколько типов документов: Письмо, Приказ, Командировка

- 🏭 **Factory Method pattern** for creating and configuring documents  
  Паттерн «Фабричный метод» для создания и настройки документов

- ➕ Easy to add new document types without modifying existing code  
  Лёгкое добавление новых типов документов без изменения существующего кода

- 🖥️ UI with dynamic fields depending on the selected document type  
  Интерфейс с динамическими полями в зависимости от выбранного типа документа

- 🧠 Encapsulated creation logic in concrete factories  
  Инкапсуляция логики создания в конкретных фабриках

---

## 📁 Structure / Структура

- `Document` — abstract base class for all documents  
  Абстрактный базовый класс для всех документов

- `Letter`, `Order`, `BusinessTripOrder` — concrete document classes  
  Конкретные классы документов

- `DocumentFactory` — abstract factory class  
  Абстрактная фабрика

- `LetterFactory`, `OrderFactory`, `BusinessTripOrderFactory` — concrete factories  
  Конкретные фабрики

---

## 🖼 Screenshot / Скриншот

---
