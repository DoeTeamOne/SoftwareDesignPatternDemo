Iterator Pattern is One of Behavioral pattern of GOF design Pattern

its intent is to provide a way to access the elements of an aggregate object sequentially without exposing its underlying representation.


Aggregate Objects like List,Dictionary Stack, Queue ..



Usecases
-when you want to access an agregate object's content without exposing its internal Representation
- when you want to support multiple ways of traversal for the same aggregate object.
- when you want to avoid code duplication in regard to traversing the aggregate object


Real World Scenario

- Database Query Results
- Document Parsing and Analisys
- Inventory Managment Systems
- Rempte Controle Interface for smart Home


** Pattern cuensquenses
- iterators simplify the interface of your aggregate structure as traversal code is separated out(single responsiblity)
-you can implement new type of aggregate objects an itrators without them interfaring with each other (Open  Close Principle )
-itterators can exist next to each other at the same time on the same collaction
- can be abit overkill when you only use simple traverals and collections