

class Fibonacci():
    
    def run(position):
        
        num1 = 1
        num2 = 2
        sum = 0
        counter = 1
        
        while counter < position:
            
            counter += 1
            sum = num1 + num2
            num1 = num2
            num2 = sum
            sum = 0
        
        print(num1)

