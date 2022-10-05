from resources.is_prime import IsPrime
import time


inicio = time.time()

ans = 0
prime_counter = 0
while prime_counter != 10001:
    
    ans +=1

    if IsPrime.run(ans) == True:
        prime_counter +=1
        
        
fin = time.time()

total = fin - inicio

print(ans,'{0:.3g}'.format(total))


            
            

