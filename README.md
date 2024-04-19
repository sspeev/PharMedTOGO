ASP.NET Advanced February 2024 

PharMedTOGO
The fastest way to receive your medicines!

Necessary NuGet packages:


Stripe.net 44.2 (Stripe is used when the owners make transactions, not payments!!!)
Note: (Just download the stripe package so that the application can build itself correctly. The demo of stripe could be done during the exam because it requires secret and public key and proper localhost port)

Roles:

Default user (Patient):
email: test@mail.com
password: 123456
Admin:
email: admin@mail.com
password: 123456


What can anonymous do:
He can see all medicines and their details.

What patient can do:
He can see all medicines, their details and choose which to add to his shopping cart. Then he can make a transaction in Stripe.

What can admin do:

He can make all CRUD operations on the medicines. This can be done from the public panel.
He can add, edit, delete, and attach sales to medicines. This can be done from the public panel.
There is a dashboard in the admin panel which works with cache. There you can see all registered users and make someone admin if you want.

There is an option for validating the patients’ prescriptions which is explained down below…


Before creating an account, you can see all available medicines and their details. On creation of account, you will be asked for your first and last name. Also, EGN will be required. Then new option in the store should be available: Add to cart.
Now when you add a medicine and click on the shopping cart option, a sidebar should appear on the right where will be the added medicine. If you click on the View cart button, you will be redirected to the shopping cart page with a checkout option which redirects to Stripe. Then you can choose to return in PharMed or to continue your payment. After a successful transaction you will be redirected to the transaction details page, otherwise a transaction fail page will appear.
At the store page where the medicines are displayed there is an information about if the medicine requires prescription. If the users don’t have one, an error page will be shown otherwise the chosen medicine will be successfully added to the shopping cart.
On the home page below the welcoming message, there is an information about prescriptions. If you have or not. By default, when you click on the profile icon, there are options only for managing account and logging out. However, if you got a prescription, there would appear third option called: My prescriptions. When you click there, you will be required to a prescription details page which should contain all the needed information of the user and the prescription status which should be Not Reviewed. When you click the Validate button, it will bring you to the home page. If you visit again the prescription details the status will be changed to Reviewing, you prescription will be sent to the administrator to validate it. Also, the Validate button should have disappeared. You can’t add to shopping cart medicines which require prescription during the review of your prescription from the admin.   When he is ready, on visiting your prescription’s details page, the status should be changed to Finished and the IsValid row should be in green or red color.

There are no add, edit or delete functionalities for prescriptions because they require a Doctor role. (the main reason for this is because the site is something like online pharmacy. If I had added Doctor role, the project would have become a hybrid between a hospital, health clinic and pharmacy, which for me sounds strange) There are 2 seeded prescriptions assigned on the admin@mail.com and test@mail.com.

On logging as an admin, you will be redirected directly to the admin panel. There will be 4 options: Home, Dashboard, Prescriptions and Public panel. In the Prescriptions page will appear all prescriptions which need to be validate
