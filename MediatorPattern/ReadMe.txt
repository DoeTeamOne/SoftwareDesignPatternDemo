Mesiator pattern is one of Behevioral pattern of GOF design Pattern

- the intent of mediator Pattern is to define an object - the Mediator - that encapsulate how a set of objects are interact.
it does that by forcing object to communicate via the mediator



Use Cases  for mediator Pattern
-when a set of object comunicate in well defined but complex ways
- when because  an object refers  to and communicates with many other objects, the object is difficult to reuse 
- when behaviour that is distruibuted between several clasese should be customizable without a lot of subclases


Senarios
-Hospital Information System : use this pattern to comunicate multiple departments
- Smart Home Automation System
-Stock Trading System ... to centralise diffrent Trading System
- Traffic Managment System .. you can use to control trafic signals and so on



cuensquence 
- Limit subclassing 
-it decuples Colleagues
-it simplifies Object Protocol 
- New Mediators can be introduces without having to change the components (Open Close)
- it centralizes control, which can amake the mediator turn into a monolit 
