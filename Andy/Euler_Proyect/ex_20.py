contador = 1

for i in range(100,1,-1):
    contador = contador*i

contador = list(str(contador))


print(sum(int(number) for number in contador))