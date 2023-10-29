# lets paly a game 
import random
the_number = random.randint(1, 100)

attempts =0
print('welcome to the game of guesing !')
print('i think of a number , can you guess?')

while True:
    try:
        # ask player to guess a number
        guess = int(input('please enter a number :'))

        attempts += 1

        # lets check if the number is correct
        if guess <the_number :
            print('give me a higher number!')
        elif guess > the_number:
            print('give me a lower number')
        else:
            print('amazing ', guess, 'is correct!',the_number)
            break
    except ValueError :
        print('the number is not valid')
    
    print('thanks!') 