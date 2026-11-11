---
config:
  look: classic
  theme: redux-dark-color
---
classDiagram
    class Attackable { 
        <<interface>>
        +Attack(): void
    }

    class Defendable {
        <<interface>>
        +Defend(): void
    }

    class Character {
        #Name: string
        +Skills: List~Skill~
        +Equipments: List~Equipment~
        +Attack()
        +Defend()
    }

    class Warrior {
        +UseSword()
    }

    class Mage {
        +CastSpell()
    }

    class Thief {
        +Steal()
    }

    class Skill {
        -Name: string
        +Use(): void
    }

    class Equipment {
        -Type: string
        +Use(): void
    }

    class Team {
        -Characters: List~Character~
    }

Character ..|> Attackable : реалізація
Character ..|> Defendable : реалізація
Character <|-- Warrior : наслідування
Character <|-- Mage : наслідування
Character <|-- Thief : наслідування

Team "1" o-- "0..*" Character : агрегація
Character "1" *-- "0..*" Equipment : композиція
Character "1" *-- "0..*" Skill : композиція
Thief ..> Equipment : залежність