This is simply a project if you want to experiment with using the fusion log viewer script (tip #1)
I created two versions of this library - one with an EmailAddress property and one without.
At runtim, I copy the old library to the bin folder of the MVC app. It attempts to access the Customer.EmailAddress property which doesnt exist in that version and it blows up. Using the fusion log viewer script you can see the loading of the failed library when you do:
cscript c:\FusLogVwSet.wsf /enable /all

this logs successful loads and failures.
