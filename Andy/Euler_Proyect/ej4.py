
def palindromo():
    
        maxdig=pow(10,3)
        mindig=pow(10,2)
        
        res = max(i * j
            for i in range(mindig,maxdig)
            for j in range(mindig,maxdig)
            if str(i*j) == str(i*j)[::-1])
        
        print(res)
        
palindromo()
