import tkinter

ventana = tkinter.Tk()
ventana.geometry("500x500")

etiqueta = tkinter.Label(ventana, text="Hola mundo")
etiqueta.pack()

def saludo(nombre):
    print("Hola" + nombre)

boton = tkinter.Button(ventana, text="tuvieja",command= lambda: saludo('python'))
boton.pack()

caja_texto = tkinter.Entry(ventana)
caja_texto.pack()

ventana.mainloop()