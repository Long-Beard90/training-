# i want to make a task editor .
task=[]
while True:
    print('to do list menu :')
    print('1.to add task')
    print('2.to remove task')
    print('3.to list tasks')

    choice=input('enter your choice :')

    if choice=='1' :
        task_detail=input('Enter your task detail :')
        task.append(task_detail)
        print('task added')

    elif choice=='2' :
        if not task:
            print('task not found')
        else:
            print('task :')
            for i,task in enumerate(task):
                print(f"{i}.{task}")
                