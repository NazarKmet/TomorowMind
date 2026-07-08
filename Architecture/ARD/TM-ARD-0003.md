# TM-ADR-0003

## Title
Clean Architecture by Default

---

## Status

**Accepted**

---

## Date

2026-07-08

---

## Authors

- Nazariy Kmet (Founder & CEO)
- Genesis AI (Chief Architect)

---

# Context

TomorowMind is building long-term platform products, including Genesis, FactoryOS, and future operating systems for physical-world intelligence.

These systems must remain maintainable, testable, secure, and adaptable as the company grows.

Without a clear architectural standard, early prototypes can quickly become tightly coupled systems that are difficult to extend, test, secure, or scale.

TomorowMind requires an architecture that supports fast execution today without sacrificing the ability to evolve tomorrow.

---

# Decision

All TomorowMind software shall follow **Clean Architecture by default**.

Core business logic must be separated from user interfaces, databases, frameworks, cloud providers, AI vendors, and external infrastructure.

Applications will be structured around clear layers:

```text
Presentation
Application
Domain
Infrastructure