from math import factorial



def lattice_path_options():
    
    
    a,b = 40,20

    afact = factorial(a)

    b = factorial(b)*factorial(a-b)

    print(str(afact/b))




lattice_path_options()





    
    
    