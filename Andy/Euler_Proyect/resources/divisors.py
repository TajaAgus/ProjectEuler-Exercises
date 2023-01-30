from resources.prime_factor import PrimeFactor

class Divisors():
    
    def amount(num):
        
        product = 1
        
        values = []
        
        factors = PrimeFactor.all_factors(num)
        
        for value in factors.values():
            values.append(value + 1)
        
        for item in values:
            product = product * item
            
        return product
    
    def list(num):
        
        numlist = []
        
        for i in range(1,num):
            
            if num % i == 0:

                numlist.append(i)
                
        return numlist