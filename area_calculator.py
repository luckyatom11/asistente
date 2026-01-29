
def calculate_triangle_area(base, height):
    """
    Calculates the area of a triangle given its base and height.
    """
    return 0.5 * base * height

def calculate_square_area(side):
    """
    Calculates the area of a square given its side length.
    """
    return side * side

if __name__ == "__main__":
    print("Este programa calcula el área de un triángulo o un cuadrado.")
    
    shape = input("¿Qué área quieres calcular? (triangulo/cuadrado): ").lower()

    if shape == "triangulo":
        try:
            base = float(input("Introduce la longitud de la base del triángulo: "))
            height = float(input("Introduce la altura del triángulo: "))
            
            if base < 0 or height < 0:
                print("La base y la altura no pueden ser valores negativos. Por favor, introduce valores positivos.")
            else:
                area = calculate_triangle_area(base, height)
                print(f"El área del triángulo con base {base} y altura {height} es: {area}")
        except ValueError:
            print("Entrada inválida. Por favor, introduce números para la base y la altura.")
    elif shape == "cuadrado":
        try:
            side = float(input("Introduce la longitud del lado del cuadrado: "))
            
            if side < 0:
                print("El lado no puede ser un valor negativo. Por favor, introduce un valor positivo.")
            else:
                area = calculate_square_area(side)
                print(f"El área del cuadrado con lado {side} es: {area}")
        except ValueError:
            print("Entrada inválida. Por favor, introduce un número para el lado.")
    else:
        print("Forma no válida. Por favor, elige 'triangulo' o 'cuadrado'.")
