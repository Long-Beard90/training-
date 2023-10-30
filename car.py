# this is a car that can start and stop . 
command = ""
car_started = False
while True:
    command = input('>').lower()
    if command == "start":
        if car_started:
            print('the car already started')
        else:
            car_started = True
            print('the car started ...')
    elif command == "stop":
        if not car_started:
            print('car is already stopped')
        else:
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
