
Momento  pattern is one of Behevioral pattern of GOF design pattern

-  the intent of momento pattern is to capture and
externalize an object internal state so that the object can be restored to this state latter with out violating encapsulation


Use case for the momento pattern
-when part of the object state must be saved so it can be restored latter on 
-when a direct interface to obtaining the state would expose implementation  detail and break encapsulation



RealLife UseCase
- Text editor  with undo and Redo functionality
-version control system
-Ecomerce shoping Cart  ...for wish list item
- content managment system (CMS)


Pattern cuesquenses
-it preserve encapsulation boundaries
-it simplifies the origionator
- using momento might be expensive
- it can introduce complexity to your codebase 