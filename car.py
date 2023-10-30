# this is a car that can start and stop . 
command = ""
while True:
    command = input('>').lower()
    if command == "start":
        print('the car started ...')
    elif command == "stop":
        print('the car stopped ...')
    elif command == "help":
        print("""
start - to start the car
stop - to stop the car
quit - to quit                           
""")
    elif command == "quit":
        print('quit')
        break
    else:
        print("i dont understand")

  
        