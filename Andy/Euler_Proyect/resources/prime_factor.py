from resources.is_prime import IsPrime

class PrimeFactor():
    
    def biggest(num):    
        factor=2
        last_factor=1
        while num>1:
            if num % factor == 0:
                last_factor = factor
                num = num/factor
                while num % factor==0:
                    num=num/factor
            factor+=1
        return last_factor

    def all_factors(num):
        
        factores = {}
        factor = 2
        
        while num > 1:
            
            if num % factor == 0 and IsPrime.run(factor):
                if factor in factores:
                    factores[factor] += 1
                else:
                    factores[factor] = 1
                num = num/factor
            else:
                factor +=1
            
        return factores
    

                
