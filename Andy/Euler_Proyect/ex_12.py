from resources.divisors import Divisors


contador = 0
divisors = 1
triangle = 0

while divisors < 500:

    triangle += 1
    
    contador = 0
    
    for i in range(triangle) : contador += i
    
    divisors = Divisors.amount(contador)
    
print(contador)
        
       

    

    



