ASP.NET Advanced 2024 final project

The fastest way to recieve your medicines!

Necessary NuGet packages:

Moq 4.20.70 (for unit tests)
Stripe.net 44.2 (Stripe is used when the owners make transactions, not payments!!!) !!!Note: (Just download the stripe package so that the application can build itself correctly. The demo of stripe could be done during the exam because it requires secret and public key and proper localhost port)
Roles:

Default user:
email: useroff@mail.com
password: user1
Moderator:
email: modoff@mail.com
password: moderator1
Owner:
email: owneroff@mail.com
password: owner1
Admin:
email: adminoff@mail.com
password: admin1
What can everybody do:

Disclaimer: Please note that I might have missed something. I reckon that every edge case about access and security is implemented, so if something is unclear you can see the implementation of it.

Admin (only one):

He can access the 'all programs' section and see the details for them
He can create new categories for tasks and see the current ones
He can see all transactions made in the app
He can see all users in the app
Access for every other role and steps to use the app:

Before creating an account you can see all available programs
On creation of account you can choose what type of account you want to create: regular user(It is the same as the default user role. I just decided to name it 'regular user' for better UI) or owner
Then new sections should be available: My program, Received payments, My applications (When you are a moderator you can see the same sections except for 'my applications')
Also a 'balance' tracker should be displayed in the upper right corner
you can now go to 'all programs' and when you press 'details' you can see some info about the programs and a button candidate should be visible
When you press it, you should see a form which is for your application to the selected program
when you fill it you can go to 'my applications' and see that it is there
you can edit or delete it
you can also candidate for other programs but note that when you are accepted in a program, all other applications are automatically deleted
Now it is time for a moderator or an owner of the program you just applied for to login:

they can go to 'my program' and there see all the access they have
when you press applications you can see the submitted application and approve it or reject it
if you reject a user, they can candidate as if they haven't submitted anything
if they are accepted they will be able to see in 'my program' everything they can do
Owners, Moderators and default users can see all tasks and sort them by categories or other criteria
Default users can take tasks (only tasks that are 'available' can be taken)
when a task is taken it is now 'in progress' and all the user's tasks can be seen in 'my tasks'
when a task is 'in progress' it can be forfeited
when 'forfeit' is pressed, the task becomes available and other users can take it or you again
when 'complete' is pressed, the task is now 'completed' and no one can take it anymore
if you decide to leave, you'll have no program and you can go through the steps all over again(If you have 'in progress' tasks an error should be displayed which will tell you to complete your tasks before leaving)
if you are a moderator and decide to leave, you become a 'default user'
Now if you are logged in as moderator:

you can add tasks, review user applications and see users info and kick them(for the 'kick' the same logic as 'leave' is used)
Note that 'money to transfer' is calculated by the user's completed tasks' rewards but it will be mentioned when we get to the owner functionalities
if you decide to add a task as a moderator, a form should be displayed and when you fill it and go to 'all tasks' it will not be there
that's because an owner should review it first
if you login as an owner and go to 'task waitlist', the submitted task should be there (you can once again approve it or reject it)
when a submitted task is approved, it can now be seen in 'all tasks' as 'available' and assign date - the moment it is approved
Note that moderators can edit only their created tasks (if they are available)
Now if you are an owner:

you can edit every single task that is available
you can add a task and it will be immediately displayed in 'all tasks' (the tasks created by owners don't go through reviewing)
if you go to 'all users', you will see 2 new buttons - pay and promote
if a user is promoted, they now become moderators and get all the moderators functionalities and lose the default user ones
if you decide to pay a user a form will be displayed with the amount which cannot be changed (it is based on 'money to transfer' which I explained above)
when you pay the user, you can go to 'sent payments' and see the details of the payment (from default user's POV, they can go to my payments and see the details)
if you go to 'all moderators' you will see some info about them and 2 buttons: pay and kick
when you pay a moderator, you can enter manually the amount you want to transfer(everything else is the same about the payment functionality)
If you reached this far, you are probably wondering what happens if the owner, who is the only one who can pay, runs out of money(balance becomes 0.00)

you can go to create transaction
you can enter the amount and decide what type it will be: an addition or withdrawal(the second one simulates the act of taking money out of your balance into real life)
!!!Important!!!

The following is about Stripe functionality. If you didn't manage to run it, I'll show it during the demonstration as I mentioned above

After pressing 'Check out', you will be redirected to the stripe check out page
if you decide to cancel the transaction, you can press the arrow in the upper left corner
then you will be redirected to a 'fail' page
Back to the Stripe check out:

the email is automatically entered (the current owner's email)
you should just enter some credentials (card number: 4242 4242 4242 4242, date: any valid date, CCV: any three-digit number)
the name does not matter
when you press confirm the order and everything goes smoothly, you sould be redirected to a 'success' page
the balance of the owner should now have changed
you can go to 'my transactions' and see what transactions you have made
I think that I covered everything that came to my mind. As I mentioned above, I might have missed something.

I hope you like the project and have fun while using it :)
