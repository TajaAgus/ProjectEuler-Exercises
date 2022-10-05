
class IsPrime():
    
    def run(num):
        
        if (num<=1):
            return False
        
        if (num==2):
            return True
        
        if num % 2 == 0:
            return False
        
        counter = 3
        
        while (counter**2 <= num):
            
            if (num % counter == 0):
                return False
            else:
                counter += 2
        
        return True

