---
config:
  look: classic
  theme: redux-dark-color
---
classDiagram
namespace Models {

    class Users { 
        <<abstract>>
        +int: Id
        +string: Name
        +string: LastName
        +string: Email
        +string: PhoneNumber
        -string: PasswordHash
        +DateTime: RegistrationDate
    }

    class Client {
        +int?: ManagerId

        +string: TaxNumber
    }

    class Manager {
        +decimal: CommissionPercentage
        +Clients: List~Client~
    }

    class ResidentialComplex {
        +int: Id
        +string: Name
        +string: Address
        +double: Latitude
        +double: Longitude
        +DateOnly: PlannedCompletionDate
        +House: List~Houses~
    }

    class House {
        +int: ResidentalId
        +int: Id
        +int: SectionNumber
        +int: NumberOfFloors
        +ConstructionStage constructionStage
        +RealEstate: List~RealEstate~
    }

    class RealEstate {
        +int: RealEstateId
        +int: HouseId
        +int: ObjectNumber
        +int: Floor
        +int: NumberOfRooms
        +double: Area
        +RealEstateType realEstateType
        +Status status 
        +decimal: PricePerSquareMeter
        +CalculateTotalPrice() : decimal
        %% Area * PricePerSquareMeter
        +List~FloorPlan~: FloorPlans%% картинки
    }

    class ViewingAppointment {
        +int: Id
        +int: ClientId
        +int: RealEstateId
        +DateTime: ViewingDate
        +ViewingStatus status
        +string?: Comment
    }
    
    class Image {
        +int: Id
        +int: ApartmentId
        +string: FilePath
        +int: OrderOnTheSite
    } 

    class Booking {
        +int: Id
        +int: ClientId
        +int: RealEstateId
        +DateTime: CreatedAt %% створення броні
        +DateTime: ExpirationDate %% заверщення броні
        +BookingStatus Status
    }

    class Contract {
        +int: ContractNumber
        +int: ClientId
        +int: RealEstateId
        +int: ManagerId
        +DateOnly: DateOfSigning
        +decimal: TotalAmount
        +PaymentMethod paymentMethod
        +Payment: List~Payment~
        +CalculatePaidAmount() : decimal
        +CalculateRemainingAmount() : decimal
    }

    class Payment {
        +int: Id
        +decimal: TotalAmount
        +DateTime?: PaymentDate
        +DateTime: DueDate %% дата до якої внести оплату
    }

    class LocalFileStorage {
        -string: FolderPath
        +Save() : void
        +Delete() : void
    }
}

namespace Services {
    class ViewingService {
        -ApplicationContext _context
        +CreateAppointment(Client client, RealEstate realestate, DateTime viewingDate) : void
        +ConfirmAppointment(ViewingAppointment appointment) : void
        +CancelAppointment(ViewingAppointment appointment) : void
        +CompleteAppointment(ViewingAppointment appointment) : void
        +GetClientAppointments(Client client) : List~ViewingAppointment~
    }

    class BookingService {
        -ApplicationContext _context
        +CreateBooking(Client client, RealEstate realestate) : Booking
        +CancelBooking(Booking booking) : void
        +ExpireBookings() : void
    }

    class ContractService {
        -ApplicationContext _context
        +CreateContract(Client client, Manager manager, RealEstate realEstate) : Contract
        +SignContract(Contract contract) : void
        +GetContract(int contractId) : Contract
        +PaymentRegistration(int contactId, decimal amount)
        -BuildPaymentSchedule(int contactId, int numberOfMonths) : List~Payment~
    }

    class AccountService {
        -ApplicationContext _context
        +RegisterClient(string fullName, string email, string password, string phoneNumber) : Client
        +Login(string email, string password) : User
        +RegisterManager(string fullName, string email, string password, string phoneNumber) : Manager
        +AssignManager(int clientId, int managerId) : void 
        -HashPassword(string password) : string
    }

    class CatalogService {
        -ApplicationContext _context
        -IFileStorage storage
        +AddResidentalComplex(ResidentalComplex complex) : void
        +AddHouse(House house) : void
        +AddRealEstate(RealEstate realEstate) : void
        +AddImage(Image image) : void
        +SearchRealEstateById(int realEstateId) : RealEstate
        +SearchAvailable(int realEstateId, RealEstateType type, int minRooms, decimal maxPrice) : List~RealEstate~
    }
}

namespace Context {
    class ApplicationContext {
        +List~Client~ Clients
        +List~Manager~ Managers
        +List~ResidentalComplex~ ResidentalComplex
        +List~RealEstate~ RealEstates
        +List~Booking~ Bookings
        +List~ViewingAppointment~ ViewingAppointment
        +List~Contract~ Contracts

        +GetNextId() : int
        +SaveChanges() : void
    }
}

namespace Enumeration {
    class ConstructionStage {
        <<enumeration>>
        Excavation
        StructuralFrame
        Finishing
        Commissioned
    }

    class RealEstateType {
        <<enumeration>>
        Apartment
        CommercialPremises
        ParkingSpace
        StorageRoom
    }

    class Status {
        <<enumeration>>
        Available
        Reserved
        Sold
    }

    class ViewingStatus {
        <<enumeration>>
        New
        Confirmed
        Cancelled
        Completed
    }

    class BookingStatus {
        <<enumeration>>
        Active
        Cancelled
        Expired
        ConvertedToSale
    }

    class PaymentMethod {
        <<enumeration>>
        PaymentInFull
        Installment
    }

    class IFileStorage {
        <<interface>>
        +Save() : void
        +Delete() : void
    }
}

Users <|-- Client : наслідування
Users <|-- Manager : наслідування

Manager "0..1" o-- "0..*" Client : агрегація

Contract "1" *-- "1..*" Payment : композиція (бо містить ел.)
ResidentialComplex "1" *-- "1..*" House : композиція
House "1" *-- "1..*" RealEstate : композиція
RealEstate "1" *-- "1..10" Image 
LocalFileStorage "1" *-- Image
ViewingAppointment --> ViewingStatus : використовує
House --> ConstructionStage : використовує
RealEstate --> RealEstateType : використовує
RealEstate --> Status : використовує
Contract --> PaymentMethod : використовує
Booking --> BookingStatus : використовує
LocalFileStorage ..|> IFileStorage


BookingService --> "1" ApplicationContext
ViewingService --> "1" ApplicationContext
ContractService --> "1" ApplicationContext
AccountService --> "1" ApplicationContext
CatalogService --> "1" ApplicationContext
IFileStorage --> CatalogService  

Client "1" -- "0..*" ViewingAppointment : запис на перегляд
RealEstate "1" -- "0..*" ViewingAppointment : перегляд об'єкту
RealEstate "1" -- "0..1" Contract : продаж за договором
Client "1" -- "0..*" Booking : бронювання
RealEstate "1" -- "0..*" Booking : бронь об'єкту
Client "1" -- "1..*" Contract

ViewingService ..> ViewingAppointment : залежність
ContractService ..> Contract : залежність
BookingService ..> Booking :залежність