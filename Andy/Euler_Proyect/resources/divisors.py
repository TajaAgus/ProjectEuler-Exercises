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
    
    def sum_list(num):
        
        divisor_sum = [0] * num
 
        for i in range(1, len(divisor_sum)):
            
            for j in range(i * 2, len(divisor_sum), i):
                divisor_sum[j] += i
                
        return divisor_sum