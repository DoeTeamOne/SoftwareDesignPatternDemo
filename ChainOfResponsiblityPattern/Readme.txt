Chain of responsiblity pattern is one of behevioural patterns of GOF design Pattern

its intent is to avoide cuppling the sender of request to its reciver by givving more than one object a chance to handle the request. 
it does that by chining the reciving object and passing the request along the chain untill an object handles it.

Use Cases
-when more than one object may handle a request and the handler isn't knowen beforehand
-when you want to issue request to several handlers with out specifing the reciver explicitly
- when the set of object that can handle a request should be specified dynamically 

** Real world scenario
- Approval work flows
- logging for error hundling  eg you might have loggers for console, file, remote and so on 
- security Authorization  eg roll based access,
- Text Processing filters eg filter profanity


cuensquense 
- Reduce cuppling and work towards a single responiblity per class
- Add Flexiblity in regards to assigning responsiblities to Object
- it doesn't guarantee reciept of request
