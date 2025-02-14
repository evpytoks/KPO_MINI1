# KPO_MINI1
**Single Responsibility Principle:**
Каждый класс отвечает только за 1 задачу. Zoo управляет животными и предметами в зоопарке. Vet проверяет здоровье животных. Классы животных/предметов отвечают за спецификацию информации о соответсвующем виде животных/предметов.
**Open/Closed Principle:**
Добавление новых животных происходит через наследование от Herbo, Predator. Добавление новых вещей происходит через наследование от Thing. Добавление нового сервиса для проверки здоровья происходит через интерфейс IHealthChecker.
**Liskov Substitution Principle:**
Все подклассы могут заменять родительские классы.
**Interface Segregation Principle:**
Все интерфейсы имеют свою 1 конкретную задачу.
**Dependency Inversion Principle:**
Zoo не зависит от реализации IHealthChecker. Vet не зависит от конкретных животных, только от Animal.
