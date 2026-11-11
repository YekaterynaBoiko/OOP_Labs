---
config:
  look: classic
  theme: redux-dark-color
---
classDiagram
    class Document {
        +Elements: List~Element~
        +History: HistoryManager
        +SaveToFile(): void
        +LoadFromFile(): void
    }

    class Element { 
        <<abstract>>
        +Draw()* void
    }

    class TextElement {
        +Text: string
        +Formatting: Formatting
    }

    class TableElement {
        +Rows: int
        +Columns: int
    }

    class DiagramElement {
        +Shapes: List~string~
    }

    class Formatting {
        +FontSize: int
        +FontColor: string
    }

    class Command {
        <<abstract>>
        +Execute()* void
        +Undo()* void
    }

    class InsertCommand {
        +Element: Element
    }

    class DeleteCommand {
        +Element: Element
    }

    class ImageElement {
        +FilePath: string
    }

    class StorageManager {
    }

    class HistoryManager {
        +Commands: List~Command~
        +Undo(): void
        +Redo(): void
    }

    class MoveCommand {
        +Element: Element
        +X: int
        +Y: int
    }


    Element <|-- TextElement
    Element <|-- TableElement
    Element <|-- DiagramElement
    Element <|-- ImageElement

    Command <|-- InsertCommand
    Command <|-- DeleteCommand
    Command <|-- MoveCommand

    
HistoryManager "1" *-- "0..*" Command 

InsertCommand --> Element
DeleteCommand --> Element
MoveCommand --> Element

Element "0..*" *-- "1" Document
TextElement "1..*" *-- "1" Formatting

StorageManager ..> Document
Document "1" *-- "1" HistoryManager