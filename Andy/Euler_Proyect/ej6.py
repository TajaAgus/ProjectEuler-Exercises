lista = []
contador = 0

for numero in range (1,101):
    
    lista.append(numero)
    numero +=1
    
for numero in lista:
    
    cuadrado = numero**2
    contador += cuadrado
    
cuadrado_de_suma = sum(lista)**2
suma_de_cuadrado = contador
ans = cuadrado_de_suma - suma_de_cuadrado

print(ans)
    
    

