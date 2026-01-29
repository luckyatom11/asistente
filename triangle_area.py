
def calculate_triangle_area(base, height):
    """
    Calculates the area of a triangle given its base and height.
    """
    return 0.5 * base * height

if __name__ == "__main__":
    print("Este programa calcula el área de un triángulo.")
    
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
