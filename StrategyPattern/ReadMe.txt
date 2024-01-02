Strategy Pattern is One Of Behevioral Pattern of GOD Design Pattern

- its intent is to define a familly of algorithm , encapsulate each one and make them interchangable. 
strategy lets the algorothm vary independent from client that use it 


Use Cases
- when many related clases differ only in their Behavior
-when you need to deffer variant of algorithmwhich you want to be able to switch at runtime
- when your algorithm uses data , code or dependancies that the clients should know about 
- when the class defines many diffrent behaviour which apear as a bunch of conditional statments in its method.


usecases for strategy pattern
-Compression Algorithms
-Payment Processing system - paypal , ceditcard , apple pay, google pay and more 
-Travel Booking System -  calculating chippest rought based on behaviours like Mode of transportation,time, cost 
- Vedio Game Design  for path finding decision Making or enemy Behaviour


***Pattern cuensquences
- it offers an alternative to subclassing your context
-new strategies can be introduced without having to change contet (Open Close Principle )
- it eliminate conditional statments
- provide a choice of implementation with the same behavior
- If the client injects the strategy, it must be aware that how strategies are differ
-there is overghade in communication between stratagy and the context
- additional objectws are introduced which increase complexity