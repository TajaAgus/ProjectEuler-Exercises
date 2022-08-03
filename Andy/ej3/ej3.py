
def palindromo(dig):
        maxdig=pow(10,dig)
        mindig=pow(10,dig-1)
        res = max(i * j
            for i in range(mindig,maxdig)
            for j in range(mindig,maxdig)
            if str(i*j) == str(i*j)[::-1])
        print(res)
palindromo(int(input("ingrese la cantidad de digitos que los numeros cuyo mayor producto sea palindromico: ")))