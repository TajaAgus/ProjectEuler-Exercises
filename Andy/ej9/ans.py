import math

def tuViejaEnTanga():   
    for i in range(1,1000):
        for j in range(1,1000):
            c=i**2+j**2
            if math.sqrt(c) == math.floor(math.sqrt(c)):
                c=int(math.sqrt(c))
                if i+j+c == 1000:
                    return i*j*c
            c=0
        
print(tuViejaEnTanga())