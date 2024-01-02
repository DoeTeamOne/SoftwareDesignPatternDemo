it is one  Structural pattern Of GOF Design Pattern
it is also known as surogate pattern

its intent if to provide surogate or place holder for another object  to control access to it 


****** Use Case

- proxy for gatthering Performance and usage metrics 
- Proxy for Feature Toggling  with out re deploing application
- proxy for performance Optimization
-proxy for rate Limiting 

*** Pattern conscuense 
- it allows interoducing new proxies with out chaning the client
-Added Complexity because additional clases introduced
- performance impact of passing through additional Layer