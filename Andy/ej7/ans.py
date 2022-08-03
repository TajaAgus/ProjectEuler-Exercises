 
primos = []
filtro = []
contador = 1
multiplicador = 2
limite=110000

for i in range(limite):
    primos.append(contador)
    contador +=1
for x in range(limite):
    for i in range(multiplicador,limite,multiplicador):
        if i/multiplicador == 1:
            continue
        filtro.append(i)
    for num in filtro:
        if num in primos:
            primos.remove(num)
        else:
            continue
    for i in filtro:
        filtro.clear()
    multiplicador +=1
    if multiplicador**2 >= limite:
        break


print(primos[10001])
    


        
        

    


    
    
     
                

        
            